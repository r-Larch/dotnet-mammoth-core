using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class EmbeddedStyleMap {
        private static string _styleMapPath;
        private static string _absoluteStyleMapPath;
        private static string _relationshipsPath;
        private static string _contentTypesPath;
        private static NamespacePrefixes _relationshipsNamespaces;
        private static NamespacePrefixes _contentTypesNamespaces;

        static EmbeddedStyleMap()
        {
            _styleMapPath = "mammoth/style-map";
            _absoluteStyleMapPath = "/" + _styleMapPath;
            _relationshipsPath = "word/_rels/document.xml.rels";
            _contentTypesPath = "[Content_Types].xml";
            _relationshipsNamespaces = ((NamespacePrefixes.Builder()).DefaultPrefix("http://schemas.openxmlformats.org/package/2006/relationships")).Build();
            _contentTypesNamespaces = ((NamespacePrefixes.Builder()).DefaultPrefix("http://schemas.openxmlformats.org/package/2006/content-types")).Build();
        }

        public static IOptional<string> ReadStyleMap(IArchive file)
        {
            return (file.TryGetInputStream(_styleMapPath)).Map(new EmbeddedStyleMapAnonymous0());
        }

        public static void EmbedStyleMap(IMutableArchive archive, string styleMap)
        {
            archive.WriteEntry(_styleMapPath, styleMap);
            UpdateRelationships(archive);
            UpdateContentTypes(archive);
        }

        public static void UpdateRelationships(IMutableArchive archive)
        {
            var parser = new XmlParser(_relationshipsNamespaces);
            var relationships = parser.ParseStream(Archives.GetInputStream(archive, _relationshipsPath));
            var relationship = XmlNodes.Element("Relationship", Maps.Map("Id", "rMammothStyleMap", "Type", "http://schemas.zwobble.org/mammoth/style-map", "Target", _absoluteStyleMapPath));
            var updatedRelationships = UpdateOrAddElement(relationships, relationship, "Id");
            archive.WriteEntry(_relationshipsPath, XmlWriter.ToString(updatedRelationships, _relationshipsNamespaces));
        }

        public static void UpdateContentTypes(IMutableArchive archive)
        {
            var parser = new XmlParser(_contentTypesNamespaces);
            var contentTypes = parser.ParseStream(Archives.GetInputStream(archive, _contentTypesPath));
            var @override = XmlNodes.Element("Override", Maps.Map("PartName", _absoluteStyleMapPath, "ContentType", "text/prs.mammoth.style-map"));
            var updatedRelationships = UpdateOrAddElement(contentTypes, @override, "PartName");
            archive.WriteEntry(_contentTypesPath, XmlWriter.ToString(updatedRelationships, _contentTypesNamespaces));
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
