using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlReferencedComment {
        public Comment Comment;
        public string Label;

        internal DocumentToHtmlReferencedComment(string label, Comment comment)
        {
            Label = label;
            Comment = comment;
        }
    }
}
