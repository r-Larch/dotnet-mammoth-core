using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Table : IDocumentElement, IHasChildren {
        private IList<IDocumentElement> _children;
        private IOptional<Style> _style;

        internal Table(IOptional<Style> style, IList<IDocumentElement> children)
        {
            _style = style;
            _children = children;
        }

        public T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context)
        {
            return visitor.Visit(this, context);
        }

        public IList<IDocumentElement> GetChildren()
        {
            return _children;
        }

        public IOptional<Style> GetStyle()
        {
            return _style;
        }
    }
}
