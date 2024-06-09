namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_17 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike _properties;
        internal int _colspan;
        internal StatefulBodyXmlReader__Anonymous_17(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties, int colspan) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
            this._properties = properties;
            this._colspan = colspan;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__UnmergedTableCell((this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).readVmerge(this._properties), this._colspan, children);
        }
    }
}

