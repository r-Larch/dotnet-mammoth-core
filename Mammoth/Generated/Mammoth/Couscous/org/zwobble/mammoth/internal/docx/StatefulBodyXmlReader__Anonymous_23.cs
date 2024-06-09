using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReaderAnonymous23 : IFunction<IList<IDocumentElement>, IDocumentElement> {
        private IOptional<string> _anchor;
        private IOptional<string> _targetFrame;

        internal StatefulBodyXmlReaderAnonymous23(IOptional<string> anchor, IOptional<string> targetFrame)
        {
            _anchor = anchor;
            _targetFrame = targetFrame;
        }

        public IDocumentElement Apply(IList<IDocumentElement> children)
        {
            return Hyperlink.Anchor((_anchor).Get(), _targetFrame, children);
        }
    }
}
