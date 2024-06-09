namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class HtmlPathParser__Anonymous_1 : Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator__Action {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> _tokens;
        internal HtmlPathParser__Anonymous_1(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType> tokens) {
            this._tokens = tokens;
        }
        public void run() {
            (this._tokens).skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._SYMBOL, ":");
            (this._tokens).skip(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenType._IDENTIFIER, "separator");
        }
    }
}

