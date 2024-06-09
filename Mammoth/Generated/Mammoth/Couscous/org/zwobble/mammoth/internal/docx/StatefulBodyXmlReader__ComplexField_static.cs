namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__ComplexField_static {
        internal static StatefulBodyXmlReader__ComplexField _UNKNOWN;

        static StatefulBodyXmlReader__ComplexField_static()
        {
            _UNKNOWN = new StatefulBodyXmlReader__Anonymous_30();
        }

        public static StatefulBodyXmlReader__ComplexField hyperlink(string href)
        {
            return new StatefulBodyXmlReader__HyperlinkComplexField(href);
        }
    }
}
