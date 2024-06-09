using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_6 : BiFunction<Optional<Style>, List<DocumentElement>, DocumentElement> {
        internal ParagraphIndent _indent;
        internal Optional<NumberingLevel> _numbering;

        internal StatefulBodyXmlReader__Anonymous_6(Optional<NumberingLevel> numbering, ParagraphIndent indent)
        {
            _numbering = numbering;
            _indent = indent;
        }

        public DocumentElement apply(Optional<Style> style, List<DocumentElement> children)
        {
            return new Paragraph(style, _numbering, _indent, children);
        }
    }
}
