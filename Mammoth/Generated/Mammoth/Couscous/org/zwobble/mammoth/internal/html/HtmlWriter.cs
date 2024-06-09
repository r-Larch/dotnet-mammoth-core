using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlWriter {
        public static void write(HtmlNode node, StringBuilder builder)
        {
            node.accept(new HtmlWriter__Anonymous_1(builder));
        }

        public static void generateAttributes(Map<string, string> attributes, StringBuilder builder)
        {
            {
                var _couscous_desugar_foreach_to_for5 = (Lists.orderedBy(attributes.entrySet(), new HtmlWriter__Anonymous_2())).iterator();
                while (_couscous_desugar_foreach_to_for5.hasNext()) {
                    var attribute = _couscous_desugar_foreach_to_for5.next();
                    ((((builder.append(" ")).append(attribute.getKey())).append("=\"")).append(escapeAttributeValue(attribute.getValue()))).append("\"");
                }
            }
        }

        public static string escapeText(string text)
        {
            return ((text.replace("&", "&amp;")).replace("<", "&lt;")).replace(">", "&gt;");
        }

        public static string escapeAttributeValue(string value)
        {
            return (escapeText(value)).replace("\"", "&quot;");
        }
    }
}
