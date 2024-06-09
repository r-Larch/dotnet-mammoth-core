namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_13 : Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal StatefulBodyXmlReader__Anonymous_13(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> apply(string arg0) {
            return ((this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader)._styles).findTableStyleById(arg0);
        }
    }
}

