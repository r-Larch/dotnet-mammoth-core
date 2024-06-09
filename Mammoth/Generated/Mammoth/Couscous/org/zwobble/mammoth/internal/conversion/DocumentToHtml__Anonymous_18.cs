using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlAnonymous18 : IConsumer<string> {
        private IMap<string, string> _attributes;

        internal DocumentToHtmlAnonymous18(IMap<string, string> attributes)
        {
            _attributes = attributes;
        }

        public void Accept(string altText)
        {
            (_attributes).Put("alt", altText);
        }
    }
}
