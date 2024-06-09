namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class CommentReference : DocumentElement {
        internal string _commentId;

        internal CommentReference(string commentId)
        {
            _commentId = commentId;
        }

        public T accept<T, U>(DocumentElementVisitor<T, U> visitor, U context)
        {
            return visitor.visit(this, context);
        }

        public string getCommentId()
        {
            return _commentId;
        }
    }
}
