namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_9 : Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal string _styleType;
        internal Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> _findStyleById;
        internal StatefulBodyXmlReader__Anonymous_9(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, string styleType, Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> findStyleById) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
            this._styleType = styleType;
            this._findStyleById = findStyleById;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> apply(string styleId) {
            return (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).findStyleById(this._styleType, styleId, this._findStyleById);
        }
    }
}

