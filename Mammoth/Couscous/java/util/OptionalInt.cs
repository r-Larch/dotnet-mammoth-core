namespace Mammoth.Couscous.java.util {
    internal interface IOptionalInt {
        bool IsPresent();
        int GetAsInt();
        int OrElse(int elseValue);
    }

    internal struct NoneInt : IOptionalInt {
        public static readonly NoneInt Instance = new();

        public bool IsPresent()
        {
            return false;
        }

        public int GetAsInt()
        {
            throw new NoSuchElementException();
        }

        public int OrElse(int elseValue)
        {
            return elseValue;
        }
    }

    internal struct SomeInt : IOptionalInt {
        private readonly int _value;

        internal SomeInt(int value)
        {
            _value = value;
        }

        public bool IsPresent()
        {
            return true;
        }

        public int GetAsInt()
        {
            return _value;
        }

        public int OrElse(int elseValue)
        {
            return _value;
        }
    }
}
