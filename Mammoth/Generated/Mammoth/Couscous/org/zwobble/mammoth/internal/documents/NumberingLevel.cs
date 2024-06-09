namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class NumberingLevel {
        internal string _levelIndex;
        internal bool _isOrdered;
        internal NumberingLevel(string levelIndex, bool isOrdered) {
            this._levelIndex = levelIndex;
            this._isOrdered = isOrdered;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel ordered(string levelIndex) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel(levelIndex, true);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel unordered(string levelIndex) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel(levelIndex, false);
        }
        public string getLevelIndex() {
            return this._levelIndex;
        }
        public bool isOrdered() {
            return this._isOrdered;
        }
    }
}

