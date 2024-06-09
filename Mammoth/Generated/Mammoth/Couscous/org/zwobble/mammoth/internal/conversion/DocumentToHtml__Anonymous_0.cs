using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.images;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlAnonymous0 : IFunction<Comment, string> {
        public string Apply(Comment arg0)
        {
            return arg0.GetCommentId();
        }
    }

    internal class DocumentToHtmlAnonymous1(Document document) : IFunction<NoteReference, Note> {
        public Note Apply(NoteReference reference)
        {
            return document.GetNotes().FindNote(reference.GetNoteType(), reference.GetNoteId()).Get();
        }
    }

    internal class DocumentToHtmlAnonymous10 : ISupplier<IList<IHtmlNode>> {
        public IList<IHtmlNode> Get()
        {
            return Lists.List<IHtmlNode>();
        }
    }

    internal class DocumentToHtmlAnonymous11(DocumentToHtmlElementConverterVisitor visitor, Table table, DocumentToHtmlContext context) : ISupplier<IList<IHtmlNode>> {
        public IList<IHtmlNode> Get()
        {
            return visitor.GenerateTableChildren(table, context);
        }
    }

    internal class DocumentToHtmlAnonymous12(DocumentToHtmlElementConverterVisitor visitor) : IPredicate<IDocumentElement> {
        public bool Test(IDocumentElement child)
        {
            return !visitor.IsHeader(child);
        }
    }

    internal class DocumentToHtmlAnonymous13 : IFunction<TableRow, bool> {
        public bool Apply(TableRow arg0)
        {
            return arg0.IsHeader();
        }
    }

    internal class DocumentToHtmlAnonymous14(IMap<string, string> attributes) : IConsumer<string> {
        public void Accept(string targetFrame)
        {
            attributes.Put("target", targetFrame);
        }
    }

    internal class DocumentToHtmlAnonymous15(string commentId) : ISupplier<RuntimeException> {
        public RuntimeException Get()
        {
            return new RuntimeException($"Referenced comment could not be found, id: {commentId}");
        }
    }

    internal class DocumentToHtmlAnonymous16(CommentReference commentReference, DocumentToHtml documentToHtml) : ISupplier<IList<IHtmlNode>> {
        public IList<IHtmlNode> Get()
        {
            var commentId = commentReference.GetCommentId();
            var comment = Maps.Lookup(documentToHtml.Comments, commentId).OrElseThrow(new DocumentToHtmlAnonymous15(commentId));
            var label = $"[{comment.GetAuthorInitials().OrElse("")}{(documentToHtml.ReferencedComments.Size() + 1)}]";
            documentToHtml.ReferencedComments.Add(new DocumentToHtmlReferencedComment(label, comment));
            return Lists.List(Html.Element("a", Maps.Map("href", $"#{documentToHtml.GenerateReferentHtmlId("comment", commentId)}", "id", documentToHtml.GenerateReferenceHtmlId("comment", commentId)), Lists.List(Html.Text(label))));
        }
    }

    internal class DocumentToHtmlAnonymous17(documents.Image image, string contentType) : images.IImage {
        public IOptional<string> GetAltText()
        {
            return image.GetAltText();
        }

        public string GetContentType()
        {
            return contentType;
        }

        public INputStream GetInputStream()
        {
            return image.Open();
        }
    }

    internal class DocumentToHtmlAnonymous18(IMap<string, string> attributes) : IConsumer<string> {
        public void Accept(string altText)
        {
            attributes.Put("alt", altText);
        }
    }

    internal class DocumentToHtmlAnonymous19(DocumentToHtml documentToHtml, documents.Image image) : IFunction<string, IList<IHtmlNode>> {
        public IList<IHtmlNode> Apply(string contentType)
        {
            try {
                IMap<string, string> attributes = new HashMap<string, string>(documentToHtml.ImageConverter.Convert(new DocumentToHtmlAnonymous17(image, contentType)));
                image.GetAltText().IfPresent(new DocumentToHtmlAnonymous18(attributes));
                return Lists.List(Html.Element("img", attributes));
            }
            catch (IoException exception) {
                documentToHtml.Warnings.Add(exception.GetMessage());
                return Lists.List<IHtmlNode>();
            }
        }
    }

    internal class DocumentToHtmlAnonymous2(DocumentToHtml documentToHtml, DocumentToHtmlContext context) : IFunction<Note, IHtmlNode> {
        public IHtmlNode Apply(Note note)
        {
            return documentToHtml.ConvertToHtml(note, context);
        }
    }

    internal class DocumentToHtmlAnonymous3(DocumentToHtml documentToHtml, DocumentToHtmlContext context) : IFunction<DocumentToHtmlReferencedComment, ITerable<IHtmlNode>> {
        public ITerable<IHtmlNode> Apply(DocumentToHtmlReferencedComment comment)
        {
            return documentToHtml.ConvertToHtml(comment, context);
        }
    }

    internal class DocumentToHtmlAnonymous4(DocumentToHtml documentToHtml, DocumentToHtmlContext context) : IFunction<IDocumentElement, ITerable<IHtmlNode>> {
        public ITerable<IHtmlNode> Apply(IDocumentElement element)
        {
            return documentToHtml.ConvertToHtml(element, context);
        }
    }

    internal class DocumentToHtmlAnonymous5(DocumentToHtml documentToHtml, Paragraph paragraph, DocumentToHtmlContext context) : ISupplier<IList<IHtmlNode>> {
        public IList<IHtmlNode> Get()
        {
            var content = documentToHtml.ConvertChildrenToHtml(paragraph, context);
            return documentToHtml.PreserveEmptyParagraphs ? Lists.Cons(Html.ForceWrite, content) : content;
        }
    }

    internal class DocumentToHtmlAnonymous6(Paragraph paragraph, DocumentToHtml documentToHtml) : ISupplier<IHtmlPath> {
        public IHtmlPath Get()
        {
            if (paragraph.GetStyle().IsPresent()) {
                documentToHtml.Warnings.Add($"Unrecognised paragraph style: {paragraph.GetStyle().Get().Describe()}");
            }

            return HtmlPathStatic.Element("p");
        }
    }

    internal class DocumentToHtmlAnonymous7(DocumentToHtml documentToHtml, Run run, DocumentToHtmlContext context) : ISupplier<IList<IHtmlNode>> {
        public IList<IHtmlNode> Get()
        {
            return documentToHtml.ConvertChildrenToHtml(run, context);
        }
    }

    internal class DocumentToHtmlAnonymous8(Run run, DocumentToHtml documentToHtml) : ISupplier<IHtmlPath> {
        public IHtmlPath Get()
        {
            if (run.GetStyle().IsPresent()) {
                documentToHtml.Warnings.Add($"Unrecognised run style: {run.GetStyle().Get().Describe()}");
            }

            return HtmlPathStatic.Empty;
        }
    }

    internal class DocumentToHtmlAnonymous9(Break breakElement) : ISupplier<IHtmlPath> {
        public IHtmlPath Get()
        {
            if (breakElement.Type == BreakType.Line) {
                return HtmlPathStatic.Element("br");
            }

            return HtmlPathStatic.Empty;
        }
    }

    internal class DocumentToHtmlContext(bool isHeader) {
        public bool IsHeader { get; } = isHeader;

        public DocumentToHtmlContext CreateIsHeader(bool isHeader)
        {
            return new DocumentToHtmlContext(isHeader);
        }
    }

    internal class DocumentToHtmlElementConverterVisitor(DocumentToHtml documentToHtml) : IDocumentElementVisitor<IList<IHtmlNode>, DocumentToHtmlContext> {
        public IList<IHtmlNode> Visit(Paragraph paragraph, DocumentToHtmlContext context)
        {
            ISupplier<IList<IHtmlNode>> children = new DocumentToHtmlAnonymous5(documentToHtml, paragraph, context);
            var mapping = documentToHtml.StyleMap.GetParagraphHtmlPath(paragraph).OrElseGet(new DocumentToHtmlAnonymous6(paragraph, documentToHtml));
            return mapping.Wrap(children).Get();
        }

        public IList<IHtmlNode> Visit(Run run, DocumentToHtmlContext context)
        {
            ISupplier<IList<IHtmlNode>> nodes = new DocumentToHtmlAnonymous7(documentToHtml, run, context);
            if (run.IsSmallCaps()) {
                nodes = documentToHtml.StyleMap.GetSmallCaps().OrElse(HtmlPathStatic.Empty).Wrap(nodes);
            }

            if (run.IsStrikethrough()) {
                nodes = documentToHtml.StyleMap.GetStrikethrough().OrElse(HtmlPathStatic.CollapsibleElement("s")).Wrap(nodes);
            }

            if (run.IsUnderline()) {
                nodes = documentToHtml.StyleMap.GetUnderline().OrElse(HtmlPathStatic.Empty).Wrap(nodes);
            }

            if (run.GetVerticalAlignment() == VerticalAlignment.Subscript) {
                nodes = HtmlPathStatic.CollapsibleElement("sub").Wrap(nodes);
            }

            if (run.GetVerticalAlignment() == VerticalAlignment.Superscript) {
                nodes = HtmlPathStatic.CollapsibleElement("sup").Wrap(nodes);
            }

            if (run.IsItalic()) {
                nodes = documentToHtml.StyleMap.GetItalic().OrElse(HtmlPathStatic.CollapsibleElement("em")).Wrap(nodes);
            }

            if (run.IsBold()) {
                nodes = documentToHtml.StyleMap.GetBold().OrElse(HtmlPathStatic.CollapsibleElement("strong")).Wrap(nodes);
            }

            var mapping = documentToHtml.StyleMap.GetRunHtmlPath(run).OrElseGet(new DocumentToHtmlAnonymous8(run, documentToHtml));
            return mapping.Wrap(nodes).Get();
        }

        public IList<IHtmlNode> Visit(Text text, DocumentToHtmlContext context)
        {
            if (text.GetValue().IsEmpty()) {
                return Lists.List<IHtmlNode>();
            }

            return Lists.List(Html.Text(text.GetValue()));
        }

        public IList<IHtmlNode> Visit(Tab tab, DocumentToHtmlContext context)
        {
            return Lists.List(Html.Text("\t"));
        }

        public IList<IHtmlNode> Visit(Break breakElement, DocumentToHtmlContext context)
        {
            var mapping = documentToHtml.StyleMap.GetBreakHtmlPath(breakElement).OrElseGet(new DocumentToHtmlAnonymous9(breakElement));
            return mapping.Wrap(new DocumentToHtmlAnonymous10()).Get();
        }

        public IList<IHtmlNode> Visit(Table table, DocumentToHtmlContext context)
        {
            var mapping = documentToHtml.StyleMap.GetTableHtmlPath(table).OrElse(HtmlPathStatic.Element("table"));
            return mapping.Wrap(new DocumentToHtmlAnonymous11(this, table, context)).Get();
        }

        public IList<IHtmlNode> Visit(TableRow tableRow, DocumentToHtmlContext context)
        {
            return Lists.List(Html.Element("tr", documentToHtml.ConvertChildrenToHtml(tableRow, context)));
        }

        public IList<IHtmlNode> Visit(TableCell tableCell, DocumentToHtmlContext context)
        {
            var tagName = context.IsHeader ? "th" : "td";
            IMap<string, string> attributes = new HashMap<string, string>();
            if (tableCell.GetColspan() != 1) {
                attributes.Put("colspan", tableCell.GetColspan().ToString());
            }

            if (tableCell.GetRowspan() != 1) {
                attributes.Put("rowspan", tableCell.GetRowspan().ToString());
            }

            return Lists.List(Html.Element(tagName, attributes, Lists.Cons(Html.ForceWrite, documentToHtml.ConvertChildrenToHtml(tableCell, context))));
        }

        public IList<IHtmlNode> Visit(Hyperlink hyperlink, DocumentToHtmlContext context)
        {
            var attributes = Maps.MutableMap("href", GenerateHref(hyperlink));
            hyperlink.GetTargetFrame().IfPresent(new DocumentToHtmlAnonymous14(attributes));
            return Lists.List(Html.CollapsibleElement("a", attributes, documentToHtml.ConvertChildrenToHtml(hyperlink, context)));
        }

        public IList<IHtmlNode> Visit(Bookmark bookmark, DocumentToHtmlContext context)
        {
            return Lists.List(Html.Element("a", Maps.Map("id", documentToHtml.GenerateId(bookmark.GetName())), Lists.List(Html.ForceWrite)));
        }

        public IList<IHtmlNode> Visit(NoteReference noteReference, DocumentToHtmlContext context)
        {
            documentToHtml.NoteReferences.Add(noteReference);
            var noteAnchor = documentToHtml.GenerateNoteHtmlId(noteReference.GetNoteType(), noteReference.GetNoteId());
            var noteReferenceAnchor = documentToHtml.GenerateNoteRefHtmlId(noteReference.GetNoteType(), noteReference.GetNoteId());
            return Lists.List(Html.Element("sup", Lists.List(Html.Element("a", Maps.Map("href", $"#{noteAnchor}", "id", noteReferenceAnchor), Lists.List(Html.Text($"[{documentToHtml.NoteReferences.Size()}]"))))));
        }

        public IList<IHtmlNode> Visit(CommentReference commentReference, DocumentToHtmlContext context)
        {
            return documentToHtml.StyleMap.GetCommentReference().OrElse(HtmlPathStatic.Ignore).Wrap(new DocumentToHtmlAnonymous16(commentReference, documentToHtml)).Get();
        }

        public IList<IHtmlNode> Visit(documents.Image image, DocumentToHtmlContext context)
        {
            return image.GetContentType().Map(new DocumentToHtmlAnonymous19(documentToHtml, image)).OrElse(Lists.List<IHtmlNode>());
        }

        public IList<IHtmlNode> GenerateTableChildren(Table table, DocumentToHtmlContext context)
        {
            var bodyIndex = Iterables.FindIndex(table.GetChildren(), new DocumentToHtmlAnonymous12(this)).OrElse(table.GetChildren().Size());
            if (bodyIndex == 0) {
                return documentToHtml.ConvertToHtml(table.GetChildren(), context.CreateIsHeader(false));
            }

            var headRows = documentToHtml.ConvertToHtml(table.GetChildren().SubList(0, bodyIndex), context.CreateIsHeader(true));
            var bodyRows = documentToHtml.ConvertToHtml(table.GetChildren().SubList(bodyIndex, table.GetChildren().Size()), context.CreateIsHeader(false));
            return Lists.List(Html.Element("thead", headRows), Html.Element("tbody", bodyRows));
        }

        public bool IsHeader(IDocumentElement child)
        {
            return Casts.TryCast<TableRow>(typeof(TableRow), child).Map(new DocumentToHtmlAnonymous13()).OrElse(false);
        }

        public string GenerateHref(Hyperlink hyperlink)
        {
            if (hyperlink.GetHref().IsPresent()) {
                return hyperlink.GetHref().Get();
            }

            if (hyperlink.GetAnchor().IsPresent()) {
                return $"#{documentToHtml.GenerateId(hyperlink.GetAnchor().Get())}";
            }

            return "";
        }
    }

    internal class DocumentToHtmlReferencedComment(string label, Comment comment) {
        public Comment Comment { get; } = comment;
        public string Label { get; } = label;
    }
}
