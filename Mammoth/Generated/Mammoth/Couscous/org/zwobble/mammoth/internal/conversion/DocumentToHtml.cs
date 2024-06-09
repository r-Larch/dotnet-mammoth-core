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
        private static DocumentToHtmlContext _initialContext;
        public IMap<string, Comment> Comments;
        private string _idPrefix;
        public IMageConverterImgElement ImageConverter;
        public IList<NoteReference> NoteReferences;
        public bool PreserveEmptyParagraphs;
        public IList<DocumentToHtmlReferencedComment> ReferencedComments;
        public StyleMap StyleMap;
        public ISet<string> Warnings;

        static DocumentToHtml()
        {
            _initialContext = new DocumentToHtmlContext(false);
        }

        internal DocumentToHtml(DocumentToHtmlOptions options, IList<Comment> comments)
        {
            NoteReferences = new ArrayList<NoteReference>();
            ReferencedComments = new ArrayList<DocumentToHtmlReferencedComment>();
            Warnings = new HashSet<string>();
            _idPrefix = options.IdPrefix();
            PreserveEmptyParagraphs = options.ShouldPreserveEmptyParagraphs();
            StyleMap = options.StyleMap();
            ImageConverter = options.ImageConverter();
            Comments = Maps.ToMapWithKey(comments, new DocumentToHtmlAnonymous0());
        }

        public static InternalResult<IList<IHtmlNode>> ConvertToHtml(Document document, DocumentToHtmlOptions options)
        {
            var documentConverter = new DocumentToHtml(options, document.GetComments());
            return new InternalResult<IList<IHtmlNode>>(documentConverter.ConvertToHtml(document, _initialContext), documentConverter.Warnings);
        }

        public static IList<Note> FindNotes(Document document, ITerable<NoteReference> noteReferences)
        {
            return Lists.EagerMap(noteReferences, new DocumentToHtmlAnonymous1(document));
        }

        public static InternalResult<IList<IHtmlNode>> ConvertToHtml(IDocumentElement element, DocumentToHtmlOptions options)
        {
            var documentConverter = new DocumentToHtml(options, Lists.List<Comment>());
            return new InternalResult<IList<IHtmlNode>>(documentConverter.ConvertToHtml(element, _initialContext), documentConverter.Warnings);
        }

        public IList<IHtmlNode> ConvertToHtml(Document document, DocumentToHtmlContext context)
        {
            var mainBody = ConvertChildrenToHtml(document, context);
            var notes = FindNotes(document, NoteReferences);
            var noteNodes = notes.IsEmpty() ? Lists.List<IHtmlNode>() : Lists.List(Html.Element("ol", Lists.EagerMap(notes, new DocumentToHtmlAnonymous2(this, context))));
            var commentNodes = (ReferencedComments).IsEmpty() ? Lists.List<IHtmlNode>() : Lists.List(Html.Element("dl", Lists.EagerFlatMap(ReferencedComments, new DocumentToHtmlAnonymous3(this, context))));
            return Lists.EagerConcat(mainBody, noteNodes, commentNodes);
        }

        public IHtmlNode ConvertToHtml(Note note, DocumentToHtmlContext context)
        {
            var id = GenerateNoteHtmlId(note.GetNoteType(), note.GetId());
            var referenceId = GenerateNoteRefHtmlId(note.GetNoteType(), note.GetId());
            var noteBody = ConvertToHtml(note.GetBody(), context);
            var backLink = Html.CollapsibleElement("p", Lists.List(Html.Text(" "), Html.Element("a", Maps.Map("href", "#" + referenceId), Lists.List(Html.Text("↑")))));
            return Html.Element("li", Maps.Map("id", id), Lists.EagerConcat(noteBody, Lists.List(backLink)));
        }

        public IList<IHtmlNode> ConvertToHtml(DocumentToHtmlReferencedComment referencedComment, DocumentToHtmlContext context)
        {
            var commentId = (referencedComment.Comment).GetCommentId();
            var body = ConvertToHtml((referencedComment.Comment).GetBody(), context);
            var backLink = Html.CollapsibleElement("p", Lists.List(Html.Text(" "), Html.Element("a", Maps.Map("href", "#" + GenerateReferenceHtmlId("comment", commentId)), Lists.List(Html.Text("↑")))));
            return Lists.List(Html.Element("dt", Maps.Map("id", GenerateReferentHtmlId("comment", commentId)), Lists.List(Html.Text("Comment " + referencedComment.Label))), Html.Element("dd", Lists.EagerConcat(body, Lists.List(backLink))));
        }

        public IList<IHtmlNode> ConvertToHtml(IList<IDocumentElement> elements, DocumentToHtmlContext context)
        {
            return Lists.EagerFlatMap(elements, new DocumentToHtmlAnonymous4(this, context));
        }

        public IList<IHtmlNode> ConvertChildrenToHtml(IHasChildren element, DocumentToHtmlContext context)
        {
            return ConvertToHtml(element.GetChildren(), context);
        }

        public IList<IHtmlNode> ConvertToHtml(IDocumentElement element, DocumentToHtmlContext context)
        {
            return element.Accept(create_ElementConverterVisitor(), context);
        }

        public string GenerateNoteHtmlId(NoteType noteType, string noteId)
        {
            return GenerateReferentHtmlId(NoteTypeToIdFragment(noteType), noteId);
        }

        public string GenerateNoteRefHtmlId(NoteType noteType, string noteId)
        {
            return GenerateReferenceHtmlId(NoteTypeToIdFragment(noteType), noteId);
        }

        public string GenerateReferentHtmlId(string referenceType, string referenceId)
        {
            return GenerateId((referenceType + "-") + referenceId);
        }

        public string GenerateReferenceHtmlId(string referenceType, string referenceId)
        {
            return GenerateId((referenceType + "-ref-") + referenceId);
        }

        public string NoteTypeToIdFragment(NoteType noteType)
        {
            switch (noteType) {
                case NoteType.Footnote:
                    return "footnote";
                case NoteType.Endnote:
                    return "endnote";
                default:
                    throw new UnsupportedOperationException();
            }
        }

        public string GenerateId(string bookmarkName)
        {
            return _idPrefix + bookmarkName;
        }

        public DocumentToHtmlElementConverterVisitor create_ElementConverterVisitor()
        {
            return new DocumentToHtmlElementConverterVisitor(this);
        }
    }
}
