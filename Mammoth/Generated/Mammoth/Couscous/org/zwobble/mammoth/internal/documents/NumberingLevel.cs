namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class NumberingLevel {
        internal bool _isOrdered;
        internal string _levelIndex;

        internal NumberingLevel(string levelIndex, bool isOrdered)
        {
            _levelIndex = levelIndex;
            _isOrdered = isOrdered;
        }

        public static NumberingLevel ordered(string levelIndex)
        {
            return new NumberingLevel(levelIndex, true);
        }

        public static NumberingLevel unordered(string levelIndex)
        {
            return new NumberingLevel(levelIndex, false);
        }

        public string getLevelIndex()
        {
            return _levelIndex;
        }

        public bool isOrdered()
        {
            return _isOrdered;
        }
    }
}
