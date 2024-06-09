using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Comment(string commentId, IList<IDocumentElement> body, IOptional<string> authorName, IOptional<string> authorInitials) {
        public string GetCommentId()
        {
            return commentId;
        }

        public IList<IDocumentElement> GetBody()
        {
            return body;
        }

        public IOptional<string> GetAuthorInitials()
        {
            return authorInitials;
        }

        public IOptional<string> GetAuthorName()
        {
            return authorName;
        }
    }
}
