using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Comment {
        internal Optional<string> _authorInitials;
        internal Optional<string> _authorName;
        internal List<DocumentElement> _body;
        internal string _commentId;

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
