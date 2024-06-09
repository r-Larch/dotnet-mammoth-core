namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class HtmlPath_static {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath _EMPTY;
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath _IGNORE;
        static HtmlPath_static() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static._EMPTY = new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElements(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement>());
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static._IGNORE = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.Ignore._INSTANCE;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath elements(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement[] elements) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElements(Mammoth.Couscous.java.util.Arrays.asList<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement>(elements));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath element(string tagName) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static.element(tagName, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath element(string tagName, Mammoth.Couscous.java.util.Map<string, string> attributes) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTag tag = new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTag(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(tagName), attributes, false, "");
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElements(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement(tag)));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath collapsibleElement(string tagName) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static.collapsibleElement(tagName, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath collapsibleElement(Mammoth.Couscous.java.util.List<string> tagNames) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static.collapsibleElement(tagNames, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath collapsibleElement(string tagName, Mammoth.Couscous.java.util.Map<string, string> attributes) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static.collapsibleElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(tagName), attributes);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath collapsibleElement(Mammoth.Couscous.java.util.List<string> tagNames, Mammoth.Couscous.java.util.Map<string, string> attributes) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTag tag = new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlTag(tagNames, attributes, true, "");
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElements(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPathElement(tag)));
        }
    }
}

