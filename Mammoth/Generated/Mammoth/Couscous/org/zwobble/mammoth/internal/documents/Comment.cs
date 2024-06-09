namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Comment {
        internal string _commentId;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _body;
        internal Mammoth.Couscous.java.util.Optional<string> _authorName;
        internal Mammoth.Couscous.java.util.Optional<string> _authorInitials;
        internal Comment(string commentId, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> body, Mammoth.Couscous.java.util.Optional<string> authorName, Mammoth.Couscous.java.util.Optional<string> authorInitials) {
            this._commentId = commentId;
            this._body = body;
            this._authorName = authorName;
            this._authorInitials = authorInitials;
        }
        public string getCommentId() {
            return this._commentId;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> getBody() {
            return this._body;
        }
        public Mammoth.Couscous.java.util.Optional<string> getAuthorInitials() {
            return this._authorInitials;
        }
        public Mammoth.Couscous.java.util.Optional<string> getAuthorName() {
            return this._authorName;
        }
    }
}

