using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlAnonymous0 : IConsumer<IHtmlNode> {
        private StringBuilder _builder;

        internal HtmlAnonymous0(StringBuilder builder)
        {
            _builder = builder;
        }

        public void Accept(IHtmlNode node)
        {
            HtmlWriter.Write(node, _builder);
        }
    }
}
