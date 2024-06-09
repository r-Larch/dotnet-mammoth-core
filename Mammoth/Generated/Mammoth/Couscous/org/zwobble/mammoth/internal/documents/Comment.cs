using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Comment {
        private Optional<string> _authorInitials;
        private Optional<string> _authorName;
        private List<DocumentElement> _body;
        private string _commentId;

        internal Comment(string commentId, List<DocumentElement> body, Optional<string> authorName, Optional<string> authorInitials)
        {
            _commentId = commentId;
            _body = body;
            _authorName = authorName;
            _authorInitials = authorInitials;
        }

        public string getCommentId()
        {
            return _commentId;
        }

        public List<DocumentElement> getBody()
        {
            return _body;
        }

        public Optional<string> getAuthorInitials()
        {
            return _authorInitials;
        }

        public Optional<string> getAuthorName()
        {
            return _authorName;
        }
    }
}
