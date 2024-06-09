using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal static class TokenIterator {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class TokenIterator<T> {
        internal Token<T> _end;
        internal int _index;
        internal List<Token<T>> _tokens;

        internal TokenIterator(List<Token<T>> tokens, Token<T> end)
        {
            _tokens = tokens;
            _end = end;
            _index = 0;
        }

        public bool isNext(int offset, T tokenType, string value)
        {
            var tokenIndex = _index + offset;
            var token = getToken(tokenIndex);
            return (token.getTokenType()).equals(tokenType) && ((token.getValue()).Equals(value));
        }

        public bool isNext(T tokenType, string value)
        {
            return isNext(0, tokenType, value);
        }

        public bool trySkip(T tokenType, string value)
        {
            if (isNext(tokenType, value)) {
                skip();
                return true;
            }

            return false;
        }

        public T peekTokenType()
        {
            return (getToken(_index)).getTokenType();
        }

        public Token<T> next()
        {
            var token = getToken(_index);
            _index = _index + 1;
            return token;
        }

        public Token<T> next(T type)
        {
            var token = getToken(_index);
            if ((token.getTokenType()).equals(type)) {
                _index = _index + 1;
                return token;
            }

            throw unexpectedTokenType(type, token);
        }

        public string nextValue(T type)
        {
            return (next(type)).getValue();
        }

        public void skip()
        {
            _index = _index + 1;
        }

        public void skip(T tokenType)
        {
            var token = getToken(_index);
            if (!(token.getTokenType()).equals(tokenType)) {
                throw unexpectedTokenType(tokenType, token);
            }

            _index = _index + 1;
        }

        public void skip(T tokenType, string tokenValue)
        {
            var token = getToken(_index);
            if (!(token.getTokenType()).equals(tokenType)) {
                throw unexpectedTokenType(tokenType, token);
            }

            var actualValue = token.getValue();
            if (!(actualValue.Equals(tokenValue))) {
                throw LineParseException.lineParseException(token, (((("expected " + tokenType) + " token with value ") + tokenValue) + " but value was ") + actualValue);
            }

            _index = _index + 1;
        }

        public LineParseException unexpectedTokenType(T expected, Token<T> actual)
        {
            return LineParseException.lineParseException(actual, (("expected token of type " + expected) + " but was of type ") + actual.getTokenType());
        }

        public bool tryParse(TokenIterator__Action action)
        {
            var originalIndex = _index;
            try {
                action.run();
                return true;
            }
            catch (LineParseException exception) {
                _index = originalIndex;
                return false;
            }
        }

        public Token<T> getToken(int index)
        {
            if (index < (_tokens).size()) {
                return (_tokens).get(index);
            }

            return _end;
        }
    }
}
