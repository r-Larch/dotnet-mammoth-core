namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_23 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        internal Mammoth.Couscous.java.util.Optional<string> _anchor;
        internal Mammoth.Couscous.java.util.Optional<string> _targetFrame;
        internal StatefulBodyXmlReader__Anonymous_23(Mammoth.Couscous.java.util.Optional<string> anchor, Mammoth.Couscous.java.util.Optional<string> targetFrame) {
            this._anchor = anchor;
            this._targetFrame = targetFrame;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink.anchor((this._anchor).get(), this._targetFrame, children);
        }
    }
}

