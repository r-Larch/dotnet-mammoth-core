namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_25 : Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement _element;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal StatefulBodyXmlReader__Anonymous_25(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader) {
            this._element = element;
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult apply(string relationshipId) {
            Mammoth.Couscous.java.util.Optional<string> title = (this._element).getAttributeOrNone("o:title");
            string imagePath = (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).relationshipIdToDocxPath(relationshipId);
            return (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).readImage(imagePath, title, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_24(this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, imagePath));
        }
    }
}

