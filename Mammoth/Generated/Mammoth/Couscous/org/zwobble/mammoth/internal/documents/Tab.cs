namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Tab : DocumentElement {
        public static Tab _TAB;

        static Tab()
        {
            _TAB = new Tab();
        }

        public T accept<T, U>(DocumentElementVisitor<T, U> visitor, U context)
        {
            return visitor.visit(this, context);
        }
    }
}
