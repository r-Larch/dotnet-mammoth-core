using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlAnonymous14 : IConsumer<string> {
        private IMap<string, string> _attributes;

        internal DocumentToHtmlAnonymous14(IMap<string, string> attributes)
        {
            _attributes = attributes;
        }

        public void Accept(string targetFrame)
        {
            (_attributes).Put("target", targetFrame);
        }
    }
}
