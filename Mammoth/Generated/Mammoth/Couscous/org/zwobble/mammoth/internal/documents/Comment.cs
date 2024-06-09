using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Comment {
        private IOptional<string> _authorInitials;
        private IOptional<string> _authorName;
        private IList<IDocumentElement> _body;
        private string _commentId;

        internal Comment(string commentId, IList<IDocumentElement> body, IOptional<string> authorName, IOptional<string> authorInitials)
        {
            _commentId = commentId;
            _body = body;
            _authorName = authorName;
            _authorInitials = authorInitials;
        }

        public string GetCommentId()
        {
            return _commentId;
        }

        public IList<IDocumentElement> GetBody()
        {
            return _body;
        }

        public IOptional<string> GetAuthorInitials()
        {
            return _authorInitials;
        }

        public IOptional<string> GetAuthorName()
        {
            return _authorName;
        }
    }
}
