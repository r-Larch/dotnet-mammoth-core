using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.images;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml {
        private static DocumentToHtml__Context _INITIAL_CONTEXT;
        public Map<string, Comment> _comments;
        private string _idPrefix;
        public ImageConverter__ImgElement _imageConverter;
        public List<NoteReference> _noteReferences;
        public bool _preserveEmptyParagraphs;
        public List<DocumentToHtml__ReferencedComment> _referencedComments;
        public StyleMap _styleMap;
        public Set<string> _warnings;

        static DocumentToHtml()
        {
            _INITIAL_CONTEXT = new DocumentToHtml__Context(false);
        }

        internal DocumentToHtml(DocumentToHtmlOptions options, List<Comment> comments)
        {
            _noteReferences = new ArrayList<NoteReference>();
            _referencedComments = new ArrayList<DocumentToHtml__ReferencedComment>();
            _warnings = new HashSet<string>();
            _idPrefix = options.idPrefix();
            _preserveEmptyParagraphs = options.shouldPreserveEmptyParagraphs();
            _styleMap = options.styleMap();
            _imageConverter = options.imageConverter();
            _comments = Maps.toMapWithKey(comments, new DocumentToHtml__Anonymous_0());
        }

        public static InternalResult<List<HtmlNode>> convertToHtml(Document document, DocumentToHtmlOptions options)
        {
            var documentConverter = new DocumentToHtml(options, document.getComments());
            return new InternalResult<List<HtmlNode>>(documentConverter.convertToHtml(document, _INITIAL_CONTEXT), documentConverter._warnings);
        }

        public static List<Note> findNotes(Document document, Iterable<NoteReference> noteReferences)
        {
            return Lists.eagerMap(noteReferences, new DocumentToHtml__Anonymous_1(document));
        }

        public static InternalResult<List<HtmlNode>> convertToHtml(DocumentElement element, DocumentToHtmlOptions options)
        {
            var documentConverter = new DocumentToHtml(options, Lists.list<Comment>());
            return new InternalResult<List<HtmlNode>>(documentConverter.convertToHtml(element, _INITIAL_CONTEXT), documentConverter._warnings);
        }

        public List<HtmlNode> convertToHtml(Document document, DocumentToHtml__Context context)
        {
            var mainBody = convertChildrenToHtml(document, context);
            var notes = findNotes(document, _noteReferences);
            var noteNodes = notes.isEmpty() ? Lists.list<HtmlNode>() : Lists.list(Html.element("ol", Lists.eagerMap(notes, new DocumentToHtml__Anonymous_2(this, context))));
            var commentNodes = (_referencedComments).isEmpty() ? Lists.list<HtmlNode>() : Lists.list(Html.element("dl", Lists.eagerFlatMap(_referencedComments, new DocumentToHtml__Anonymous_3(this, context))));
            return Lists.eagerConcat(mainBody, noteNodes, commentNodes);
        }

        public HtmlNode convertToHtml(Note note, DocumentToHtml__Context context)
        {
            var id = generateNoteHtmlId(note.getNoteType(), note.getId());
            var referenceId = generateNoteRefHtmlId(note.getNoteType(), note.getId());
            var noteBody = convertToHtml(note.getBody(), context);
            var backLink = Html.collapsibleElement("p", Lists.list(Html.text(" "), Html.element("a", Maps.map("href", "#" + referenceId), Lists.list(Html.text("↑")))));
            return Html.element("li", Maps.map("id", id), Lists.eagerConcat(noteBody, Lists.list(backLink)));
        }

        public List<HtmlNode> convertToHtml(DocumentToHtml__ReferencedComment referencedComment, DocumentToHtml__Context context)
        {
            var commentId = (referencedComment._comment).getCommentId();
            var body = convertToHtml((referencedComment._comment).getBody(), context);
            var backLink = Html.collapsibleElement("p", Lists.list(Html.text(" "), Html.element("a", Maps.map("href", "#" + generateReferenceHtmlId("comment", commentId)), Lists.list(Html.text("↑")))));
            return Lists.list(Html.element("dt", Maps.map("id", generateReferentHtmlId("comment", commentId)), Lists.list(Html.text("Comment " + referencedComment._label))), Html.element("dd", Lists.eagerConcat(body, Lists.list(backLink))));
        }

        public List<HtmlNode> convertToHtml(List<DocumentElement> elements, DocumentToHtml__Context context)
        {
            return Lists.eagerFlatMap(elements, new DocumentToHtml__Anonymous_4(this, context));
        }

        public List<HtmlNode> convertChildrenToHtml(HasChildren element, DocumentToHtml__Context context)
        {
            return convertToHtml(element.getChildren(), context);
        }

        public List<HtmlNode> convertToHtml(DocumentElement element, DocumentToHtml__Context context)
        {
            return element.accept(create_ElementConverterVisitor(), context);
        }

        public string generateNoteHtmlId(NoteType noteType, string noteId)
        {
            return generateReferentHtmlId(noteTypeToIdFragment(noteType), noteId);
        }

        public string generateNoteRefHtmlId(NoteType noteType, string noteId)
        {
            return generateReferenceHtmlId(noteTypeToIdFragment(noteType), noteId);
        }

        public string generateReferentHtmlId(string referenceType, string referenceId)
        {
            return generateId((referenceType + "-") + referenceId);
        }

        public string generateReferenceHtmlId(string referenceType, string referenceId)
        {
            return generateId((referenceType + "-ref-") + referenceId);
        }

        public string noteTypeToIdFragment(NoteType noteType)
        {
            switch (noteType) {
                case NoteType._FOOTNOTE:
                    return "footnote";
                case NoteType._ENDNOTE:
                    return "endnote";
                default:
                    throw new UnsupportedOperationException();
            }
        }

        public string generateId(string bookmarkName)
        {
            return _idPrefix + bookmarkName;
        }

        public DocumentToHtml__ElementConverterVisitor create_ElementConverterVisitor()
        {
            return new DocumentToHtml__ElementConverterVisitor(this);
        }
    }
}
