using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class EmbeddedStyleMap {
        private const string StyleMapPath = "mammoth/style-map";
        private const string AbsoluteStyleMapPath = $"/{StyleMapPath}";
        private const string RelationshipsPath = "word/_rels/document.xml.rels";
        private const string ContentTypesPath = "[Content_Types].xml";
        private static readonly NamespacePrefixes RelationshipsNamespaces = NamespacePrefixes.Builder().DefaultPrefix("http://schemas.openxmlformats.org/package/2006/relationships").Build();
        private static readonly NamespacePrefixes ContentTypesNamespaces = NamespacePrefixes.Builder().DefaultPrefix("http://schemas.openxmlformats.org/package/2006/content-types").Build();

        public static IOptional<string> ReadStyleMap(IArchive file)
        {
            return file.TryGetInputStream(StyleMapPath).Map(new EmbeddedStyleMapAnonymous0());
        }

        public static void EmbedStyleMap(IMutableArchive archive, string styleMap)
        {
            archive.WriteEntry(StyleMapPath, styleMap);
            UpdateRelationships(archive);
            UpdateContentTypes(archive);
        }

        public static void UpdateRelationships(IMutableArchive archive)
        {
            var parser = new XmlParser(RelationshipsNamespaces);
            var relationships = parser.ParseStream(Archives.GetInputStream(archive, RelationshipsPath));
            var relationship = XmlNodes.Element("Relationship", Maps.Map("Id", "rMammothStyleMap", "Type", "http://schemas.zwobble.org/mammoth/style-map", "Target", AbsoluteStyleMapPath));
            var updatedRelationships = UpdateOrAddElement(relationships, relationship, "Id");
            archive.WriteEntry(RelationshipsPath, XmlWriter.ToString(updatedRelationships, RelationshipsNamespaces));
        }

        public static void UpdateContentTypes(IMutableArchive archive)
        {
            var parser = new XmlParser(ContentTypesNamespaces);
            var contentTypes = parser.ParseStream(Archives.GetInputStream(archive, ContentTypesPath));
            var @override = XmlNodes.Element("Override", Maps.Map("PartName", AbsoluteStyleMapPath, "ContentType", "text/prs.mammoth.style-map"));
            var updatedRelationships = UpdateOrAddElement(contentTypes, @override, "PartName");
            archive.WriteEntry(ContentTypesPath, XmlWriter.ToString(updatedRelationships, ContentTypesNamespaces));
        }

        public static XmlElement UpdateOrAddElement(XmlElement parent, XmlElement element, string identifyingAttribute)
        {
            var index = Iterables.FindIndex(parent.GetChildren(), new EmbeddedStyleMapAnonymous2(element, identifyingAttribute));
            IList<IXmlNode> children = new ArrayList<IXmlNode>(parent.GetChildren());
            if (index.IsPresent()) {
                children.Set(index.GetAsInt(), element);
            }
            else {
                children.Add(element);
            }

            return new XmlElement(parent.GetName(), parent.GetAttributes(), children);
        }
    }
}
