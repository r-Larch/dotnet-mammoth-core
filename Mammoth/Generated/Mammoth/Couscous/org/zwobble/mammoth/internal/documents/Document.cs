using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Document(IList<IDocumentElement> children, Notes notes, IList<Comment> comments) : IHasChildren {
        public IList<IDocumentElement> GetChildren()
        {
            return children;
        }

        public Notes GetNotes()
        {
            return notes;
        }

        public IList<Comment> GetComments()
        {
            return comments;
        }
    }
}
