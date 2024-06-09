using Mammoth.Couscous.java.lang;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlWriterAnonymous1 : IHtmlNodeVisitor {
        private StringBuilder _builder;

        internal HtmlWriterAnonymous1(StringBuilder builder)
        {
            _builder = builder;
        }

        public void Visit(HtmlElement element)
        {
            ((_builder).Append("<")).Append(element.GetTagName());
            HtmlWriter.GenerateAttributes(element.GetAttributes(), _builder);
            if (element.IsVoid()) {
                (_builder).Append(" />");
            }
            else {
                (_builder).Append(">");
                (element.GetChildren()).ForEach(new HtmlWriterAnonymous0(_builder));
                (((_builder).Append("</")).Append(element.GetTagName())).Append(">");
            }
        }

        public void Visit(HtmlTextNode node)
        {
            (_builder).Append(HtmlWriter.EscapeText(node.GetValue()));
        }

        public void Visit(HtmlForceWrite forceWrite)
        {
        }
    }
}
