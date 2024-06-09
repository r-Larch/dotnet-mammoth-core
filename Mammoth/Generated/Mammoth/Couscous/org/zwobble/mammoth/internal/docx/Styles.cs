using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Styles(IMap<string, Style> paragraphStyles, IMap<string, Style> characterStyles, IMap<string, Style> tableStyles) {
        public static Styles Empty = new(Maps.Map<string, Style>(), Maps.Map<string, Style>(), Maps.Map<string, Style>());

        public IOptional<Style> FindParagraphStyleById(string id)
        {
            return Maps.Lookup(paragraphStyles, id);
        }

        public IOptional<Style> FindCharacterStyleById(string id)
        {
            return Maps.Lookup(characterStyles, id);
        }

        public IOptional<Style> FindTableStyleById(string id)
        {
            return Maps.Lookup(tableStyles, id);
        }
    }
}
