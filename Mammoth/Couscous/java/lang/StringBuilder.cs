namespace Mammoth.Couscous.java.lang {
    internal class StringBuilder {
        private readonly System.Text.StringBuilder _builder = new();

        internal StringBuilder Append(string value)
        {
            _builder.Append(value);
            return this;
        }

        internal StringBuilder Append(char value)
        {
            _builder.Append(value);
            return this;
        }

        public override string ToString()
        {
            return _builder.ToString();
        }

        internal void SetLength(int length)
        {
            _builder.Length = length;
        }
    }
}
