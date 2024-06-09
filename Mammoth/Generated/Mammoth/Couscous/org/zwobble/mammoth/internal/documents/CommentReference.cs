namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class CommentReference(string commentId) : IDocumentElement {
        public T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context)
        {
            return visitor.Visit(this, context);
        }

        public string GetCommentId()
        {
            return commentId;
        }
    }
}
