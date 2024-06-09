namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlWriter {
        public static void write(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode node, Mammoth.Couscous.java.lang.StringBuilder builder) {
            node.accept(new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter__Anonymous_1(builder));
        }
        public static void generateAttributes(Mammoth.Couscous.java.util.Map<string, string> attributes, Mammoth.Couscous.java.lang.StringBuilder builder) {
             {
                Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.java.util.Map__Entry<string, string>> _couscous_desugar_foreach_to_for5 = (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.orderedBy<Mammoth.Couscous.java.util.Map__Entry<string, string>, string>(attributes.entrySet(), new Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter__Anonymous_2())).iterator();
                while (_couscous_desugar_foreach_to_for5.hasNext()) {
                    Mammoth.Couscous.java.util.Map__Entry<string, string> attribute = _couscous_desugar_foreach_to_for5.next();
                    ((((builder.append(" ")).append(attribute.getKey())).append("=\"")).append(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter.escapeAttributeValue(attribute.getValue()))).append("\"");
                }
            }
        }
        public static string escapeText(string text) {
            return ((text.replace("&", "&amp;")).replace("<", "&lt;")).replace(">", "&gt;");
        }
        public static string escapeAttributeValue(string value) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlWriter.escapeText(value)).replace("\"", "&quot;");
        }
    }
}

