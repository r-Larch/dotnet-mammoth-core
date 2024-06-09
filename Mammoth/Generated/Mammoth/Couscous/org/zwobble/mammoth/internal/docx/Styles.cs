using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Styles {
        internal static Styles _EMPTY;
        internal Map<string, Style> _characterStyles;
        internal Map<string, Style> _paragraphStyles;
        internal Map<string, Style> _tableStyles;

        static Styles()
        {
            _EMPTY = new Styles(Maps.map<string, Style>(), Maps.map<string, Style>(), Maps.map<string, Style>());
        }

        internal Styles(Map<string, Style> paragraphStyles, Map<string, Style> characterStyles, Map<string, Style> tableStyles)
        {
            _paragraphStyles = paragraphStyles;
            _characterStyles = characterStyles;
            _tableStyles = tableStyles;
        }

        public Optional<Style> findParagraphStyleById(string id)
        {
            return Maps.lookup(_paragraphStyles, id);
        }

        public Optional<Style> findCharacterStyleById(string id)
        {
            return Maps.lookup(_characterStyles, id);
        }

        public Optional<Style> findTableStyleById(string id)
        {
            return Maps.lookup(_tableStyles, id);
        }
    }
}
