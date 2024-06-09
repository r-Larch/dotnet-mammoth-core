namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Text : DocumentElement {
        private string _value;

        internal Text(string value)
        {
            _value = value;
        }

        public T accept<T, U>(DocumentElementVisitor<T, U> visitor, U context)
        {
            return visitor.visit(this, context);
        }

        public string getValue()
        {
            return _value;
        }
    }
}
