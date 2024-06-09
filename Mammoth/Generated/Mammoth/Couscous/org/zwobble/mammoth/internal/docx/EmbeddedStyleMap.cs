namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class EmbeddedStyleMap {
        internal static string _STYLE_MAP_PATH;
        internal static string _ABSOLUTE_STYLE_MAP_PATH;
        internal static string _RELATIONSHIPS_PATH;
        internal static string _CONTENT_TYPES_PATH;
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes _RELATIONSHIPS_NAMESPACES;
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes _CONTENT_TYPES_NAMESPACES;
        static EmbeddedStyleMap() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._STYLE_MAP_PATH = "mammoth/style-map";
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._ABSOLUTE_STYLE_MAP_PATH = "/" + Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._STYLE_MAP_PATH;
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._RELATIONSHIPS_PATH = "word/_rels/document.xml.rels";
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._CONTENT_TYPES_PATH = "[Content_Types].xml";
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._RELATIONSHIPS_NAMESPACES = ((Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes.builder()).defaultPrefix("http://schemas.openxmlformats.org/package/2006/relationships")).build();
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._CONTENT_TYPES_NAMESPACES = ((Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NamespacePrefixes.builder()).defaultPrefix("http://schemas.openxmlformats.org/package/2006/content-types")).build();
        }
        public static Mammoth.Couscous.java.util.Optional<string> readStyleMap(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive file) {
            return (file.tryGetInputStream(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._STYLE_MAP_PATH)).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap__Anonymous_0());
        }
        public static void embedStyleMap(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.MutableArchive archive, string styleMap) {
            archive.writeEntry(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._STYLE_MAP_PATH, styleMap);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap.updateRelationships(archive);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap.updateContentTypes(archive);
        }
        public static void updateRelationships(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.MutableArchive archive) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser parser = new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._RELATIONSHIPS_NAMESPACES);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement relationships = parser.parseStream(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archives.getInputStream(archive, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._RELATIONSHIPS_PATH));
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement relationship = Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNodes.element("Relationship", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("Id", "rMammothStyleMap", "Type", "http://schemas.zwobble.org/mammoth/style-map", "Target", Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._ABSOLUTE_STYLE_MAP_PATH));
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement updatedRelationships = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap.updateOrAddElement(relationships, relationship, "Id");
            archive.writeEntry(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._RELATIONSHIPS_PATH, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlWriter.toString(updatedRelationships, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._RELATIONSHIPS_NAMESPACES));
        }
        public static void updateContentTypes(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.MutableArchive archive) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser parser = new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.parsing.XmlParser(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._CONTENT_TYPES_NAMESPACES);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement contentTypes = parser.parseStream(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archives.getInputStream(archive, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._CONTENT_TYPES_PATH));
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement @override = Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNodes.element("Override", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("PartName", Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._ABSOLUTE_STYLE_MAP_PATH, "ContentType", "text/prs.mammoth.style-map"));
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement updatedRelationships = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap.updateOrAddElement(contentTypes, @override, "PartName");
            archive.writeEntry(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._CONTENT_TYPES_PATH, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlWriter.toString(updatedRelationships, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap._CONTENT_TYPES_NAMESPACES));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement updateOrAddElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement parent, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element, string identifyingAttribute) {
            Mammoth.Couscous.java.util.OptionalInt index = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.findIndex<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>(parent.getChildren(), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.EmbeddedStyleMap__Anonymous_2(element, identifyingAttribute));
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> children = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode>(parent.getChildren());
            if (index.isPresent()) {
                children.set(index.getAsInt(), element);
            } else {
                children.add(element);
            }
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement(parent.getName(), parent.getAttributes(), children);
        }
    }
}

