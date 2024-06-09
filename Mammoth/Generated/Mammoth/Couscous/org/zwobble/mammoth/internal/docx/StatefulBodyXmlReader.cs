using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.java.util.regex;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader {
        private static Set<string> _IMAGE_TYPES_SUPPORTED_BY_BROWSERS;
        private Queue<StatefulBodyXmlReader__ComplexField> _complexFieldStack;
        private ContentTypes _contentTypes;
        private StringBuilder _currentInstrText;
        public Archive _file;
        public FileReader _fileReader;
        public Numbering _numbering;
        private Relationships _relationships;
        public Styles _styles;

        static StatefulBodyXmlReader()
        {
            _IMAGE_TYPES_SUPPORTED_BY_BROWSERS = Sets.set(new[] { "image/png", "image/gif", "image/jpeg", "image/svg+xml", "image/tiff" });
        }

        internal StatefulBodyXmlReader(Styles styles, Numbering numbering, Relationships relationships, ContentTypes contentTypes, Archive file, FileReader fileReader)
        {
            _styles = styles;
            _numbering = numbering;
            _relationships = relationships;
            _contentTypes = contentTypes;
            _file = file;
            _fileReader = fileReader;
            _currentInstrText = new StringBuilder();
            _complexFieldStack = Queues.stack<StatefulBodyXmlReader__ComplexField>();
        }

        public ReadResult readElement(XmlElement element)
        {
            switch (element.getName()) {
                case "w:t":
                    return ReadResult.success(new Text(element.innerText()));
                case "w:r":
                    return readRun(element);
                case "w:p":
                    return readParagraph(element);
                case "w:fldChar":
                    return readFieldChar(element);
                case "w:instrText":
                    return readInstrText(element);
                case "w:tab":
                    return ReadResult.success(Tab._TAB);
                case "w:noBreakHyphen":
                    return ReadResult.success(new Text("‑"));
                case "w:br":
                    return readBreak(element);
                case "w:tbl":
                    return readTable(element);
                case "w:tr":
                    return readTableRow(element);
                case "w:tc":
                    return readTableCell(element);
                case "w:hyperlink":
                    return readHyperlink(element);
                case "w:bookmarkStart":
                    return readBookmark(element);
                case "w:footnoteReference":
                    return readNoteReference(NoteType._FOOTNOTE, element);
                case "w:endnoteReference":
                    return readNoteReference(NoteType._ENDNOTE, element);
                case "w:commentReference":
                    return readCommentReference(element);
                case "w:pict":
                    return readPict(element);
                case "v:imagedata":
                    return readImagedata(element);
                case "wp:inline":
                case "wp:anchor":
                    return readInline(element);
                case "w:sdt":
                    return readSdt(element);
                case "w:ins":
                case "w:object":
                case "w:smartTag":
                case "w:drawing":
                case "v:group":
                case "v:roundrect":
                case "v:shape":
                case "v:textbox":
                case "w:txbxContent":
                    return readElements(element.getChildren());
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
                    return ReadResult._EMPTY_SUCCESS;
                default:
                    var warning = "An unrecognised element was ignored: " + element.getName();
                    return ReadResult.emptyWithWarning(warning);
            }
        }

        public ReadResult readRun(XmlElement element)
        {
            var properties = element.findChildOrEmpty("w:rPr");
            return ReadResult.map(readRunStyle(properties), readElements(element.getChildren()), new StatefulBodyXmlReader__Anonymous_0(this, properties));
        }

        public Optional<string> currentHyperlinkHref()
        {
            return (Iterables.tryGetLast(Iterables.lazyFilter<StatefulBodyXmlReader__ComplexField, StatefulBodyXmlReader__HyperlinkComplexField>(_complexFieldStack, typeof(StatefulBodyXmlReader__HyperlinkComplexField)))).map(new StatefulBodyXmlReader__Anonymous_1());
        }

        public bool isBold(XmlElementLike properties)
        {
            return readBooleanElement(properties, "w:b");
        }

        public bool isItalic(XmlElementLike properties)
        {
            return readBooleanElement(properties, "w:i");
        }

        public bool isUnderline(XmlElementLike properties)
        {
            return readBooleanElement(properties, "w:u");
        }

        public bool isStrikethrough(XmlElementLike properties)
        {
            return readBooleanElement(properties, "w:strike");
        }

        public bool isSmallCaps(XmlElementLike properties)
        {
            return readBooleanElement(properties, "w:smallCaps");
        }

        public bool readBooleanElement(XmlElementLike properties, string tagName)
        {
            return ((properties.findChild(tagName)).map(new StatefulBodyXmlReader__Anonymous_3())).orElse(false);
        }

        public VerticalAlignment readVerticalAlignment(XmlElementLike properties)
        {
            var verticalAlignment = (readVal(properties, "w:vertAlign")).orElse("");
            switch (verticalAlignment) {
                case "superscript":
                    return VerticalAlignment._SUPERSCRIPT;
                case "subscript":
                    return VerticalAlignment._SUBSCRIPT;
                default:
                    return VerticalAlignment._BASELINE;
            }
        }

        public InternalResult<Optional<Style>> readRunStyle(XmlElementLike properties)
        {
            return readStyle(properties, "w:rStyle", "Run", new StatefulBodyXmlReader__Anonymous_4(this));
        }

        public ReadResult readElements(Iterable<XmlNode> nodes)
        {
            return ReadResult.flatMap(Iterables.lazyFilter<XmlNode, XmlElement>(nodes, typeof(XmlElement)), new StatefulBodyXmlReader__Anonymous_5(this));
        }

        public ReadResult readParagraph(XmlElement element)
        {
            var properties = element.findChildOrEmpty("w:pPr");
            var numbering = readNumbering(properties);
            var indent = readParagraphIndent(properties);
            return (ReadResult.map(readParagraphStyle(properties), readElements(element.getChildren()), new StatefulBodyXmlReader__Anonymous_6(numbering, indent))).appendExtra();
        }

        public ReadResult readFieldChar(XmlElement element)
        {
            var type = (element.getAttributeOrNone("w:fldCharType")).orElse("");
            if (type.Equals("begin")) {
                (_complexFieldStack).add(StatefulBodyXmlReader__ComplexField_static._UNKNOWN);
                (_currentInstrText).setLength(0);
            }
            else if (type.Equals("end")) {
                (_complexFieldStack).remove();
            }
            else if (type.Equals("separate")) {
                var instrText = (_currentInstrText).toString();
                var complexField = ((parseHyperlinkFieldCode(instrText)).map(new StatefulBodyXmlReader__Anonymous_7())).orElse(StatefulBodyXmlReader__ComplexField_static._UNKNOWN);
                (_complexFieldStack).remove();
                (_complexFieldStack).add(complexField);
            }

            return ReadResult._EMPTY_SUCCESS;
        }

        public ReadResult readInstrText(XmlElement element)
        {
            (_currentInstrText).append(element.innerText());
            return ReadResult._EMPTY_SUCCESS;
        }

        public Optional<string> parseHyperlinkFieldCode(string instrText)
        {
            var pattern = Pattern.compile("\\s*HYPERLINK \"(.*)\"");
            var matcher = pattern.matcher(instrText);
            if (matcher.lookingAt()) {
                return Optional.of(matcher.group(1));
            }

            return Optional.empty<string>();
        }

        public InternalResult<Optional<Style>> readParagraphStyle(XmlElementLike properties)
        {
            return readStyle(properties, "w:pStyle", "Paragraph", new StatefulBodyXmlReader__Anonymous_8(this));
        }

        public InternalResult<Optional<Style>> readStyle(XmlElementLike properties, string styleTagName, string styleType, Function<string, Optional<Style>> findStyleById)
        {
            return ((readVal(properties, styleTagName)).map(new StatefulBodyXmlReader__Anonymous_9(this, styleType, findStyleById))).orElse(InternalResult.empty());
        }

        public InternalResult<Optional<Style>> findStyleById(string styleType, string styleId, Function<string, Optional<Style>> findStyleById)
        {
            var style = findStyleById.apply(styleId);
            if (style.isPresent()) {
                return InternalResult.success(style);
            }

            return new InternalResult<Optional<Style>>(Optional.of(new Style(styleId, Optional.empty<string>())), Lists.list(((styleType + " style with ID ") + styleId) + " was referenced but not defined in the document"));
        }

        public Optional<NumberingLevel> readNumbering(XmlElementLike properties)
        {
            var numberingProperties = properties.findChildOrEmpty("w:numPr");
            return Optionals.flatMap(readVal(numberingProperties, "w:numId"), readVal(numberingProperties, "w:ilvl"), new StatefulBodyXmlReader__Anonymous_10(this));
        }

        public ParagraphIndent readParagraphIndent(XmlElementLike properties)
        {
            var indent = properties.findChildOrEmpty("w:ind");
            return new ParagraphIndent(Optionals.first(indent.getAttributeOrNone("w:start"), indent.getAttributeOrNone("w:left")), Optionals.first(indent.getAttributeOrNone("w:end"), indent.getAttributeOrNone("w:right")), indent.getAttributeOrNone("w:firstLine"), indent.getAttributeOrNone("w:hanging"));
        }

        public ReadResult readBreak(XmlElement element)
        {
            var breakType = (element.getAttributeOrNone("w:type")).orElse("textWrapping");
            switch (breakType) {
                case "textWrapping":
                    return ReadResult.success(Break._LINE_BREAK);
                case "page":
                    return ReadResult.success(Break._PAGE_BREAK);
                case "column":
                    return ReadResult.success(Break._COLUMN_BREAK);
                default:
                    return ReadResult.emptyWithWarning("Unsupported break type: " + breakType);
            }
        }

        public ReadResult readTable(XmlElement element)
        {
            var properties = element.findChildOrEmpty("w:tblPr");
            return ReadResult.map(readTableStyle(properties), (readElements(element.getChildren())).flatMap(new StatefulBodyXmlReader__Anonymous_11(this)), new StatefulBodyXmlReader__Anonymous_12());
        }

        public InternalResult<Optional<Style>> readTableStyle(XmlElementLike properties)
        {
            return readStyle(properties, "w:tblStyle", "Table", new StatefulBodyXmlReader__Anonymous_13(this));
        }

        public ReadResult calculateRowspans(List<DocumentElement> rows)
        {
            var error = checkTableRows(rows);
            if (error.isPresent()) {
                return ReadResult.withWarning(rows, error.get());
            }

            Map<Map__Entry<int, int>, int> rowspans = new HashMap<Map__Entry<int, int>, int>();
            Set<Map__Entry<int, int>> merged = new HashSet<Map__Entry<int, int>>();
            Map<int, Map__Entry<int, int>> lastCellForColumn = new HashMap<int, Map__Entry<int, int>>();
            {
                var rowIndex = 0;
                while (rowIndex < rows.size()) {
                    var row = (TableRow) rows.get(rowIndex);
                    var columnIndex = 0;
                    {
                        var cellIndex = 0;
                        while (cellIndex < (row.getChildren()).size()) {
                            var cell = (StatefulBodyXmlReader__UnmergedTableCell) (row.getChildren()).get(cellIndex);
                            var spanningCell = Maps.lookup(lastCellForColumn, columnIndex);
                            var position = Maps.entry(rowIndex, cellIndex);
                            if (cell._vmerge && spanningCell.isPresent()) {
                                rowspans.put(spanningCell.get(), (Maps.lookup(rowspans, spanningCell.get())).get() + 1);
                                merged.add(position);
                            }
                            else {
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
            return ReadResult.success(Lists.eagerMapWithIndex(rows, new StatefulBodyXmlReader__Anonymous_14(merged, rowspans)));
        }

        public Optional<string> checkTableRows(List<DocumentElement> rows)
        {
            {
                var _couscous_desugar_foreach_to_for2 = rows.iterator();
                while (_couscous_desugar_foreach_to_for2.hasNext()) {
                    var rowElement = _couscous_desugar_foreach_to_for2.next();
                    var row = Casts.tryCast<TableRow>(typeof(TableRow), rowElement);
                    if (!row.isPresent()) {
                        return Optional.of("unexpected non-row element in table, cell merging may be incorrect");
                    }

                    {
                        var _couscous_desugar_foreach_to_for1 = ((row.get()).getChildren()).iterator();
                        while (_couscous_desugar_foreach_to_for1.hasNext()) {
                            var cell = _couscous_desugar_foreach_to_for1.next();
                            if (!(cell is StatefulBodyXmlReader__UnmergedTableCell)) {
                                return Optional.of("unexpected non-cell element in table row, cell merging may be incorrect");
                            }
                        }
                    }
                }
            }
            return Optional.empty<string>();
        }

        public ReadResult readTableRow(XmlElement element)
        {
            var properties = element.findChildOrEmpty("w:trPr");
            var isHeader = properties.hasChild("w:tblHeader");
            return (readElements(element.getChildren())).map(new StatefulBodyXmlReader__Anonymous_15(isHeader));
        }

        public ReadResult readTableCell(XmlElement element)
        {
            var properties = element.findChildOrEmpty("w:tcPr");
            var gridSpan = (properties.findChildOrEmpty("w:gridSpan")).getAttributeOrNone("w:val");
            var colspan = (gridSpan.map(new StatefulBodyXmlReader__Anonymous_16())).orElse(1);
            return (readElements(element.getChildren())).map(new StatefulBodyXmlReader__Anonymous_17(this, properties, colspan));
        }

        public bool readVmerge(XmlElementLike properties)
        {
            return ((properties.findChild("w:vMerge")).map(new StatefulBodyXmlReader__Anonymous_19())).orElse(false);
        }

        public ReadResult readHyperlink(XmlElement element)
        {
            var relationshipId = element.getAttributeOrNone("r:id");
            var anchor = element.getAttributeOrNone("w:anchor");
            var targetFrame = (element.getAttributeOrNone("w:tgtFrame")).filter(new StatefulBodyXmlReader__Anonymous_20());
            var childrenResult = readElements(element.getChildren());
            if (relationshipId.isPresent()) {
                var targetHref = (_relationships).findTargetByRelationshipId(relationshipId.get());
                var href = (anchor.map(new StatefulBodyXmlReader__Anonymous_21(targetHref, anchor))).orElse(targetHref);
                return childrenResult.map(new StatefulBodyXmlReader__Anonymous_22(href, targetFrame));
            }

            if (anchor.isPresent()) {
                return childrenResult.map(new StatefulBodyXmlReader__Anonymous_23(anchor, targetFrame));
            }

            return childrenResult;
        }

        public ReadResult readBookmark(XmlElement element)
        {
            var name = element.getAttribute("w:name");
            if (name.Equals("_GoBack")) {
                return ReadResult._EMPTY_SUCCESS;
            }

            return ReadResult.success(new Bookmark(name));
        }

        public ReadResult readNoteReference(NoteType noteType, XmlElement element)
        {
            var noteId = element.getAttribute("w:id");
            return ReadResult.success(new NoteReference(noteType, noteId));
        }

        public ReadResult readCommentReference(XmlElement element)
        {
            var commentId = element.getAttribute("w:id");
            return ReadResult.success(new CommentReference(commentId));
        }

        public ReadResult readPict(XmlElement element)
        {
            return (readElements(element.getChildren())).toExtra();
        }

        public ReadResult readImagedata(XmlElement element)
        {
            return ((element.getAttributeOrNone("r:id")).map(new StatefulBodyXmlReader__Anonymous_25(element, this))).orElse(ReadResult.emptyWithWarning("A v:imagedata element without a relationship ID was ignored"));
        }

        public ReadResult readInline(XmlElement element)
        {
            var properties = element.findChildOrEmpty("wp:docPr");
            var altText = Optionals.first((properties.getAttributeOrNone("descr")).filter(new StatefulBodyXmlReader__Anonymous_26()), properties.getAttributeOrNone("title"));
            var blips = ((((element.findChildren("a:graphic")).findChildren("a:graphicData")).findChildren("pic:pic")).findChildren("pic:blipFill")).findChildren("a:blip");
            return readBlips(blips, altText);
        }

        public ReadResult readBlips(XmlElementList blips, Optional<string> altText)
        {
            return ReadResult.flatMap(blips, new StatefulBodyXmlReader__Anonymous_27(this, altText));
        }

        public ReadResult readBlip(XmlElement blip, Optional<string> altText)
        {
            var embedRelationshipId = blip.getAttributeOrNone("r:embed");
            var linkRelationshipId = blip.getAttributeOrNone("r:link");
            if (embedRelationshipId.isPresent()) {
                var imagePath = relationshipIdToDocxPath(embedRelationshipId.get());
                return readImage(imagePath, altText, new StatefulBodyXmlReader__Anonymous_28(this, imagePath));
            }

            if (linkRelationshipId.isPresent()) {
                var imagePath = (_relationships).findTargetByRelationshipId(linkRelationshipId.get());
                return readImage(imagePath, altText, new StatefulBodyXmlReader__Anonymous_29(this, imagePath));
            }

            return ReadResult._EMPTY_SUCCESS;
        }

        public ReadResult readImage(string imagePath, Optional<string> altText, InputStreamSupplier open)
        {
            var contentType = (_contentTypes).findContentType(imagePath);
            var image = new Image(altText, contentType, open);
            var contentTypeString = contentType.orElse("(unknown)");
            if ((_IMAGE_TYPES_SUPPORTED_BY_BROWSERS).contains(contentTypeString)) {
                return ReadResult.success(image);
            }

            return ReadResult.withWarning(image, ("Image of type " + contentTypeString) + " is unlikely to display in web browsers");
        }

        public ReadResult readSdt(XmlElement element)
        {
            return readElements((element.findChildOrEmpty("w:sdtContent")).getChildren());
        }

        public string relationshipIdToDocxPath(string relationshipId)
        {
            var target = (_relationships).findTargetByRelationshipId(relationshipId);
            return Uris.uriToZipEntryName("word", target);
        }

        public Optional<string> readVal(XmlElementLike element, string name)
        {
            return (element.findChildOrEmpty(name)).getAttributeOrNone("w:val");
        }
    }
}
