namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Break : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break _LINE_BREAK;
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break _PAGE_BREAK;
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break _COLUMN_BREAK;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break__Type _type;
        static Break() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break._LINE_BREAK = new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break__Type._LINE);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break._PAGE_BREAK = new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break__Type._PAGE);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break._COLUMN_BREAK = new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break__Type._COLUMN);
        }
        internal Break(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break__Type type) {
            this._type = type;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break__Type getType() {
            return this._type;
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
    }
}

