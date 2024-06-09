namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Document : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren {
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _children;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes _notes;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> _comments;
        internal Document(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes notes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> comments) {
            this._children = children;
            this._notes = notes;
            this._comments = comments;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getChildren() {
            return this._children;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Notes getNotes() {
            return this._notes;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> getComments() {
            return this._comments;
        }
    }
}

