namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_27 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal Mammoth.Couscous.java.util.Optional<string> _altText;
        internal StatefulBodyXmlReader__Anonymous_27(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, Mammoth.Couscous.java.util.Optional<string> altText) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
            this._altText = altText;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement blip) {
            return (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).readBlip(blip, this._altText);
        }
    }
}

