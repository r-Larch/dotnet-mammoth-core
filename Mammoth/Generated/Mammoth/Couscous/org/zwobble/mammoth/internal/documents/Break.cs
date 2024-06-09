namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Break(BreakType type) : IDocumentElement {
        public static Break LineBreak = new(BreakType.Line);
        public static Break PageBreak = new(BreakType.Page);
        public static Break ColumnBreak = new(BreakType.Column);
        public BreakType Type { get; } = type;

        public T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context)
        {
            return visitor.Visit(this, context);
        }
    }
}
