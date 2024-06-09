namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_0 : Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike _properties;
        internal StatefulBodyXmlReader__Anonymous_0(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
            this._properties = properties;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children) {
            Mammoth.Couscous.java.util.Optional<string> hyperlinkHref = (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).currentHyperlinkHref();
            if (hyperlinkHref.isPresent()) {
                children = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink.href(hyperlinkHref.get(), Mammoth.Couscous.java.util.Optional.empty<string>(), children));
            }
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run((this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).isBold(this._properties), (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).isItalic(this._properties), (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).isUnderline(this._properties), (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).isStrikethrough(this._properties), (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).isSmallCaps(this._properties), (this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).readVerticalAlignment(this._properties), style, children);
        }
    }
}

