namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class NumberingLevel {
        private bool _isOrdered;
        private string _levelIndex;

        internal NumberingLevel(string levelIndex, bool isOrdered)
        {
            _levelIndex = levelIndex;
            _isOrdered = isOrdered;
        }

        public static NumberingLevel Ordered(string levelIndex)
        {
            return new NumberingLevel(levelIndex, true);
        }

        public static NumberingLevel Unordered(string levelIndex)
        {
            return new NumberingLevel(levelIndex, false);
        }

        public string GetLevelIndex()
        {
            return _levelIndex;
        }

        public bool IsOrdered()
        {
            return _isOrdered;
        }
    }
}
