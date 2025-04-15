// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;
using Microsoft.CodeAnalysis;

namespace Azure.EventGrid.Messaging.SourceGeneration;

internal class SourceVisitor : SymbolVisitor
{
    public List<SystemEventNode> SystemEvents { get; } = new();

    public override void VisitNamespace(INamespaceSymbol symbol)
    {
        foreach (INamespaceOrTypeSymbol childSymbol in symbol.GetMembers())
        {
            childSymbol.Accept(this);
        }
    }

    public override void VisitNamedType(INamedTypeSymbol symbol)
    {
        if (!symbol.Name.EndsWith("EventData", StringComparison.Ordinal))
        {
            return;
        }

        string summaryText = null;
        using (var stringReader = new StringReader(symbol.GetDocumentationCommentXml()))
        using (XmlReader reader = XmlReader.Create(stringReader))
        {
            bool inMember = false;
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.Name == "member")
                    {
                        inMember = true;
                    }
                    else if (inMember && reader.Name == "summary")
                    {
                        summaryText = reader.ReadElementContentAsString();
                        break;
                    }
                }
                else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "member")
                {
                    inMember = false;
                }
            }
        }

        if (string.IsNullOrEmpty(summaryText))
        {
            return;
        }

        string type = null;
        // the event name is either 3 or 4 parts, e.g. Microsoft.AppConfiguration.KeyValueDeleted or Microsoft.ResourceNotifications.HealthResources.AvailabilityStatusChanged
        Match match = Regex.Match(summaryText, @"Microsoft\.[A-Za-z]+(\.[A-Za-z]+){1,2}");
        if (!match.Success)
        {
            // We expect some EventData to not have event types if they are base types,
            // e.g. ContainerRegistryEventData
            return;
        }

        type = $@"""{match.Value}""";
        SystemEvents.Add(
            new SystemEventNode
            {
                EventName = symbol.Name,
                EventType = type,
                DeserializeMethod = symbol.MemberNames.Single(m => m.StartsWith("Deserialize"))
            });
    }
}
