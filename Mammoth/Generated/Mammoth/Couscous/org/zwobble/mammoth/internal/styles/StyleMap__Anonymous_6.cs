using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap__Anonymous_6 : Predicate<StyleMapping<Break>> {
        internal Break _breakElement;

        internal StyleMap__Anonymous_6(Break breakElement)
        {
            _breakElement = breakElement;
        }

        public bool test(StyleMapping<Break> styleMapping)
        {
            return styleMapping.matches(_breakElement);
        }
    }
}
