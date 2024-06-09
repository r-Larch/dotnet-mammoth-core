using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_18 : Consumer<string> {
        private Map<string, string> _attributes;

        internal DocumentToHtml__Anonymous_18(Map<string, string> attributes)
        {
            _attributes = attributes;
        }

        public void accept(string altText)
        {
            (_attributes).put("alt", altText);
        }
    }
}
