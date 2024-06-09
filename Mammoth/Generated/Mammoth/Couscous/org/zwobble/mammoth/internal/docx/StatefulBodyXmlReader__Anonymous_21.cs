namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_21 : Mammoth.Couscous.java.util.function.Function<string, string> {
        internal string _targetHref;
        internal Mammoth.Couscous.java.util.Optional<string> _anchor;
        internal StatefulBodyXmlReader__Anonymous_21(string targetHref, Mammoth.Couscous.java.util.Optional<string> anchor) {
            this._targetHref = targetHref;
            this._anchor = anchor;
        }
        public string apply(string fragment) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Uris.replaceFragment(this._targetHref, (this._anchor).get());
        }
    }
}

