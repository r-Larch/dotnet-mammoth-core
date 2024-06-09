namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Tab : IDocumentElement {
        public static Tab Instance;

        static Tab()
        {
            Instance = new Tab();
        }

        public T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context)
        {
            return visitor.Visit(this, context);
        }
    }
}
