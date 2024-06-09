namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Bookmark : DocumentElement {
        internal string _name;

        internal Bookmark(string name)
        {
            _name = name;
        }

        public T accept<T, U>(DocumentElementVisitor<T, U> visitor, U context)
        {
            return visitor.visit(this, context);
        }

        public string getName()
        {
            return _name;
        }
    }
}
