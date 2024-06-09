namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal static class TokenIterator {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class TokenIterator<T> {
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T>> _tokens;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> _end;
        internal int _index;
        internal TokenIterator(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T>> tokens, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> end) {
            this._tokens = tokens;
            this._end = end;
            this._index = 0;
        }
        public bool isNext(int offset, T tokenType, string value) {
            int tokenIndex = this._index + offset;
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> token = this.getToken(tokenIndex);
            return (token.getTokenType()).equals(tokenType) && ((token.getValue()).Equals(value));
        }
        public bool isNext(T tokenType, string value) {
            return this.isNext(0, tokenType, value);
        }
        public bool trySkip(T tokenType, string value) {
            if (this.isNext(tokenType, value)) {
                this.skip();
                return true;
            } else {
                return false;
            }
        }
        public T peekTokenType() {
            return (this.getToken(this._index)).getTokenType();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> next() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> token = this.getToken(this._index);
            this._index = this._index + 1;
            return token;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> next(T type) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> token = this.getToken(this._index);
            if ((token.getTokenType()).equals(type)) {
                this._index = this._index + 1;
                return token;
            } else {
                throw this.unexpectedTokenType(type, token);
            }
        }
        public string nextValue(T type) {
            return (this.next(type)).getValue();
        }
        public void skip() {
            this._index = this._index + 1;
        }
        public void skip(T tokenType) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> token = this.getToken(this._index);
            if (!(token.getTokenType()).equals(tokenType)) {
                throw this.unexpectedTokenType(tokenType, token);
            }
            this._index = this._index + 1;
        }
        public void skip(T tokenType, string tokenValue) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> token = this.getToken(this._index);
            if (!(token.getTokenType()).equals(tokenType)) {
                throw this.unexpectedTokenType(tokenType, token);
            }
            string actualValue = token.getValue();
            if (!(actualValue.Equals(tokenValue))) {
                throw Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.LineParseException.lineParseException<T>(token, (((("expected " + tokenType) + " token with value ") + tokenValue) + " but value was ") + actualValue);
            }
            this._index = this._index + 1;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.LineParseException unexpectedTokenType(T expected, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> actual) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.LineParseException.lineParseException<T>(actual, (("expected token of type " + expected) + " but was of type ") + actual.getTokenType());
        }
        public bool tryParse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.TokenIterator__Action action) {
            int originalIndex = this._index;
            try {
                action.run();
                return true;
            } catch (Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.LineParseException exception) {
                this._index = originalIndex;
                return false;
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.Token<T> getToken(int index) {
            if (index < (this._tokens).size()) {
                return (this._tokens).get(index);
            } else {
                return this._end;
            }
        }
    }
}

