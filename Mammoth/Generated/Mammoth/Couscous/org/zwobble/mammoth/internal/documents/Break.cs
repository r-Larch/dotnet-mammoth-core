namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Break : DocumentElement {
        internal static Break _LINE_BREAK;
        internal static Break _PAGE_BREAK;
        internal static Break _COLUMN_BREAK;
        internal Break__Type _type;

        static Break()
        {
            _LINE_BREAK = new Break(Break__Type._LINE);
            _PAGE_BREAK = new Break(Break__Type._PAGE);
            _COLUMN_BREAK = new Break(Break__Type._COLUMN);
        }

        internal Break(Break__Type type)
        {
            _type = type;
        }

        public T accept<T, U>(DocumentElementVisitor<T, U> visitor, U context)
        {
            return visitor.visit(this, context);
        }

        public Break__Type getType()
        {
            return _type;
        }
    }
}
