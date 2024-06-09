using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__ElementConverterVisitor : DocumentElementVisitor<List<HtmlNode>, DocumentToHtml__Context> {
        internal DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;

        internal DocumentToHtml__ElementConverterVisitor(DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)
        {
            _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        }

        public List<HtmlNode> visit(Paragraph paragraph, DocumentToHtml__Context context)
        {
            Supplier<List<HtmlNode>> children = new DocumentToHtml__Anonymous_5(_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, paragraph, context);
            var mapping = (((_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getParagraphHtmlPath(paragraph)).orElseGet(new DocumentToHtml__Anonymous_6(paragraph, _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml));
            return (mapping.wrap(children)).get();
        }

        public List<HtmlNode> visit(Run run, DocumentToHtml__Context context)
        {
            Supplier<List<HtmlNode>> nodes = new DocumentToHtml__Anonymous_7(_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, run, context);
            if (run.isSmallCaps()) {
                nodes = ((((_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getSmallCaps()).orElse(HtmlPath_static._EMPTY)).wrap(nodes);
            }

            if (run.isStrikethrough()) {
                nodes = ((((_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getStrikethrough()).orElse(HtmlPath_static.collapsibleElement("s"))).wrap(nodes);
            }

            if (run.isUnderline()) {
                nodes = ((((_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getUnderline()).orElse(HtmlPath_static._EMPTY)).wrap(nodes);
            }

            if (run.getVerticalAlignment() == VerticalAlignment._SUBSCRIPT) {
                nodes = (HtmlPath_static.collapsibleElement("sub")).wrap(nodes);
            }

            if (run.getVerticalAlignment() == VerticalAlignment._SUPERSCRIPT) {
                nodes = (HtmlPath_static.collapsibleElement("sup")).wrap(nodes);
            }

            if (run.isItalic()) {
                nodes = ((((_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getItalic()).orElse(HtmlPath_static.collapsibleElement("em"))).wrap(nodes);
            }

            if (run.isBold()) {
                nodes = ((((_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getBold()).orElse(HtmlPath_static.collapsibleElement("strong"))).wrap(nodes);
            }

            var mapping = (((_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getRunHtmlPath(run)).orElseGet(new DocumentToHtml__Anonymous_8(run, _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml));
            return (mapping.wrap(nodes)).get();
        }

        public List<HtmlNode> visit(Text text, DocumentToHtml__Context context)
        {
            if ((text.getValue()).isEmpty()) {
                return Lists.list<HtmlNode>();
            }

            return Lists.list(Html.text(text.getValue()));
        }

        public List<HtmlNode> visit(Tab tab, DocumentToHtml__Context context)
        {
            return Lists.list(Html.text("\t"));
        }

        public List<HtmlNode> visit(Break breakElement, DocumentToHtml__Context context)
        {
            var mapping = (((_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getBreakHtmlPath(breakElement)).orElseGet(new DocumentToHtml__Anonymous_9(breakElement));
            return (mapping.wrap(new DocumentToHtml__Anonymous_10())).get();
        }

        public List<HtmlNode> visit(Table table, DocumentToHtml__Context context)
        {
            var mapping = (((_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getTableHtmlPath(table)).orElse(HtmlPath_static.element("table"));
            return (mapping.wrap(new DocumentToHtml__Anonymous_11(this, table, context))).get();
        }

        public List<HtmlNode> visit(TableRow tableRow, DocumentToHtml__Context context)
        {
            return Lists.list(Html.element("tr", (_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(tableRow, context)));
        }

        public List<HtmlNode> visit(TableCell tableCell, DocumentToHtml__Context context)
        {
            var tagName = context._isHeader ? "th" : "td";
            Map<string, string> attributes = new HashMap<string, string>();
            if (tableCell.getColspan() != 1) {
                attributes.put("colspan", (tableCell.getColspan()).ToString());
            }

            if (tableCell.getRowspan() != 1) {
                attributes.put("rowspan", (tableCell.getRowspan()).ToString());
            }

            return Lists.list(Html.element(tagName, attributes, Lists.cons(Html._FORCE_WRITE, (_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(tableCell, context))));
        }

        public List<HtmlNode> visit(Hyperlink hyperlink, DocumentToHtml__Context context)
        {
            var attributes = Maps.mutableMap("href", generateHref(hyperlink));
            (hyperlink.getTargetFrame()).ifPresent(new DocumentToHtml__Anonymous_14(attributes));
            return Lists.list(Html.collapsibleElement("a", attributes, (_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(hyperlink, context)));
        }

        public List<HtmlNode> visit(Bookmark bookmark, DocumentToHtml__Context context)
        {
            return Lists.list(Html.element("a", Maps.map("id", (_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).generateId(bookmark.getName())), Lists.list(Html._FORCE_WRITE)));
        }

        public List<HtmlNode> visit(NoteReference noteReference, DocumentToHtml__Context context)
        {
            ((_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._noteReferences).add(noteReference);
            var noteAnchor = (_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).generateNoteHtmlId(noteReference.getNoteType(), noteReference.getNoteId());
            var noteReferenceAnchor = (_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).generateNoteRefHtmlId(noteReference.getNoteType(), noteReference.getNoteId());
            return Lists.list(Html.element("sup", Lists.list(Html.element("a", Maps.map("href", "#" + noteAnchor, "id", noteReferenceAnchor), Lists.list(Html.text(("[" + ((_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._noteReferences).size()) + "]"))))));
        }

        public List<HtmlNode> visit(CommentReference commentReference, DocumentToHtml__Context context)
        {
            return (((((_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getCommentReference()).orElse(HtmlPath_static._IGNORE)).wrap(new DocumentToHtml__Anonymous_16(commentReference, _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml))).get();
        }

        public List<HtmlNode> visit(Image image, DocumentToHtml__Context context)
        {
            return ((image.getContentType()).map(new DocumentToHtml__Anonymous_19(_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, image))).orElse(Lists.list<HtmlNode>());
        }

        public List<HtmlNode> generateTableChildren(Table table, DocumentToHtml__Context context)
        {
            var bodyIndex = (Iterables.findIndex(table.getChildren(), new DocumentToHtml__Anonymous_12(this))).orElse((table.getChildren()).size());
            if (bodyIndex == 0) {
                return (_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertToHtml(table.getChildren(), context.isHeader(false));
            }

            var headRows = (_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertToHtml((table.getChildren()).subList(0, bodyIndex), context.isHeader(true));
            var bodyRows = (_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertToHtml((table.getChildren()).subList(bodyIndex, (table.getChildren()).size()), context.isHeader(false));
            return Lists.list(Html.element("thead", headRows), Html.element("tbody", bodyRows));
        }

        public bool isHeader(DocumentElement child)
        {
            return ((Casts.tryCast<TableRow>(typeof(TableRow), child)).map(new DocumentToHtml__Anonymous_13())).orElse(false);
        }

        public string generateHref(Hyperlink hyperlink)
        {
            if ((hyperlink.getHref()).isPresent()) {
                return (hyperlink.getHref()).get();
            }

            if ((hyperlink.getAnchor()).isPresent()) {
                return "#" + (_this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).generateId((hyperlink.getAnchor()).get());
            }

            return "";
        }
    }
}
