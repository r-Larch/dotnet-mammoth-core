namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_16 : Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.CommentReference _commentReference;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal DocumentToHtml__Anonymous_16(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.CommentReference commentReference, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml) {
            this._commentReference = commentReference;
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> get() {
            string commentId = (this._commentReference).getCommentId();
            Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment comment = (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._comments, commentId)).orElseThrow<Mammoth.Couscous.java.lang.RuntimeException>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_15(commentId));
            string label = (("[" + (comment.getAuthorInitials()).orElse("")) + (((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._referencedComments).size() + 1)) + "]";
            ((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._referencedComments).add(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ReferencedComment(label, comment));
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("a", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("href", "#" + (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).generateReferentHtmlId("comment", commentId), "id", (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).generateReferenceHtmlId("comment", commentId)), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text(label))));
        }
    }
}

