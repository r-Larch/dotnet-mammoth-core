using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMap__Anonymous_2 : Predicate<StyleMapping<Run>> {
        private Run _run;

        internal StyleMap__Anonymous_2(Run run)
        {
            _run = run;
        }

        public bool test(StyleMapping<Run> styleMapping)
        {
            return styleMapping.matches(_run);
        }
    }
}
