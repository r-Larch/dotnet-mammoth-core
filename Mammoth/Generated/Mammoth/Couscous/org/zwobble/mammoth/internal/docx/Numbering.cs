using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Numbering {
        public static Numbering _EMPTY;
        private Map<string, Map<string, NumberingLevel>> _numbering;

        static Numbering()
        {
            _EMPTY = new Numbering(Maps.map<string, Map<string, NumberingLevel>>());
        }

        internal Numbering(Map<string, Map<string, NumberingLevel>> numbering)
        {
            _numbering = numbering;
        }

        public Optional<NumberingLevel> findLevel(string numId, string level)
        {
            return (Maps.lookup(_numbering, numId)).flatMap(new Numbering__Anonymous_0(level));
        }
    }
}
