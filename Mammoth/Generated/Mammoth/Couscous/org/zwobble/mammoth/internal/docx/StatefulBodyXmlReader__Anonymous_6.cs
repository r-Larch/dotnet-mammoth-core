using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReaderAnonymous6 : IBiFunction<IOptional<Style>, IList<IDocumentElement>, IDocumentElement> {
        private ParagraphIndent _indent;
        private IOptional<NumberingLevel> _numbering;

        internal StatefulBodyXmlReaderAnonymous6(IOptional<NumberingLevel> numbering, ParagraphIndent indent)
        {
            _numbering = numbering;
            _indent = indent;
        }

        public IDocumentElement Apply(IOptional<Style> style, IList<IDocumentElement> children)
        {
            return new Paragraph(style, _numbering, _indent, children);
        }
    }
}
