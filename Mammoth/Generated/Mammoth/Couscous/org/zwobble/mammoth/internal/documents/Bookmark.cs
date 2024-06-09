namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Bookmark : IDocumentElement {
        private string _name;

        internal Bookmark(string name)
        {
            _name = name;
        }

        public T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context)
        {
            return visitor.Visit(this, context);
        }

        public string GetName()
        {
            return _name;
        }
    }
}
