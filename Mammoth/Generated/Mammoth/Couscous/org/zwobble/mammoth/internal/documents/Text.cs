namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Text(string value) : IDocumentElement {
        public T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context)
        {
            return visitor.Visit(this, context);
        }

        public string GetValue()
        {
            return value;
        }
    }
}
