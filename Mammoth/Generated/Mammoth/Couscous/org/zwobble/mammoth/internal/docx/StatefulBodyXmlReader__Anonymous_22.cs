namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_22 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        internal string _href;
        internal Mammoth.Couscous.java.util.Optional<string> _targetFrame;
        internal StatefulBodyXmlReader__Anonymous_22(string href, Mammoth.Couscous.java.util.Optional<string> targetFrame) {
            this._href = href;
            this._targetFrame = targetFrame;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink.href(this._href, this._targetFrame, children);
        }
    }
}

