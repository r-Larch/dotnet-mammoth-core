using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReaderAnonymous0 : IBiFunction<IOptional<Style>, IList<IDocumentElement>, IDocumentElement> {
        private IXmlElementLike _properties;
        private StatefulBodyXmlReader _thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader;

        internal StatefulBodyXmlReaderAnonymous0(StatefulBodyXmlReader thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader, IXmlElementLike properties)
        {
            _thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader = thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader;
            _properties = properties;
        }

        public IDocumentElement Apply(IOptional<Style> style, IList<IDocumentElement> children)
        {
            var hyperlinkHref = (_thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader).CurrentHyperlinkHref();
            if (hyperlinkHref.IsPresent()) {
                children = Lists.List<IDocumentElement>(Hyperlink.Href(hyperlinkHref.Get(), Optional.Empty<string>(), children));
            }

            return new Run((_thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader).IsBold(_properties), (_thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader).IsItalic(_properties), (_thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader).IsUnderline(_properties), (_thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader).IsStrikethrough(_properties), (_thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader).IsSmallCaps(_properties), (_thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader).ReadVerticalAlignment(_properties), style, children);
        }
    }
}
