using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap__Anonymous_0 : Predicate<StyleMapping<Paragraph>> {
        private Paragraph _paragraph;

        internal StyleMap__Anonymous_0(Paragraph paragraph)
        {
            _paragraph = paragraph;
        }

        public bool test(StyleMapping<Paragraph> styleMapping)
        {
            return styleMapping.matches(_paragraph);
        }
    }
}
