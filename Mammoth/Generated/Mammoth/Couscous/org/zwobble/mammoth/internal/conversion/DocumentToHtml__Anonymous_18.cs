namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_18 : Mammoth.Couscous.java.util.function.Consumer<string> {
        internal Mammoth.Couscous.java.util.Map<string, string> _attributes;
        internal DocumentToHtml__Anonymous_18(Mammoth.Couscous.java.util.Map<string, string> attributes) {
            this._attributes = attributes;
        }
        public void accept(string altText) {
            (this._attributes).put("alt", altText);
        }
    }
}

