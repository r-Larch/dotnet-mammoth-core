namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Text : IDocumentElement {
        private string _value;

        internal Text(string value)
        {
            _value = value;
        }

        public T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context)
        {
            return visitor.Visit(this, context);
        }

        public string GetValue()
        {
            return _value;
        }
    }
}
