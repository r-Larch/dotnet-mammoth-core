namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Text : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement {
        internal string _value;
        internal Text(string value) {
            this._value = value;
        }
        public string getValue() {
            return this._value;
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
    }
}

