using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal static class TokenIterator {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing {
    internal class TokenIterator<T> {
        private Token<T> _end;
        private int _index;
        private IList<Token<T>> _tokens;

        internal TokenIterator(IList<Token<T>> tokens, Token<T> end)
        {
            _tokens = tokens;
            _end = end;
            _index = 0;
        }

        public bool IsNext(int offset, T tokenType, string value)
        {
            var tokenIndex = _index + offset;
            var token = GetToken(tokenIndex);
            return (token.GetTokenType()).Equals(tokenType) && ((token.GetValue()).Equals(value));
        }

        public bool IsNext(T tokenType, string value)
        {
            return IsNext(0, tokenType, value);
        }

        public bool TrySkip(T tokenType, string value)
        {
            if (IsNext(tokenType, value)) {
                Skip();
                return true;
            }

            return false;
        }

        public T PeekTokenType()
        {
            return (GetToken(_index)).GetTokenType();
        }

        public Token<T> Next()
        {
            var token = GetToken(_index);
            _index = _index + 1;
            return token;
        }

        public Token<T> Next(T type)
        {
            var token = GetToken(_index);
            if ((token.GetTokenType()).Equals(type)) {
                _index = _index + 1;
                return token;
            }

            throw UnexpectedTokenType(type, token);
        }

        public string NextValue(T type)
        {
            return (Next(type)).GetValue();
        }

        public void Skip()
        {
            _index = _index + 1;
        }

        public void Skip(T tokenType)
        {
            var token = GetToken(_index);
            if (!(token.GetTokenType()).Equals(tokenType)) {
                throw UnexpectedTokenType(tokenType, token);
            }

            _index = _index + 1;
        }

        public void Skip(T tokenType, string tokenValue)
        {
            var token = GetToken(_index);
            if (!(token.GetTokenType()).Equals(tokenType)) {
                throw UnexpectedTokenType(tokenType, token);
            }

            var actualValue = token.GetValue();
            if (!(actualValue.Equals(tokenValue))) {
                throw LineParseException.Create(token, (((("expected " + tokenType) + " token with value ") + tokenValue) + " but value was ") + actualValue);
            }

            _index = _index + 1;
        }

        public LineParseException UnexpectedTokenType(T expected, Token<T> actual)
        {
            return LineParseException.Create(actual, (("expected token of type " + expected) + " but was of type ") + actual.GetTokenType());
        }

        public bool TryParse(ITokenIteratorAction action)
        {
            var originalIndex = _index;
            try {
                action.Run();
                return true;
            }
            catch (LineParseException exception) {
                _index = originalIndex;
                return false;
            }
        }

        public Token<T> GetToken(int index)
        {
            if (index < (_tokens).Size()) {
                return (_tokens).Get(index);
            }

            return _end;
        }
    }
}
