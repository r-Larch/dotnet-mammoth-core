using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Numbering(IMap<string, IMap<string, NumberingLevel>> numbering) {
        public static Numbering Empty = new(Maps.Map<string, IMap<string, NumberingLevel>>());

        public IOptional<NumberingLevel> FindLevel(string numId, string level)
        {
            return Maps.Lookup(numbering, numId).FlatMap(new NumberingAnonymous0(level));
        }
    }

    internal class NumberingAnonymous0(string level) : IFunction<IMap<string, NumberingLevel>, IOptional<NumberingLevel>> {
        public IOptional<NumberingLevel> Apply(IMap<string, NumberingLevel> levels) => Maps.Lookup(levels, level);
    }
}
