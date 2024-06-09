using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMapAnonymous6 : IPredicate<StyleMapping<Break>> {
        private Break _breakElement;

        internal StyleMapAnonymous6(Break breakElement)
        {
            _breakElement = breakElement;
        }

        public bool Test(StyleMapping<Break> styleMapping)
        {
            return styleMapping.Matches(_breakElement);
        }
    }
}
