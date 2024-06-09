using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlElementConverterVisitor : IDocumentElementVisitor<IList<IHtmlNode>, DocumentToHtmlContext> {
        private DocumentToHtml _thisOrgZwobbleMammothInternalConversionDocumentToHtml;

        internal DocumentToHtmlElementConverterVisitor(DocumentToHtml thisOrgZwobbleMammothInternalConversionDocumentToHtml)
        {
            _thisOrgZwobbleMammothInternalConversionDocumentToHtml = thisOrgZwobbleMammothInternalConversionDocumentToHtml;
        }

        public IList<IHtmlNode> Visit(Paragraph paragraph, DocumentToHtmlContext context)
        {
            ISupplier<IList<IHtmlNode>> children = new DocumentToHtmlAnonymous5(_thisOrgZwobbleMammothInternalConversionDocumentToHtml, paragraph, context);
            var mapping = (((_thisOrgZwobbleMammothInternalConversionDocumentToHtml).StyleMap).GetParagraphHtmlPath(paragraph)).OrElseGet(new DocumentToHtmlAnonymous6(paragraph, _thisOrgZwobbleMammothInternalConversionDocumentToHtml));
            return (mapping.Wrap(children)).Get();
        }

        public IList<IHtmlNode> Visit(Run run, DocumentToHtmlContext context)
        {
            ISupplier<IList<IHtmlNode>> nodes = new DocumentToHtmlAnonymous7(_thisOrgZwobbleMammothInternalConversionDocumentToHtml, run, context);
            if (run.IsSmallCaps()) {
                nodes = ((((_thisOrgZwobbleMammothInternalConversionDocumentToHtml).StyleMap).GetSmallCaps()).OrElse(HtmlPathStatic.Empty)).Wrap(nodes);
            }

            if (run.IsStrikethrough()) {
                nodes = ((((_thisOrgZwobbleMammothInternalConversionDocumentToHtml).StyleMap).GetStrikethrough()).OrElse(HtmlPathStatic.CollapsibleElement("s"))).Wrap(nodes);
            }

            if (run.IsUnderline()) {
                nodes = ((((_thisOrgZwobbleMammothInternalConversionDocumentToHtml).StyleMap).GetUnderline()).OrElse(HtmlPathStatic.Empty)).Wrap(nodes);
            }

            if (run.GetVerticalAlignment() == VerticalAlignment.Subscript) {
                nodes = (HtmlPathStatic.CollapsibleElement("sub")).Wrap(nodes);
            }

            if (run.GetVerticalAlignment() == VerticalAlignment.Superscript) {
                nodes = (HtmlPathStatic.CollapsibleElement("sup")).Wrap(nodes);
            }

            if (run.IsItalic()) {
                nodes = ((((_thisOrgZwobbleMammothInternalConversionDocumentToHtml).StyleMap).GetItalic()).OrElse(HtmlPathStatic.CollapsibleElement("em"))).Wrap(nodes);
            }

            if (run.IsBold()) {
                nodes = ((((_thisOrgZwobbleMammothInternalConversionDocumentToHtml).StyleMap).GetBold()).OrElse(HtmlPathStatic.CollapsibleElement("strong"))).Wrap(nodes);
            }

            var mapping = (((_thisOrgZwobbleMammothInternalConversionDocumentToHtml).StyleMap).GetRunHtmlPath(run)).OrElseGet(new DocumentToHtmlAnonymous8(run, _thisOrgZwobbleMammothInternalConversionDocumentToHtml));
            return (mapping.Wrap(nodes)).Get();
        }

        public IList<IHtmlNode> Visit(Text text, DocumentToHtmlContext context)
        {
            if ((text.GetValue()).IsEmpty()) {
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
            var mapping = (((_thisOrgZwobbleMammothInternalConversionDocumentToHtml).StyleMap).GetBreakHtmlPath(breakElement)).OrElseGet(new DocumentToHtmlAnonymous9(breakElement));
            return (mapping.Wrap(new DocumentToHtmlAnonymous10())).Get();
        }

        public IList<IHtmlNode> Visit(Table table, DocumentToHtmlContext context)
        {
            var mapping = (((_thisOrgZwobbleMammothInternalConversionDocumentToHtml).StyleMap).GetTableHtmlPath(table)).OrElse(HtmlPathStatic.Element("table"));
            return (mapping.Wrap(new DocumentToHtmlAnonymous11(this, table, context))).Get();
        }

        public IList<IHtmlNode> Visit(TableRow tableRow, DocumentToHtmlContext context)
        {
            return Lists.List(Html.Element("tr", (_thisOrgZwobbleMammothInternalConversionDocumentToHtml).ConvertChildrenToHtml(tableRow, context)));
        }

        public IList<IHtmlNode> Visit(TableCell tableCell, DocumentToHtmlContext context)
        {
            var tagName = context.IsHeader ? "th" : "td";
            IMap<string, string> attributes = new HashMap<string, string>();
            if (tableCell.GetColspan() != 1) {
                attributes.Put("colspan", (tableCell.GetColspan()).ToString());
            }

            if (tableCell.GetRowspan() != 1) {
                attributes.Put("rowspan", (tableCell.GetRowspan()).ToString());
            }

            return Lists.List(Html.Element(tagName, attributes, Lists.Cons(Html.ForceWrite, (_thisOrgZwobbleMammothInternalConversionDocumentToHtml).ConvertChildrenToHtml(tableCell, context))));
        }

        public IList<IHtmlNode> Visit(Hyperlink hyperlink, DocumentToHtmlContext context)
        {
            var attributes = Maps.MutableMap("href", GenerateHref(hyperlink));
            (hyperlink.GetTargetFrame()).IfPresent(new DocumentToHtmlAnonymous14(attributes));
            return Lists.List(Html.CollapsibleElement("a", attributes, (_thisOrgZwobbleMammothInternalConversionDocumentToHtml).ConvertChildrenToHtml(hyperlink, context)));
        }

        public IList<IHtmlNode> Visit(Bookmark bookmark, DocumentToHtmlContext context)
        {
            return Lists.List(Html.Element("a", Maps.Map("id", (_thisOrgZwobbleMammothInternalConversionDocumentToHtml).GenerateId(bookmark.GetName())), Lists.List(Html.ForceWrite)));
        }

        public IList<IHtmlNode> Visit(NoteReference noteReference, DocumentToHtmlContext context)
        {
            ((_thisOrgZwobbleMammothInternalConversionDocumentToHtml).NoteReferences).Add(noteReference);
            var noteAnchor = (_thisOrgZwobbleMammothInternalConversionDocumentToHtml).GenerateNoteHtmlId(noteReference.GetNoteType(), noteReference.GetNoteId());
            var noteReferenceAnchor = (_thisOrgZwobbleMammothInternalConversionDocumentToHtml).GenerateNoteRefHtmlId(noteReference.GetNoteType(), noteReference.GetNoteId());
            return Lists.List(Html.Element("sup", Lists.List(Html.Element("a", Maps.Map("href", "#" + noteAnchor, "id", noteReferenceAnchor), Lists.List(Html.Text(("[" + ((_thisOrgZwobbleMammothInternalConversionDocumentToHtml).NoteReferences).Size()) + "]"))))));
        }

        public IList<IHtmlNode> Visit(CommentReference commentReference, DocumentToHtmlContext context)
        {
            return (((((_thisOrgZwobbleMammothInternalConversionDocumentToHtml).StyleMap).GetCommentReference()).OrElse(HtmlPathStatic.Ignore)).Wrap(new DocumentToHtmlAnonymous16(commentReference, _thisOrgZwobbleMammothInternalConversionDocumentToHtml))).Get();
        }

        public IList<IHtmlNode> Visit(Image image, DocumentToHtmlContext context)
        {
            return ((image.GetContentType()).Map(new DocumentToHtmlAnonymous19(_thisOrgZwobbleMammothInternalConversionDocumentToHtml, image))).OrElse(Lists.List<IHtmlNode>());
        }

        public IList<IHtmlNode> GenerateTableChildren(Table table, DocumentToHtmlContext context)
        {
            var bodyIndex = (Iterables.FindIndex(table.GetChildren(), new DocumentToHtmlAnonymous12(this))).OrElse((table.GetChildren()).Size());
            if (bodyIndex == 0) {
                return (_thisOrgZwobbleMammothInternalConversionDocumentToHtml).ConvertToHtml(table.GetChildren(), context.CreateIsHeader(false));
            }

            var headRows = (_thisOrgZwobbleMammothInternalConversionDocumentToHtml).ConvertToHtml((table.GetChildren()).SubList(0, bodyIndex), context.CreateIsHeader(true));
            var bodyRows = (_thisOrgZwobbleMammothInternalConversionDocumentToHtml).ConvertToHtml((table.GetChildren()).SubList(bodyIndex, (table.GetChildren()).Size()), context.CreateIsHeader(false));
            return Lists.List(Html.Element("thead", headRows), Html.Element("tbody", bodyRows));
        }

        public bool IsHeader(IDocumentElement child)
        {
            return ((Casts.TryCast<TableRow>(typeof(TableRow), child)).Map(new DocumentToHtmlAnonymous13())).OrElse(false);
        }

        public string GenerateHref(Hyperlink hyperlink)
        {
            if ((hyperlink.GetHref()).IsPresent()) {
                return (hyperlink.GetHref()).Get();
            }

            if ((hyperlink.GetAnchor()).IsPresent()) {
                return "#" + (_thisOrgZwobbleMammothInternalConversionDocumentToHtml).GenerateId((hyperlink.GetAnchor()).Get());
            }

            return "";
        }
    }
}
