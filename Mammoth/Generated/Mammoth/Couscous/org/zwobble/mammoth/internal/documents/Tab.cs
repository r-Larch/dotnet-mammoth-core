namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Tab : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Tab _TAB;
        static Tab() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Tab._TAB = new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Tab();
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
    }
}

