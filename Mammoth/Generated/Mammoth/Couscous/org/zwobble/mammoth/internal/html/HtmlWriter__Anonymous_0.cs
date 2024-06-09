using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlWriterAnonymous0(StringBuilder builder) : IConsumer<IHtmlNode> {
        public void Accept(IHtmlNode child)
        {
            HtmlWriter.Write(child, builder);
        }
    }

    internal class HtmlWriterAnonymous1(StringBuilder builder) : IHtmlNodeVisitor {
        public void Visit(HtmlElement element)
        {
            builder.Append("<").Append(element.GetTagName());
            HtmlWriter.GenerateAttributes(element.GetAttributes(), builder);
            if (element.IsVoid()) {
                builder.Append(" />");
            }
            else {
                builder.Append(">");
                element.GetChildren().ForEach(new HtmlWriterAnonymous0(builder));
                builder.Append("</").Append(element.GetTagName()).Append(">");
            }
        }

        public void Visit(HtmlTextNode node)
        {
            builder.Append(HtmlWriter.EscapeText(node.GetValue()));
        }

        public void Visit(HtmlForceWrite forceWrite)
        {
        }
    }

    internal class HtmlWriterAnonymous2 : IFunction<IMapEntry<string, string>, string> {
        public string Apply(IMapEntry<string, string> arg0)
        {
            return arg0.GetKey();
        }
    }
}
