namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Bookmark : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement {
        internal string _name;
        internal Bookmark(string name) {
            this._name = name;
        }
        public string getName() {
            return this._name;
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
    }
}

