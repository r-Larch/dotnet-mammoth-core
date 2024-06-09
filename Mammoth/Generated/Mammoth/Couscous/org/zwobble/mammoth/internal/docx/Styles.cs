using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Styles {
        public static Styles Empty;
        private IMap<string, Style> _characterStyles;
        private IMap<string, Style> _paragraphStyles;
        private IMap<string, Style> _tableStyles;

        static Styles()
        {
            Empty = new Styles(Maps.Map<string, Style>(), Maps.Map<string, Style>(), Maps.Map<string, Style>());
        }

        internal Styles(IMap<string, Style> paragraphStyles, IMap<string, Style> characterStyles, IMap<string, Style> tableStyles)
        {
            _paragraphStyles = paragraphStyles;
            _characterStyles = characterStyles;
            _tableStyles = tableStyles;
        }

        public IOptional<Style> FindParagraphStyleById(string id)
        {
            return Maps.Lookup(_paragraphStyles, id);
        }

        public IOptional<Style> FindCharacterStyleById(string id)
        {
            return Maps.Lookup(_characterStyles, id);
        }

        public IOptional<Style> FindTableStyleById(string id)
        {
            return Maps.Lookup(_tableStyles, id);
        }
    }
}
