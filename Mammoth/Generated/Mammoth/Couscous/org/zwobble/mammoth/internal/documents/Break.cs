namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Break : IDocumentElement {
        public static Break LineBreak;
        public static Break PageBreak;
        public static Break ColumnBreak;
        public BreakType Type { get; }

        static Break()
        {
            LineBreak = new Break(BreakType.Line);
            PageBreak = new Break(BreakType.Page);
            ColumnBreak = new Break(BreakType.Column);
        }

        internal Break(BreakType type)
        {
            Type = type;
        }

        public T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context)
        {
            return visitor.Visit(this, context);
        }
    }
}
