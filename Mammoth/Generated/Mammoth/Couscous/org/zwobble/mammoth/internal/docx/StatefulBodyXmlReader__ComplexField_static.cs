namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReaderComplexFieldStatic {
        internal static IStatefulBodyXmlReaderComplexField Unknown;

        static StatefulBodyXmlReaderComplexFieldStatic()
        {
            Unknown = new StatefulBodyXmlReaderAnonymous30();
        }

        public static IStatefulBodyXmlReaderComplexField Hyperlink(string href)
        {
            return new StatefulBodyXmlReaderHyperlinkComplexField(href);
        }
    }
}
