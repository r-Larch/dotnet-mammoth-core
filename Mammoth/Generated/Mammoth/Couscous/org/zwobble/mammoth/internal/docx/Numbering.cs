using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Numbering {
        public static Numbering Empty;
        private IMap<string, IMap<string, NumberingLevel>> _numbering;

        static Numbering()
        {
            Empty = new Numbering(Maps.Map<string, IMap<string, NumberingLevel>>());
        }

        internal Numbering(IMap<string, IMap<string, NumberingLevel>> numbering)
        {
            _numbering = numbering;
        }

        public IOptional<NumberingLevel> FindLevel(string numId, string level)
        {
            return (Maps.Lookup(_numbering, numId)).FlatMap(new NumberingAnonymous0(level));
        }
    }
}
