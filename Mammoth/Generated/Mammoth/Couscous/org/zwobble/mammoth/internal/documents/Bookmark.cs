namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Bookmark(string name) : IDocumentElement {
        public T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context)
        {
            return visitor.Visit(this, context);
        }

        public string GetName()
        {
            return name;
        }
    }
}
