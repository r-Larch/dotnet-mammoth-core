using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_0 : BiFunction<Optional<Style>, List<DocumentElement>, DocumentElement> {
        internal XmlElementLike _properties;
        internal StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;

        internal StatefulBodyXmlReader__Anonymous_0(StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, XmlElementLike properties)
        {
            _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
            _properties = properties;
        }

        public DocumentElement apply(Optional<Style> style, List<DocumentElement> children)
        {
            var hyperlinkHref = (_this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).currentHyperlinkHref();
            if (hyperlinkHref.isPresent()) {
                children = Lists.list<DocumentElement>(Hyperlink.href(hyperlinkHref.get(), Optional.empty<string>(), children));
            }

            return new Run((_this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).isBold(_properties), (_this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).isItalic(_properties), (_this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).isUnderline(_properties), (_this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).isStrikethrough(_properties), (_this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).isSmallCaps(_properties), (_this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).readVerticalAlignment(_properties), style, children);
        }
    }
}
