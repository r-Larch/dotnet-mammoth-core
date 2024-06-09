namespace Mammoth.Couscous.java.math {
    internal class BigInteger {
        public static readonly BigInteger One = new(1);

        // TOOD: use proper BigInteger
        private readonly long _value;

        internal BigInteger(string value)
        {
            _value = long.Parse(value);
        }

        internal BigInteger(long value)
        {
            _value = value;
        }

        internal BigInteger Subtract(BigInteger other)
        {
            return new BigInteger(_value - other._value);
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}
