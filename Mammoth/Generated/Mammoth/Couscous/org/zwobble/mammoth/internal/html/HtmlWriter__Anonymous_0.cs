using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlWriterAnonymous0 : IConsumer<IHtmlNode> {
        private StringBuilder _builder;

        internal HtmlWriterAnonymous0(StringBuilder builder)
        {
            _builder = builder;
        }

        public void Accept(IHtmlNode child)
        {
            HtmlWriter.Write(child, _builder);
        }
    }
}
