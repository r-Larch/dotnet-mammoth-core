using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class EmbeddedStyleMap {
        internal static string _STYLE_MAP_PATH;
        internal static string _ABSOLUTE_STYLE_MAP_PATH;
        internal static string _RELATIONSHIPS_PATH;
        internal static string _CONTENT_TYPES_PATH;
        internal static NamespacePrefixes _RELATIONSHIPS_NAMESPACES;
        internal static NamespacePrefixes _CONTENT_TYPES_NAMESPACES;

        static EmbeddedStyleMap()
        {
            _STYLE_MAP_PATH = "mammoth/style-map";
            _ABSOLUTE_STYLE_MAP_PATH = "/" + _STYLE_MAP_PATH;
            _RELATIONSHIPS_PATH = "word/_rels/document.xml.rels";
            _CONTENT_TYPES_PATH = "[Content_Types].xml";
            _RELATIONSHIPS_NAMESPACES = ((NamespacePrefixes.builder()).defaultPrefix("http://schemas.openxmlformats.org/package/2006/relationships")).build();
            _CONTENT_TYPES_NAMESPACES = ((NamespacePrefixes.builder()).defaultPrefix("http://schemas.openxmlformats.org/package/2006/content-types")).build();
        }

        public static Optional<string> readStyleMap(Archive file)
        {
            return (file.tryGetInputStream(_STYLE_MAP_PATH)).map(new EmbeddedStyleMap__Anonymous_0());
        }

        public static void embedStyleMap(MutableArchive archive, string styleMap)
        {
            archive.writeEntry(_STYLE_MAP_PATH, styleMap);
            updateRelationships(archive);
            updateContentTypes(archive);
        }

        public static void updateRelationships(MutableArchive archive)
        {
            var parser = new XmlParser(_RELATIONSHIPS_NAMESPACES);
            var relationships = parser.parseStream(Archives.getInputStream(archive, _RELATIONSHIPS_PATH));
            var relationship = XmlNodes.element("Relationship", Maps.map("Id", "rMammothStyleMap", "Type", "http://schemas.zwobble.org/mammoth/style-map", "Target", _ABSOLUTE_STYLE_MAP_PATH));
            var updatedRelationships = updateOrAddElement(relationships, relationship, "Id");
            archive.writeEntry(_RELATIONSHIPS_PATH, XmlWriter.toString(updatedRelationships, _RELATIONSHIPS_NAMESPACES));
        }

        public static void updateContentTypes(MutableArchive archive)
        {
            var parser = new XmlParser(_CONTENT_TYPES_NAMESPACES);
            var contentTypes = parser.parseStream(Archives.getInputStream(archive, _CONTENT_TYPES_PATH));
            var @override = XmlNodes.element("Override", Maps.map("PartName", _ABSOLUTE_STYLE_MAP_PATH, "ContentType", "text/prs.mammoth.style-map"));
            var updatedRelationships = updateOrAddElement(contentTypes, @override, "PartName");
            archive.writeEntry(_CONTENT_TYPES_PATH, XmlWriter.toString(updatedRelationships, _CONTENT_TYPES_NAMESPACES));
        }

        public static XmlElement updateOrAddElement(XmlElement parent, XmlElement element, string identifyingAttribute)
        {
            var index = Iterables.findIndex(parent.getChildren(), new EmbeddedStyleMap__Anonymous_2(element, identifyingAttribute));
            List<XmlNode> children = new ArrayList<XmlNode>(parent.getChildren());
            if (index.isPresent()) {
                children.set(index.getAsInt(), element);
            }
            else {
                children.add(element);
            }

            return new XmlElement(parent.getName(), parent.getAttributes(), children);
        }
    }
}
