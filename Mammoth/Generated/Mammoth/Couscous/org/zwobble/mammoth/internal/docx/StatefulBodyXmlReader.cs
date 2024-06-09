namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader {
        internal static Mammoth.Couscous.java.util.Set<string> _IMAGE_TYPES_SUPPORTED_BY_BROWSERS;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles _styles;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering _numbering;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships _relationships;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes _contentTypes;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive _file;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.FileReader _fileReader;
        internal Mammoth.Couscous.java.lang.StringBuilder _currentInstrText;
        internal Mammoth.Couscous.java.util.Queue<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField> _complexFieldStack;
        static StatefulBodyXmlReader() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader._IMAGE_TYPES_SUPPORTED_BY_BROWSERS = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Sets.set<string>(new string[] {"image/png", "image/gif", "image/jpeg", "image/svg+xml", "image/tiff"});
        }
        internal StatefulBodyXmlReader(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Styles styles, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering numbering, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Relationships relationships, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ContentTypes contentTypes, Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive file, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.FileReader fileReader) {
            this._styles = styles;
            this._numbering = numbering;
            this._relationships = relationships;
            this._contentTypes = contentTypes;
            this._file = file;
            this._fileReader = fileReader;
            this._currentInstrText = new Mammoth.Couscous.java.lang.StringBuilder();
            this._complexFieldStack = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Queues.stack<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField>();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            switch (element.getName()) {
                case "w:t":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text(element.innerText()));
                case "w:r":
                    return this.readRun(element);
                case "w:p":
                    return this.readParagraph(element);
                case "w:fldChar":
                    return this.readFieldChar(element);
                case "w:instrText":
                    return this.readInstrText(element);
                case "w:tab":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Tab._TAB);
                case "w:noBreakHyphen":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text("‑"));
                case "w:br":
                    return this.readBreak(element);
                case "w:tbl":
                    return this.readTable(element);
                case "w:tr":
                    return this.readTableRow(element);
                case "w:tc":
                    return this.readTableCell(element);
                case "w:hyperlink":
                    return this.readHyperlink(element);
                case "w:bookmarkStart":
                    return this.readBookmark(element);
                case "w:footnoteReference":
                    return this.readNoteReference(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType._FOOTNOTE, element);
                case "w:endnoteReference":
                    return this.readNoteReference(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType._ENDNOTE, element);
                case "w:commentReference":
                    return this.readCommentReference(element);
                case "w:pict":
                    return this.readPict(element);
                case "v:imagedata":
                    return this.readImagedata(element);
                case "wp:inline":
                case "wp:anchor":
                    return this.readInline(element);
                case "w:sdt":
                    return this.readSdt(element);
                case "w:ins":
                case "w:object":
                case "w:smartTag":
                case "w:drawing":
                case "v:group":
                case "v:roundrect":
                case "v:shape":
                case "v:textbox":
                case "w:txbxContent":
                    return this.readElements(element.getChildren());
                case "office-word:wrap":
                case "v:shadow":
                case "v:shapetype":
                case "w:bookmarkEnd":
                case "w:sectPr":
                case "w:proofErr":
                case "w:lastRenderedPageBreak":
                case "w:commentRangeStart":
                case "w:commentRangeEnd":
                case "w:del":
                case "w:footnoteRef":
                case "w:endnoteRef":
                case "w:annotationRef":
                case "w:pPr":
                case "w:rPr":
                case "w:tblPr":
                case "w:tblGrid":
                case "w:trPr":
                case "w:tcPr":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
                default:
                    string warning = "An unrecognised element was ignored: " + element.getName();
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.emptyWithWarning(warning);
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readRun(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties = element.findChildOrEmpty("w:rPr");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.map<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>(this.readRunStyle(properties), this.readElements(element.getChildren()), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_0(this, properties));
        }
        public Mammoth.Couscous.java.util.Optional<string> currentHyperlinkHref() {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.tryGetLast<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__HyperlinkComplexField>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFilter<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__HyperlinkComplexField>(this._complexFieldStack, typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__HyperlinkComplexField)))).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_1());
        }
        public bool isBold(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return this.readBooleanElement(properties, "w:b");
        }
        public bool isItalic(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return this.readBooleanElement(properties, "w:i");
        }
        public bool isUnderline(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return this.readBooleanElement(properties, "w:u");
        }
        public bool isStrikethrough(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return this.readBooleanElement(properties, "w:strike");
        }
        public bool isSmallCaps(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return this.readBooleanElement(properties, "w:smallCaps");
        }
        public bool readBooleanElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties, string tagName) {
            return ((properties.findChild(tagName)).map<bool>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_3())).orElse(false);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment readVerticalAlignment(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            string verticalAlignment = (this.readVal(properties, "w:vertAlign")).orElse("");
            switch (verticalAlignment) {
                case "superscript":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment._SUPERSCRIPT;
                case "subscript":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment._SUBSCRIPT;
                default:
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.VerticalAlignment._BASELINE;
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> readRunStyle(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return this.readStyle(properties, "w:rStyle", "Run", new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_4(this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readElements(Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> nodes) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFilter<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(nodes, typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement)), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_5(this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readParagraph(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties = element.findChildOrEmpty("w:pPr");
            Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> numbering = this.readNumbering(properties);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.ParagraphIndent indent = this.readParagraphIndent(properties);
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.map<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>(this.readParagraphStyle(properties), this.readElements(element.getChildren()), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_6(numbering, indent))).appendExtra();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readFieldChar(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string type = (element.getAttributeOrNone("w:fldCharType")).orElse("");
            if (type.Equals("begin")) {
                (this._complexFieldStack).add(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField_static._UNKNOWN);
                (this._currentInstrText).setLength(0);
            } else if (type.Equals("end")) {
                (this._complexFieldStack).remove();
            } else if (type.Equals("separate")) {
                string instrText = (this._currentInstrText).toString();
                Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField complexField = ((this.parseHyperlinkFieldCode(instrText)).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_7())).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__ComplexField_static._UNKNOWN);
                (this._complexFieldStack).remove();
                (this._complexFieldStack).add(complexField);
            }
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readInstrText(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            (this._currentInstrText).append(element.innerText());
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
        }
        public Mammoth.Couscous.java.util.Optional<string> parseHyperlinkFieldCode(string instrText) {
            Mammoth.Couscous.java.util.regex.Pattern pattern = Mammoth.Couscous.java.util.regex.Pattern.compile("\\s*HYPERLINK \"(.*)\"");
            Mammoth.Couscous.java.util.regex.Matcher matcher = pattern.matcher(instrText);
            if (matcher.lookingAt()) {
                return Mammoth.Couscous.java.util.Optional.of<string>(matcher.group(1));
            } else {
                return Mammoth.Couscous.java.util.Optional.empty<string>();
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> readParagraphStyle(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return this.readStyle(properties, "w:pStyle", "Paragraph", new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_8(this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> readStyle(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties, string styleTagName, string styleType, Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> findStyleById) {
            return ((this.readVal(properties, styleTagName)).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_9(this, styleType, findStyleById))).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.empty());
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> findStyleById(string styleType, string styleId, Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> findStyleById) {
            Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style> style = findStyleById.apply(styleId);
            if (style.isPresent()) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult.success<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>(style);
            } else {
                return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>(Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style(styleId, Mammoth.Couscous.java.util.Optional.empty<string>())), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(((styleType + " style with ID ") + styleId) + " was referenced but not defined in the document"));
            }
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> readNumbering(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike numberingProperties = properties.findChildOrEmpty("w:numPr");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.flatMap<string, string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(this.readVal(numberingProperties, "w:numId"), this.readVal(numberingProperties, "w:ilvl"), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_10(this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.ParagraphIndent readParagraphIndent(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike indent = properties.findChildOrEmpty("w:ind");
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.ParagraphIndent(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<string>(indent.getAttributeOrNone("w:start"), indent.getAttributeOrNone("w:left")), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<string>(indent.getAttributeOrNone("w:end"), indent.getAttributeOrNone("w:right")), indent.getAttributeOrNone("w:firstLine"), indent.getAttributeOrNone("w:hanging"));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readBreak(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string breakType = (element.getAttributeOrNone("w:type")).orElse("textWrapping");
            switch (breakType) {
                case "textWrapping":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break._LINE_BREAK);
                case "page":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break._PAGE_BREAK);
                case "column":
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break._COLUMN_BREAK);
                default:
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.emptyWithWarning("Unsupported break type: " + breakType);
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readTable(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties = element.findChildOrEmpty("w:tblPr");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.map<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>>(this.readTableStyle(properties), (this.readElements(element.getChildren())).flatMap(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_11(this)), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_12());
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Style>> readTableStyle(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return this.readStyle(properties, "w:tblStyle", "Table", new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_13(this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult calculateRowspans(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> rows) {
            Mammoth.Couscous.java.util.Optional<string> error = this.checkTableRows(rows);
            if (error.isPresent()) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.withWarning(rows, error.get());
            }
            Mammoth.Couscous.java.util.Map<Mammoth.Couscous.java.util.Map__Entry<int, int>, int> rowspans = new Mammoth.Couscous.java.util.HashMap<Mammoth.Couscous.java.util.Map__Entry<int, int>, int>();
            Mammoth.Couscous.java.util.Set<Mammoth.Couscous.java.util.Map__Entry<int, int>> merged = new Mammoth.Couscous.java.util.HashSet<Mammoth.Couscous.java.util.Map__Entry<int, int>>();
            Mammoth.Couscous.java.util.Map<int, Mammoth.Couscous.java.util.Map__Entry<int, int>> lastCellForColumn = new Mammoth.Couscous.java.util.HashMap<int, Mammoth.Couscous.java.util.Map__Entry<int, int>>();
             {
                int rowIndex = 0;
                while (rowIndex < rows.size()) {
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow row = (Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow) rows.get(rowIndex);
                    int columnIndex = 0;
                     {
                        int cellIndex = 0;
                        while (cellIndex < (row.getChildren()).size()) {
                            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__UnmergedTableCell cell = (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__UnmergedTableCell) (row.getChildren()).get(cellIndex);
                            Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.java.util.Map__Entry<int, int>> spanningCell = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<int, Mammoth.Couscous.java.util.Map__Entry<int, int>>(lastCellForColumn, columnIndex);
                            Mammoth.Couscous.java.util.Map__Entry<int, int> position = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<int, int>(rowIndex, cellIndex);
                            if (cell._vmerge && spanningCell.isPresent()) {
                                rowspans.put(spanningCell.get(), (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<Mammoth.Couscous.java.util.Map__Entry<int, int>, int>(rowspans, spanningCell.get())).get() + 1);
                                merged.add(position);
                            } else {
                                lastCellForColumn.put(columnIndex, position);
                                rowspans.put(position, 1);
                            }
                            columnIndex = columnIndex + cell._colspan;
                            cellIndex = cellIndex + 1;
                        }
                    }
                    rowIndex = rowIndex + 1;
                }
            }
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerMapWithIndex<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(rows, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_14(merged, rowspans)));
        }
        public Mammoth.Couscous.java.util.Optional<string> checkTableRows(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> rows) {
             {
                Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _couscous_desugar_foreach_to_for2 = rows.iterator();
                while (_couscous_desugar_foreach_to_for2.hasNext()) {
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement rowElement = _couscous_desugar_foreach_to_for2.next();
                    Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow> row = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Casts.tryCast<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow>(typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow), rowElement);
                    if (!row.isPresent()) {
                        return Mammoth.Couscous.java.util.Optional.of<string>("unexpected non-row element in table, cell merging may be incorrect");
                    } else {
                         {
                            Mammoth.Couscous.java.util.Iterator<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _couscous_desugar_foreach_to_for1 = ((row.get()).getChildren()).iterator();
                            while (_couscous_desugar_foreach_to_for1.hasNext()) {
                                Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement cell = _couscous_desugar_foreach_to_for1.next();
                                if (!(cell is Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__UnmergedTableCell)) {
                                    return Mammoth.Couscous.java.util.Optional.of<string>("unexpected non-cell element in table row, cell merging may be incorrect");
                                }
                            }
                        }
                    }
                }
            }
            return Mammoth.Couscous.java.util.Optional.empty<string>();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readTableRow(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties = element.findChildOrEmpty("w:trPr");
            bool isHeader = properties.hasChild("w:tblHeader");
            return (this.readElements(element.getChildren())).map(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_15(isHeader));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readTableCell(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties = element.findChildOrEmpty("w:tcPr");
            Mammoth.Couscous.java.util.Optional<string> gridSpan = (properties.findChildOrEmpty("w:gridSpan")).getAttributeOrNone("w:val");
            int colspan = (gridSpan.map<int>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_16())).orElse(1);
            return (this.readElements(element.getChildren())).map(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_17(this, properties, colspan));
        }
        public bool readVmerge(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties) {
            return ((properties.findChild("w:vMerge")).map<bool>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_19())).orElse(false);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readHyperlink(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.java.util.Optional<string> relationshipId = element.getAttributeOrNone("r:id");
            Mammoth.Couscous.java.util.Optional<string> anchor = element.getAttributeOrNone("w:anchor");
            Mammoth.Couscous.java.util.Optional<string> targetFrame = (element.getAttributeOrNone("w:tgtFrame")).filter(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_20());
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult childrenResult = this.readElements(element.getChildren());
            if (relationshipId.isPresent()) {
                string targetHref = (this._relationships).findTargetByRelationshipId(relationshipId.get());
                string href = (anchor.map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_21(targetHref, anchor))).orElse(targetHref);
                return childrenResult.map(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_22(href, targetFrame));
            } else if (anchor.isPresent()) {
                return childrenResult.map(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_23(anchor, targetFrame));
            } else {
                return childrenResult;
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readBookmark(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string name = element.getAttribute("w:name");
            if (name.Equals("_GoBack")) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
            } else {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Bookmark(name));
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readNoteReference(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteType noteType, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string noteId = element.getAttribute("w:id");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference(noteType, noteId));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readCommentReference(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string commentId = element.getAttribute("w:id");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.CommentReference(commentId));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readPict(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return (this.readElements(element.getChildren())).toExtra();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readImagedata(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return ((element.getAttributeOrNone("r:id")).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_25(element, this))).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.emptyWithWarning("A v:imagedata element without a relationship ID was ignored"));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readInline(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike properties = element.findChildOrEmpty("wp:docPr");
            Mammoth.Couscous.java.util.Optional<string> altText = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Optionals.first<string>((properties.getAttributeOrNone("descr")).filter(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_26()), properties.getAttributeOrNone("title"));
            Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList blips = ((((element.findChildren("a:graphic")).findChildren("a:graphicData")).findChildren("pic:pic")).findChildren("pic:blipFill")).findChildren("a:blip");
            return this.readBlips(blips, altText);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readBlips(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList blips, Mammoth.Couscous.java.util.Optional<string> altText) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.flatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(blips, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_27(this, altText));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readBlip(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement blip, Mammoth.Couscous.java.util.Optional<string> altText) {
            Mammoth.Couscous.java.util.Optional<string> embedRelationshipId = blip.getAttributeOrNone("r:embed");
            Mammoth.Couscous.java.util.Optional<string> linkRelationshipId = blip.getAttributeOrNone("r:link");
            if (embedRelationshipId.isPresent()) {
                string imagePath = this.relationshipIdToDocxPath(embedRelationshipId.get());
                return this.readImage(imagePath, altText, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_28(this, imagePath));
            } else if (linkRelationshipId.isPresent()) {
                string imagePath = (this._relationships).findTargetByRelationshipId(linkRelationshipId.get());
                return this.readImage(imagePath, altText, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_29(this, imagePath));
            } else {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS;
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readImage(string imagePath, Mammoth.Couscous.java.util.Optional<string> altText, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.InputStreamSupplier open) {
            Mammoth.Couscous.java.util.Optional<string> contentType = (this._contentTypes).findContentType(imagePath);
            Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image image = new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image(altText, contentType, open);
            string contentTypeString = contentType.orElse("(unknown)");
            if ((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader._IMAGE_TYPES_SUPPORTED_BY_BROWSERS).contains(contentTypeString)) {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(image);
            } else {
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.withWarning(image, ("Image of type " + contentTypeString) + " is unlikely to display in web browsers");
            }
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult readSdt(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return this.readElements((element.findChildOrEmpty("w:sdtContent")).getChildren());
        }
        public string relationshipIdToDocxPath(string relationshipId) {
            string target = (this._relationships).findTargetByRelationshipId(relationshipId);
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Uris.uriToZipEntryName("word", target);
        }
        public Mammoth.Couscous.java.util.Optional<string> readVal(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike element, string name) {
            return (element.findChildOrEmpty(name)).getAttributeOrNone("w:val");
        }
    }
}

