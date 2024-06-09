using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_16 : Supplier<List<HtmlNode>> {
        internal CommentReference _commentReference;
        internal DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;

        internal DocumentToHtml__Anonymous_16(CommentReference commentReference, DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)
        {
            _commentReference = commentReference;
            _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        }

        public List<HtmlNode> get()
        {
            var commentId = (_commentReference).getCommentId();
            var comment = (Maps.lookup((_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._comments, commentId)).orElseThrow(new DocumentToHtml__Anonymous_15(commentId));
            var label = (("[" + (comment.getAuthorInitials()).orElse("")) + (((_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._referencedComments).size() + 1)) + "]";
            ((_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._referencedComments).add(new DocumentToHtml__ReferencedComment(label, comment));
            return Lists.list(Html.element("a", Maps.map("href", "#" + (_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).generateReferentHtmlId("comment", commentId), "id", (_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).generateReferenceHtmlId("comment", commentId)), Lists.list(Html.text(label))));
        }
    }
}
