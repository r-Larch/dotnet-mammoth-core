using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlAnonymous16 : ISupplier<IList<IHtmlNode>> {
        private CommentReference _commentReference;
        private DocumentToHtml _thisOrgZwobbleMammothInternalConversionDocumentToHtml;

        internal DocumentToHtmlAnonymous16(CommentReference commentReference, DocumentToHtml thisOrgZwobbleMammothInternalConversionDocumentToHtml)
        {
            _commentReference = commentReference;
            _thisOrgZwobbleMammothInternalConversionDocumentToHtml = thisOrgZwobbleMammothInternalConversionDocumentToHtml;
        }

        public IList<IHtmlNode> Get()
        {
            var commentId = (_commentReference).GetCommentId();
            var comment = (Maps.Lookup((_thisOrgZwobbleMammothInternalConversionDocumentToHtml).Comments, commentId)).OrElseThrow(new DocumentToHtmlAnonymous15(commentId));
            var label = (("[" + (comment.GetAuthorInitials()).OrElse("")) + (((_thisOrgZwobbleMammothInternalConversionDocumentToHtml).ReferencedComments).Size() + 1)) + "]";
            ((_thisOrgZwobbleMammothInternalConversionDocumentToHtml).ReferencedComments).Add(new DocumentToHtmlReferencedComment(label, comment));
            return Lists.List(Html.Element("a", Maps.Map("href", "#" + (_thisOrgZwobbleMammothInternalConversionDocumentToHtml).GenerateReferentHtmlId("comment", commentId), "id", (_thisOrgZwobbleMammothInternalConversionDocumentToHtml).GenerateReferenceHtmlId("comment", commentId)), Lists.List(Html.Text(label))));
        }
    }
}
