using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_22 : Function<List<DocumentElement>, DocumentElement> {
        private string _href;
        private Optional<string> _targetFrame;

        internal StatefulBodyXmlReader__Anonymous_22(string href, Optional<string> targetFrame)
        {
            _href = href;
            _targetFrame = targetFrame;
        }

        public DocumentElement apply(List<DocumentElement> children)
        {
            return Hyperlink.href(_href, _targetFrame, children);
        }
    }
}
