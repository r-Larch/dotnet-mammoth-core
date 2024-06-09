namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class NumberingLevel(string levelIndex, bool isOrdered) {
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
            return levelIndex;
        }

        public bool IsOrdered()
        {
            return isOrdered;
        }
    }
}
