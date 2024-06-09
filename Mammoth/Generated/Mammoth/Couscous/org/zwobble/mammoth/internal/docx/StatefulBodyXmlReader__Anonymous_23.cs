using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_23 : Function<List<DocumentElement>, DocumentElement> {
        private Optional<string> _anchor;
        private Optional<string> _targetFrame;

        internal StatefulBodyXmlReader__Anonymous_23(Optional<string> anchor, Optional<string> targetFrame)
        {
            _anchor = anchor;
            _targetFrame = targetFrame;
        }

        public DocumentElement apply(List<DocumentElement> children)
        {
            return Hyperlink.anchor((_anchor).get(), _targetFrame, children);
        }
    }
}
