namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class CommentReference : IDocumentElement {
        private string _commentId;

        internal CommentReference(string commentId)
        {
            _commentId = commentId;
        }

        public T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context)
        {
            return visitor.Visit(this, context);
        }

        public string GetCommentId()
        {
            return _commentId;
        }
    }
}
