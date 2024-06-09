using System;
using System.Xml;
using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing {
    internal static class SimpleSax {
        internal static void ParseStream(INputStream input, ISimpleSaxHandler handler)
        {
            var reader = XmlReader.Create(input.Stream);
            while (reader.Read()) {
                switch (reader.NodeType) {
                    case XmlNodeType.Element:
                        var name = new ElementName(reader.NamespaceURI, reader.LocalName);
                        var attributes = new HashMap<ElementName, string>();
                        var isEmpty = reader.IsEmptyElement;
                        for (var attributeIndex = 0; attributeIndex < reader.AttributeCount; attributeIndex++) {
                            reader.MoveToAttribute(attributeIndex);
                            attributes.Put(new ElementName(reader.NamespaceURI, reader.LocalName), reader.Value);
                        }

                        handler.StartElement(name, attributes);
                        if (isEmpty) {
                            handler.EndElement();
                        }

                        break;
                    case XmlNodeType.CDATA:
                    case XmlNodeType.Text:
                    case XmlNodeType.SignificantWhitespace:
                        handler.Characters(reader.Value);
                        break;
                    case XmlNodeType.EntityReference:
                        throw new NotImplementedException();
                    case XmlNodeType.EndElement:
                        handler.EndElement();
                        break;
                }
            }
        }

        internal static void ParseString(string value, ISimpleSaxHandler handler)
        {
            throw new NotImplementedException();
        }
    }
}
