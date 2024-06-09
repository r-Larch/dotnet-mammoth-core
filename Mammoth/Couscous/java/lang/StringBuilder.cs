namespace Mammoth.Couscous.java.lang {
    internal class StringBuilder {
        private readonly System.Text.StringBuilder _builder = new();

        internal StringBuilder append(string value)
        {
            _builder.Append(value);
            return this;
        }

        internal StringBuilder append(char value)
        {
            _builder.Append(value);
            return this;
        }

        internal string toString()
        {
            return _builder.ToString();
        }

        internal void setLength(int length)
        {
            _builder.Length = length;
        }
    }
}
