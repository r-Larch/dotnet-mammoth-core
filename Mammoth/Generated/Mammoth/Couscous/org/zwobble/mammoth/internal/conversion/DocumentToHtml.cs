using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.images;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml(DocumentToHtmlOptions options, IList<Comment> comments) {
        private static readonly DocumentToHtmlContext InitialContext = new(false);
        public IMap<string, Comment> Comments = Maps.ToMapWithKey(comments, new DocumentToHtmlAnonymous0());
        private readonly string _idPrefix = options.IdPrefix();
        public IMageConverterImgElement ImageConverter = options.ImageConverter();
        public IList<NoteReference> NoteReferences = new ArrayList<NoteReference>();
        public bool PreserveEmptyParagraphs = options.ShouldPreserveEmptyParagraphs();
        public IList<DocumentToHtmlReferencedComment> ReferencedComments = new ArrayList<DocumentToHtmlReferencedComment>();
        public StyleMap StyleMap = options.StyleMap();
        public ISet<string> Warnings = new HashSet<string>();

        public static InternalResult<IList<IHtmlNode>> ConvertToHtml(Document document, DocumentToHtmlOptions options)
        {
            var documentConverter = new DocumentToHtml(options, document.GetComments());
            return new InternalResult<IList<IHtmlNode>>(documentConverter.ConvertToHtml(document, InitialContext), documentConverter.Warnings);
        }

        public static IList<Note> FindNotes(Document document, ITerable<NoteReference> noteReferences)
        {
            return Lists.EagerMap(noteReferences, new DocumentToHtmlAnonymous1(document));
        }

        public static InternalResult<IList<IHtmlNode>> ConvertToHtml(IDocumentElement element, DocumentToHtmlOptions options)
        {
            var documentConverter = new DocumentToHtml(options, Lists.List<Comment>());
            return new InternalResult<IList<IHtmlNode>>(documentConverter.ConvertToHtml(element, InitialContext), documentConverter.Warnings);
        }

        public IList<IHtmlNode> ConvertToHtml(Document document, DocumentToHtmlContext context)
        {
            var mainBody = ConvertChildrenToHtml(document, context);
            var notes = FindNotes(document, NoteReferences);
            var noteNodes = notes.IsEmpty() ? Lists.List<IHtmlNode>() : Lists.List(Html.Element("ol", Lists.EagerMap(notes, new DocumentToHtmlAnonymous2(this, context))));
            var commentNodes = ReferencedComments.IsEmpty() ? Lists.List<IHtmlNode>() : Lists.List(Html.Element("dl", Lists.EagerFlatMap(ReferencedComments, new DocumentToHtmlAnonymous3(this, context))));
            return Lists.EagerConcat(mainBody, noteNodes, commentNodes);
        }

        public IHtmlNode ConvertToHtml(Note note, DocumentToHtmlContext context)
        {
            var id = GenerateNoteHtmlId(note.GetNoteType(), note.GetId());
            var referenceId = GenerateNoteRefHtmlId(note.GetNoteType(), note.GetId());
            var noteBody = ConvertToHtml(note.GetBody(), context);
            var backLink = Html.CollapsibleElement("p", Lists.List(Html.Text(" "), Html.Element("a", Maps.Map("href", $"#{referenceId}"), Lists.List(Html.Text("↑")))));
            return Html.Element("li", Maps.Map("id", id), Lists.EagerConcat(noteBody, Lists.List(backLink)));
        }

        public IList<IHtmlNode> ConvertToHtml(DocumentToHtmlReferencedComment referencedComment, DocumentToHtmlContext context)
        {
            var commentId = referencedComment.Comment.GetCommentId();
            var body = ConvertToHtml(referencedComment.Comment.GetBody(), context);
            var backLink = Html.CollapsibleElement("p", Lists.List(Html.Text(" "), Html.Element("a", Maps.Map("href", $"#{GenerateReferenceHtmlId("comment", commentId)}"), Lists.List(Html.Text("↑")))));
            return Lists.List(Html.Element("dt", Maps.Map("id", GenerateReferentHtmlId("comment", commentId)), Lists.List(Html.Text($"Comment {referencedComment.Label}"))), Html.Element("dd", Lists.EagerConcat(body, Lists.List(backLink))));
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
            return GenerateId($"{referenceType}-{referenceId}");
        }

        public string GenerateReferenceHtmlId(string referenceType, string referenceId)
        {
            return GenerateId($"{referenceType}-ref-{referenceId}");
        }

        public string NoteTypeToIdFragment(NoteType noteType)
        {
            return noteType switch {
                NoteType.Footnote => "footnote",
                NoteType.Endnote => "endnote",
                _ => throw new UnsupportedOperationException()
            };
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
