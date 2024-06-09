using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReaderAnonymous22 : IFunction<IList<IDocumentElement>, IDocumentElement> {
        private string _href;
        private IOptional<string> _targetFrame;

        internal StatefulBodyXmlReaderAnonymous22(string href, IOptional<string> targetFrame)
        {
            _href = href;
            _targetFrame = targetFrame;
        }

        public IDocumentElement Apply(IList<IDocumentElement> children)
        {
            return Hyperlink.Href(_href, _targetFrame, children);
        }
    }
}
