using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Numbering__Anonymous_0 : Function<Map<string, NumberingLevel>, Optional<NumberingLevel>> {
        internal string _level;

        internal Numbering__Anonymous_0(string level)
        {
            _level = level;
        }

        public Optional<NumberingLevel> apply(Map<string, NumberingLevel> levels)
        {
            return Maps.lookup(levels, _level);
        }
    }
}
