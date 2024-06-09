using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Document : IHasChildren {
        private IList<IDocumentElement> _children;
        private IList<Comment> _comments;
        private Notes _notes;

        internal Document(IList<IDocumentElement> children, Notes notes, IList<Comment> comments)
        {
            _children = children;
            _notes = notes;
            _comments = comments;
        }

        public IList<IDocumentElement> GetChildren()
        {
            return _children;
        }

        public Notes GetNotes()
        {
            return _notes;
        }

        public IList<Comment> GetComments()
        {
            return _comments;
        }
    }
}
