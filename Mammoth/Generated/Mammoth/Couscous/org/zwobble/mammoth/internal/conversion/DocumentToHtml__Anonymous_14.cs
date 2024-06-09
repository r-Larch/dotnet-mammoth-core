using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_14 : Consumer<string> {
        internal Map<string, string> _attributes;

        internal DocumentToHtml__Anonymous_14(Map<string, string> attributes)
        {
            _attributes = attributes;
        }

        public void accept(string targetFrame)
        {
            (_attributes).put("target", targetFrame);
        }
    }
}
