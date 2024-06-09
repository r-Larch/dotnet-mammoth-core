using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NumberingAnonymous0 : IFunction<IMap<string, NumberingLevel>, IOptional<NumberingLevel>> {
        private string _level;

        internal NumberingAnonymous0(string level)
        {
            _level = level;
        }

        public IOptional<NumberingLevel> Apply(IMap<string, NumberingLevel> levels)
        {
            return Maps.Lookup(levels, _level);
        }
    }
}
