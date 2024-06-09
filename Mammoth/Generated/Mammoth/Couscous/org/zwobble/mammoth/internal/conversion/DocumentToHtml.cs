namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml {
        internal string _idPrefix;
        internal bool _preserveEmptyParagraphs;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap _styleMap;
        internal Mammoth.Couscous.org.zwobble.mammoth.images.ImageConverter__ImgElement _imageConverter;
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> _comments;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference> _noteReferences;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ReferencedComment> _referencedComments;
        internal Mammoth.Couscous.java.util.Set<string> _warnings;
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context _INITIAL_CONTEXT;
        static DocumentToHtml() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml._INITIAL_CONTEXT = new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context(false);
        }
        internal DocumentToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions options, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment> comments) {
            this._noteReferences = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference>();
            this._referencedComments = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ReferencedComment>();
            this._warnings = new Mammoth.Couscous.java.util.HashSet<string>();
            this._idPrefix = options.idPrefix();
            this._preserveEmptyParagraphs = options.shouldPreserveEmptyParagraphs();
            this._styleMap = options.styleMap();
            this._imageConverter = options.imageConverter();
            this._comments = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMapWithKey<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment, string>(comments, new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_0());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> convertToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document document, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions options) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml documentConverter = new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml(options, document.getComments());
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(documentConverter.convertToHtml(document, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml._INITIAL_CONTEXT), documentConverter._warnings);
        }
        public static Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> findNotes(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document document, Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference> noteReferences) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note>(noteReferences, new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_1(document));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> convertToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement element, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions options) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml documentConverter = new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml(options, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Comment>());
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(documentConverter.convertToHtml(element, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml._INITIAL_CONTEXT), documentConverter._warnings);
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> convertToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Document document, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> mainBody = this.convertChildrenToHtml(document, context);
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note> notes = Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml.findNotes(document, this._noteReferences);
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> noteNodes = notes.isEmpty() ? Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>() : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("ol", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(notes, new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_2(this, context))));
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> commentNodes = (this._referencedComments).isEmpty() ? Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>() : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("dl", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ReferencedComment, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(this._referencedComments, new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_3(this, context))));
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(mainBody, noteNodes, commentNodes);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode convertToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Note note, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            string id = this.generateNoteHtmlId(note.getNoteType(), note.getId());
            string referenceId = this.generateNoteRefHtmlId(note.getNoteType(), note.getId());
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> noteBody = this.convertToHtml(note.getBody(), context);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode backLink = Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsibleElement("p", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text(" "), Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("a", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("href", "#" + referenceId), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text("↑")))));
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("li", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("id", id), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(noteBody, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(backLink)));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> convertToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ReferencedComment referencedComment, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            string commentId = (referencedComment._comment).getCommentId();
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> body = this.convertToHtml((referencedComment._comment).getBody(), context);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode backLink = Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsibleElement("p", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text(" "), Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("a", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("href", "#" + this.generateReferenceHtmlId("comment", commentId)), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text("↑")))));
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("dt", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("id", this.generateReferentHtmlId("comment", commentId)), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text("Comment " + referencedComment._label))), Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("dd", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(body, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(backLink))));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> convertToHtml(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> elements, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(elements, new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_4(this, context));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> convertChildrenToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren element, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            return this.convertToHtml(element.getChildren(), context);
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> convertToHtml(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement element, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            return element.accept<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context>(this.create_ElementConverterVisitor(), context);
        }
        public string generateNoteHtmlId(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType noteType, string noteId) {
            return this.generateReferentHtmlId(this.noteTypeToIdFragment(noteType), noteId);
        }
        public string generateNoteRefHtmlId(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType noteType, string noteId) {
            return this.generateReferenceHtmlId(this.noteTypeToIdFragment(noteType), noteId);
        }
        public string generateReferentHtmlId(string referenceType, string referenceId) {
            return this.generateId((referenceType + "-") + referenceId);
        }
        public string generateReferenceHtmlId(string referenceType, string referenceId) {
            return this.generateId((referenceType + "-ref-") + referenceId);
        }
        public string noteTypeToIdFragment(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType noteType) {
            switch (noteType) {
                case Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType._FOOTNOTE:
                    return "footnote";
                case Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType._ENDNOTE:
                    return "endnote";
                default:
                    throw new Mammoth.Couscous.java.lang.UnsupportedOperationException();
            }
        }
        public string generateId(string bookmarkName) {
            return this._idPrefix + bookmarkName;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ElementConverterVisitor create_ElementConverterVisitor() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__ElementConverterVisitor(this);
        }
    }
}

