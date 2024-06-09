using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMapAnonymous0 : IPredicate<StyleMapping<Paragraph>> {
        private Paragraph _paragraph;

        internal StyleMapAnonymous0(Paragraph paragraph)
        {
            _paragraph = paragraph;
        }

        public bool Test(StyleMapping<Paragraph> styleMapping)
        {
            return styleMapping.Matches(_paragraph);
        }
    }
}
