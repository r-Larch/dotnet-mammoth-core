using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class StyleMapAnonymous2 : IPredicate<StyleMapping<Run>> {
        private Run _run;

        internal StyleMapAnonymous2(Run run)
        {
            _run = run;
        }

        public bool Test(StyleMapping<Run> styleMapping)
        {
            return styleMapping.Matches(_run);
        }
    }
}
