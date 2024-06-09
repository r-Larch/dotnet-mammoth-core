namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__ElementConverterVisitor : Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal DocumentToHtml__ElementConverterVisitor(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> children = new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_5(this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, paragraph, context);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath mapping = (((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getParagraphHtmlPath(paragraph)).orElseGet(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_6(paragraph, this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml));
            return (mapping.wrap(children)).get();
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run run, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            Mammoth.Couscous.java.util.function.Supplier<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> nodes = new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_7(this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, run, context);
            if (run.isSmallCaps()) {
                nodes = ((((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getSmallCaps()).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static._EMPTY)).wrap(nodes);
            }
            if (run.isStrikethrough()) {
                nodes = ((((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getStrikethrough()).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static.collapsibleElement("s"))).wrap(nodes);
            }
            if (run.isUnderline()) {
                nodes = ((((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getUnderline()).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static._EMPTY)).wrap(nodes);
            }
            if (run.getVerticalAlignment() == Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment._SUBSCRIPT) {
                nodes = (Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static.collapsibleElement("sub")).wrap(nodes);
            }
            if (run.getVerticalAlignment() == Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment._SUPERSCRIPT) {
                nodes = (Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static.collapsibleElement("sup")).wrap(nodes);
            }
            if (run.isItalic()) {
                nodes = ((((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getItalic()).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static.collapsibleElement("em"))).wrap(nodes);
            }
            if (run.isBold()) {
                nodes = ((((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getBold()).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static.collapsibleElement("strong"))).wrap(nodes);
            }
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath mapping = (((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getRunHtmlPath(run)).orElseGet(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_8(run, this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml));
            return (mapping.wrap(nodes)).get();
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text text, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            if ((text.getValue()).isEmpty()) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>();
            } else {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text(text.getValue()));
            }
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Tab tab, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text("\t"));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break breakElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath mapping = (((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getBreakHtmlPath(breakElement)).orElseGet(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_9(breakElement));
            return (mapping.wrap(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_10())).get();
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table table, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath mapping = (((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getTableHtmlPath(table)).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static.element("table"));
            return (mapping.wrap(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_11(this, table, context))).get();
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> generateTableChildren(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table table, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            int bodyIndex = (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.findIndex<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(table.getChildren(), new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_12(this))).orElse((table.getChildren()).size());
            if (bodyIndex == 0) {
                return (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertToHtml(table.getChildren(), context.isHeader(false));
            } else {
                Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> headRows = (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertToHtml((table.getChildren()).subList(0, bodyIndex), context.isHeader(true));
                Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> bodyRows = (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertToHtml((table.getChildren()).subList(bodyIndex, (table.getChildren()).size()), context.isHeader(false));
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("thead", headRows), Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("tbody", bodyRows));
            }
        }
        public bool isHeader(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement child) {
            return ((Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Casts.tryCast<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow>(typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow), child)).map<bool>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_13())).orElse(false);
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow tableRow, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("tr", (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(tableRow, context)));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableCell tableCell, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            string tagName = context._isHeader ? "th" : "td";
            Mammoth.Couscous.java.util.Map<string, string> attributes = new Mammoth.Couscous.java.util.HashMap<string, string>();
            if (tableCell.getColspan() != 1) {
                attributes.put("colspan", (tableCell.getColspan()).ToString());
            }
            if (tableCell.getRowspan() != 1) {
                attributes.put("rowspan", (tableCell.getRowspan()).ToString());
            }
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element(tagName, attributes, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.cons<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html._FORCE_WRITE, (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(tableCell, context))));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink hyperlink, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            Mammoth.Couscous.java.util.Map<string, string> attributes = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.mutableMap<string, string>("href", this.generateHref(hyperlink));
            (hyperlink.getTargetFrame()).ifPresent(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_14(attributes));
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.collapsibleElement("a", attributes, (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).convertChildrenToHtml(hyperlink, context)));
        }
        public string generateHref(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink hyperlink) {
            if ((hyperlink.getHref()).isPresent()) {
                return (hyperlink.getHref()).get();
            } else if ((hyperlink.getAnchor()).isPresent()) {
                return "#" + (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).generateId((hyperlink.getAnchor()).get());
            } else {
                return "";
            }
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Bookmark bookmark, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("a", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("id", (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).generateId(bookmark.getName())), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html._FORCE_WRITE)));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference noteReference, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            ((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._noteReferences).add(noteReference);
            string noteAnchor = (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).generateNoteHtmlId(noteReference.getNoteType(), noteReference.getNoteId());
            string noteReferenceAnchor = (this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml).generateNoteRefHtmlId(noteReference.getNoteType(), noteReference.getNoteId());
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("sup", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("a", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.map<string, string>("href", "#" + noteAnchor, "id", noteReferenceAnchor), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.text(("[" + ((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._noteReferences).size()) + "]"))))));
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.CommentReference commentReference, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            return (((((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._styleMap).getCommentReference()).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.HtmlPath_static._IGNORE)).wrap(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_16(commentReference, this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml))).get();
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image image, Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Context context) {
            return ((image.getContentType()).map<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_19(this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, image))).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>());
        }
    }
}

