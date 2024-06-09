using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Document : HasChildren {
        private List<DocumentElement> _children;
        private List<Comment> _comments;
        private Notes _notes;

        internal Document(List<DocumentElement> children, Notes notes, List<Comment> comments)
        {
            _children = children;
            _notes = notes;
            _comments = comments;
        }

        public List<DocumentElement> getChildren()
        {
            return _children;
        }

        public Notes getNotes()
        {
            return _notes;
        }

        public List<Comment> getComments()
        {
            return _comments;
        }
    }
}
