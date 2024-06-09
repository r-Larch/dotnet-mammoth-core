namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_10 : Mammoth.Couscous.java.util.function.BiFunction<string, string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal StatefulBodyXmlReader__Anonymous_10(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> apply(string arg0, string arg1) {
            return ((this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader)._numbering).findLevel(arg0, arg1);
        }
    }
}

