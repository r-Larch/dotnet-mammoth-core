using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlWriter {
        public static void Write(IHtmlNode node, StringBuilder builder)
        {
            node.Accept(new HtmlWriterAnonymous1(builder));
        }

        public static void GenerateAttributes(IMap<string, string> attributes, StringBuilder builder)
        {
            {
                var couscousDesugarForeachToFor5 = Lists.OrderedBy(attributes.EntrySet(), new HtmlWriterAnonymous2()).Iterator();
                while (couscousDesugarForeachToFor5.HasNext()) {
                    var attribute = couscousDesugarForeachToFor5.Next();
                    builder.Append(" ").Append(attribute.GetKey()).Append("=\"").Append(EscapeAttributeValue(attribute.GetValue())).Append("\"");
                }
            }
        }

        public static string EscapeText(string text)
        {
            return JavaStringExtensions.Replace(JavaStringExtensions.Replace(JavaStringExtensions.Replace(text, "&", "&amp;"), "<", "&lt;"), ">", "&gt;");
        }

        public static string EscapeAttributeValue(string value)
        {
            return JavaStringExtensions.Replace(EscapeText(value), "\"", "&quot;");
        }
    }
}
