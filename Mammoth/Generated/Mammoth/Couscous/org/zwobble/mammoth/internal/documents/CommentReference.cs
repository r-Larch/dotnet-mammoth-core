namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class CommentReference : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement {
        internal string _commentId;
        internal CommentReference(string commentId) {
            this._commentId = commentId;
        }
        public string getCommentId() {
            return this._commentId;
        }
        public T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context) {
            return visitor.visit(this, context);
        }
    }
}

