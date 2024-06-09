using Mammoth.Couscous.java.io;
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
    internal class StatefulBodyXmlReader(
        Styles styles,
        Numbering numbering,
        Relationships relationships,
        ContentTypes contentTypes,
        IArchive file,
        IFileReader fileReader
    ) {
        private static readonly ISet<string> ImageTypesSupportedByBrowsers = Sets.Set(["image/png", "image/gif", "image/jpeg", "image/svg+xml", "image/tiff"]);
        private readonly IQueue<IStatefulBodyXmlReaderComplexField> _complexFieldStack = Queues.Stack<IStatefulBodyXmlReaderComplexField>();
        private readonly StringBuilder _currentInstrText = new();
        public IArchive File = file;
        public IFileReader FileReader = fileReader;
        public Numbering Numbering = numbering;
        public Styles Styles = styles;


        public ReadResult ReadElement(XmlElement element)
        {
            switch (element.GetName()) {
                case "w:t":
                    return ReadResult.Success(new Text(element.InnerText()));
                case "w:r":
                    return ReadRun(element);
                case "w:p":
                    return ReadParagraph(element);
                case "w:fldChar":
                    return ReadFieldChar(element);
                case "w:instrText":
                    return ReadInstrText(element);
                case "w:tab":
                    return ReadResult.Success(Tab.Instance);
                case "w:noBreakHyphen":
                    return ReadResult.Success(new Text("‑"));
                case "w:br":
                    return ReadBreak(element);
                case "w:tbl":
                    return ReadTable(element);
                case "w:tr":
                    return ReadTableRow(element);
                case "w:tc":
                    return ReadTableCell(element);
                case "w:hyperlink":
                    return ReadHyperlink(element);
                case "w:bookmarkStart":
                    return ReadBookmark(element);
                case "w:footnoteReference":
                    return ReadNoteReference(NoteType.Footnote, element);
                case "w:endnoteReference":
                    return ReadNoteReference(NoteType.Endnote, element);
                case "w:commentReference":
                    return ReadCommentReference(element);
                case "w:pict":
                    return ReadPict(element);
                case "v:imagedata":
                    return ReadImagedata(element);
                case "wp:inline":
                case "wp:anchor":
                    return ReadInline(element);
                case "w:sdt":
                    return ReadSdt(element);
                case "w:ins":
                case "w:object":
                case "w:smartTag":
                case "w:drawing":
                case "v:group":
                case "v:roundrect":
                case "v:shape":
                case "v:textbox":
                case "w:txbxContent":
                    return ReadElements(element.GetChildren());
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
                    return ReadResult.EmptySuccess;
                default:
                    var warning = $"An unrecognised element was ignored: {element.GetName()}";
                    return ReadResult.EmptyWithWarning(warning);
            }
        }

        public ReadResult ReadRun(XmlElement element)
        {
            var properties = element.FindChildOrEmpty("w:rPr");
            return ReadResult.Map(ReadRunStyle(properties), ReadElements(element.GetChildren()), new StatefulBodyXmlReaderAnonymous0(this, properties));
        }

        public IOptional<string> CurrentHyperlinkHref()
        {
            return Iterables.TryGetLast(Iterables.LazyFilter<IStatefulBodyXmlReaderComplexField, StatefulBodyXmlReaderHyperlinkComplexField>(_complexFieldStack, typeof(StatefulBodyXmlReaderHyperlinkComplexField))).Map(new StatefulBodyXmlReaderAnonymous1());
        }

        public bool IsBold(IXmlElementLike properties)
        {
            return ReadBooleanElement(properties, "w:b");
        }

        public bool IsItalic(IXmlElementLike properties)
        {
            return ReadBooleanElement(properties, "w:i");
        }

        public bool IsUnderline(IXmlElementLike properties)
        {
            return ReadBooleanElement(properties, "w:u");
        }

        public bool IsStrikethrough(IXmlElementLike properties)
        {
            return ReadBooleanElement(properties, "w:strike");
        }

        public bool IsSmallCaps(IXmlElementLike properties)
        {
            return ReadBooleanElement(properties, "w:smallCaps");
        }

        public bool ReadBooleanElement(IXmlElementLike properties, string tagName)
        {
            return properties.FindChild(tagName).Map(new StatefulBodyXmlReaderAnonymous3()).OrElse(false);
        }

        public VerticalAlignment ReadVerticalAlignment(IXmlElementLike properties)
        {
            var verticalAlignment = ReadVal(properties, "w:vertAlign").OrElse("");
            return verticalAlignment switch {
                "superscript" => VerticalAlignment.Superscript,
                "subscript" => VerticalAlignment.Subscript,
                _ => VerticalAlignment.Baseline
            };
        }

        public InternalResult<IOptional<Style>> ReadRunStyle(IXmlElementLike properties)
        {
            return ReadStyle(properties, "w:rStyle", "Run", new StatefulBodyXmlReaderAnonymous4(this));
        }

        public ReadResult ReadElements(ITerable<IXmlNode> nodes)
        {
            return ReadResult.FlatMap(Iterables.LazyFilter<IXmlNode, XmlElement>(nodes, typeof(XmlElement)), new StatefulBodyXmlReaderAnonymous5(this));
        }

        public ReadResult ReadParagraph(XmlElement element)
        {
            var properties = element.FindChildOrEmpty("w:pPr");
            var numbering = ReadNumbering(properties);
            var indent = ReadParagraphIndent(properties);
            return ReadResult.Map(ReadParagraphStyle(properties), ReadElements(element.GetChildren()), new StatefulBodyXmlReaderAnonymous6(numbering, indent)).AppendExtra();
        }

        public ReadResult ReadFieldChar(XmlElement element)
        {
            var type = element.GetAttributeOrNone("w:fldCharType").OrElse("");
            if (type.Equals("begin")) {
                _complexFieldStack.Add(StatefulBodyXmlReaderComplexFieldStatic.Unknown);
                _currentInstrText.SetLength(0);
            }
            else if (type.Equals("end")) {
                _complexFieldStack.Remove();
            }
            else if (type.Equals("separate")) {
                var instrText = _currentInstrText.ToString();
                var complexField = ParseHyperlinkFieldCode(instrText).Map(new StatefulBodyXmlReaderAnonymous7()).OrElse(StatefulBodyXmlReaderComplexFieldStatic.Unknown);
                _complexFieldStack.Remove();
                _complexFieldStack.Add(complexField);
            }

            return ReadResult.EmptySuccess;
        }

        public ReadResult ReadInstrText(XmlElement element)
        {
            _currentInstrText.Append(element.InnerText());
            return ReadResult.EmptySuccess;
        }

        public IOptional<string> ParseHyperlinkFieldCode(string instrText)
        {
            var pattern = Pattern.Compile("\\s*HYPERLINK \"(.*)\"");
            var matcher = pattern.Matcher(instrText);
            if (matcher.LookingAt()) {
                return Optional.Of(matcher.Group(1));
            }

            return Optional.Empty<string>();
        }

        public InternalResult<IOptional<Style>> ReadParagraphStyle(IXmlElementLike properties)
        {
            return ReadStyle(properties, "w:pStyle", "Paragraph", new StatefulBodyXmlReaderAnonymous8(this));
        }

        public InternalResult<IOptional<Style>> ReadStyle(IXmlElementLike properties, string styleTagName, string styleType, IFunction<string, IOptional<Style>> findStyleById)
        {
            return ReadVal(properties, styleTagName).Map(new StatefulBodyXmlReaderAnonymous9(this, styleType, findStyleById)).OrElse(InternalResult.Empty());
        }

        public InternalResult<IOptional<Style>> FindStyleById(string styleType, string styleId, IFunction<string, IOptional<Style>> findStyleById)
        {
            var style = findStyleById.Apply(styleId);
            if (style.IsPresent()) {
                return InternalResult.Success(style);
            }

            return new InternalResult<IOptional<Style>>(Optional.Of(new Style(styleId, Optional.Empty<string>())), Lists.List($"{styleType} style with ID {styleId} was referenced but not defined in the document"));
        }

        public IOptional<NumberingLevel> ReadNumbering(IXmlElementLike properties)
        {
            var numberingProperties = properties.FindChildOrEmpty("w:numPr");
            return Optionals.FlatMap(ReadVal(numberingProperties, "w:numId"), ReadVal(numberingProperties, "w:ilvl"), new StatefulBodyXmlReaderAnonymous10(this));
        }

        public ParagraphIndent ReadParagraphIndent(IXmlElementLike properties)
        {
            var indent = properties.FindChildOrEmpty("w:ind");
            return new ParagraphIndent(Optionals.First(indent.GetAttributeOrNone("w:start"), indent.GetAttributeOrNone("w:left")), Optionals.First(indent.GetAttributeOrNone("w:end"), indent.GetAttributeOrNone("w:right")), indent.GetAttributeOrNone("w:firstLine"), indent.GetAttributeOrNone("w:hanging"));
        }

        public ReadResult ReadBreak(XmlElement element)
        {
            var breakType = element.GetAttributeOrNone("w:type").OrElse("textWrapping");
            return breakType switch {
                "textWrapping" => ReadResult.Success(Break.LineBreak),
                "page" => ReadResult.Success(Break.PageBreak),
                "column" => ReadResult.Success(Break.ColumnBreak),
                _ => ReadResult.EmptyWithWarning($"Unsupported break type: {breakType}")
            };
        }

        public ReadResult ReadTable(XmlElement element)
        {
            var properties = element.FindChildOrEmpty("w:tblPr");
            return ReadResult.Map(ReadTableStyle(properties), ReadElements(element.GetChildren()).FlatMap(new StatefulBodyXmlReaderAnonymous11(this)), new StatefulBodyXmlReaderAnonymous12());
        }

        public InternalResult<IOptional<Style>> ReadTableStyle(IXmlElementLike properties)
        {
            return ReadStyle(properties, "w:tblStyle", "Table", new StatefulBodyXmlReaderAnonymous13(this));
        }

        public ReadResult CalculateRowspans(IList<IDocumentElement> rows)
        {
            var error = CheckTableRows(rows);
            if (error.IsPresent()) {
                return ReadResult.WithWarning(rows, error.Get());
            }

            IMap<IMapEntry<int, int>, int> rowspans = new HashMap<IMapEntry<int, int>, int>();
            ISet<IMapEntry<int, int>> merged = new HashSet<IMapEntry<int, int>>();
            IMap<int, IMapEntry<int, int>> lastCellForColumn = new HashMap<int, IMapEntry<int, int>>();
            {
                var rowIndex = 0;
                while (rowIndex < rows.Size()) {
                    var row = (TableRow) rows.Get(rowIndex);
                    var columnIndex = 0;
                    {
                        var cellIndex = 0;
                        while (cellIndex < row.GetChildren().Size()) {
                            var cell = (StatefulBodyXmlReaderUnmergedTableCell) row.GetChildren().Get(cellIndex);
                            var spanningCell = Maps.Lookup(lastCellForColumn, columnIndex);
                            var position = Maps.Entry(rowIndex, cellIndex);
                            if (cell.Vmerge && spanningCell.IsPresent()) {
                                rowspans.Put(spanningCell.Get(), Maps.Lookup(rowspans, spanningCell.Get()).Get() + 1);
                                merged.Add(position);
                            }
                            else {
                                lastCellForColumn.Put(columnIndex, position);
                                rowspans.Put(position, 1);
                            }

                            columnIndex += cell.Colspan;
                            cellIndex += 1;
                        }
                    }
                    rowIndex += 1;
                }
            }
            return ReadResult.Success(Lists.EagerMapWithIndex(rows, new StatefulBodyXmlReaderAnonymous14(merged, rowspans)));
        }

        public IOptional<string> CheckTableRows(IList<IDocumentElement> rows)
        {
            {
                var couscousDesugarForeachToFor2 = rows.Iterator();
                while (couscousDesugarForeachToFor2.HasNext()) {
                    var rowElement = couscousDesugarForeachToFor2.Next();
                    var row = Casts.TryCast<TableRow>(typeof(TableRow), rowElement);
                    if (!row.IsPresent()) {
                        return Optional.Of("unexpected non-row element in table, cell merging may be incorrect");
                    }

                    {
                        var couscousDesugarForeachToFor1 = row.Get().GetChildren().Iterator();
                        while (couscousDesugarForeachToFor1.HasNext()) {
                            var cell = couscousDesugarForeachToFor1.Next();
                            if (!(cell is StatefulBodyXmlReaderUnmergedTableCell)) {
                                return Optional.Of("unexpected non-cell element in table row, cell merging may be incorrect");
                            }
                        }
                    }
                }
            }
            return Optional.Empty<string>();
        }

        public ReadResult ReadTableRow(XmlElement element)
        {
            var properties = element.FindChildOrEmpty("w:trPr");
            var isHeader = properties.HasChild("w:tblHeader");
            return ReadElements(element.GetChildren()).Map(new StatefulBodyXmlReaderAnonymous15(isHeader));
        }

        public ReadResult ReadTableCell(XmlElement element)
        {
            var properties = element.FindChildOrEmpty("w:tcPr");
            var gridSpan = properties.FindChildOrEmpty("w:gridSpan").GetAttributeOrNone("w:val");
            var colspan = gridSpan.Map(new StatefulBodyXmlReaderAnonymous16()).OrElse(1);
            return ReadElements(element.GetChildren()).Map(new StatefulBodyXmlReaderAnonymous17(this, properties, colspan));
        }

        public bool ReadVmerge(IXmlElementLike properties)
        {
            return properties.FindChild("w:vMerge").Map(new StatefulBodyXmlReaderAnonymous19()).OrElse(false);
        }

        public ReadResult ReadHyperlink(XmlElement element)
        {
            var relationshipId = element.GetAttributeOrNone("r:id");
            var anchor = element.GetAttributeOrNone("w:anchor");
            var targetFrame = element.GetAttributeOrNone("w:tgtFrame").Filter(new StatefulBodyXmlReaderAnonymous20());
            var childrenResult = ReadElements(element.GetChildren());
            if (relationshipId.IsPresent()) {
                var targetHref = relationships.FindTargetByRelationshipId(relationshipId.Get());
                var href = anchor.Map(new StatefulBodyXmlReaderAnonymous21(targetHref, anchor)).OrElse(targetHref);
                return childrenResult.Map(new StatefulBodyXmlReaderAnonymous22(href, targetFrame));
            }

            if (anchor.IsPresent()) {
                return childrenResult.Map(new StatefulBodyXmlReaderAnonymous23(anchor, targetFrame));
            }

            return childrenResult;
        }

        public ReadResult ReadBookmark(XmlElement element)
        {
            var name = element.GetAttribute("w:name");
            if (name.Equals("_GoBack")) {
                return ReadResult.EmptySuccess;
            }

            return ReadResult.Success(new Bookmark(name));
        }

        public ReadResult ReadNoteReference(NoteType noteType, XmlElement element)
        {
            var noteId = element.GetAttribute("w:id");
            return ReadResult.Success(new NoteReference(noteType, noteId));
        }

        public ReadResult ReadCommentReference(XmlElement element)
        {
            var commentId = element.GetAttribute("w:id");
            return ReadResult.Success(new CommentReference(commentId));
        }

        public ReadResult ReadPict(XmlElement element)
        {
            return ReadElements(element.GetChildren()).ToExtra();
        }

        public ReadResult ReadImagedata(XmlElement element)
        {
            return element.GetAttributeOrNone("r:id").Map(new StatefulBodyXmlReaderAnonymous25(element, this)).OrElse(ReadResult.EmptyWithWarning("A v:imagedata element without a relationship ID was ignored"));
        }

        public ReadResult ReadInline(XmlElement element)
        {
            var properties = element.FindChildOrEmpty("wp:docPr");
            var altText = Optionals.First(properties.GetAttributeOrNone("descr").Filter(new StatefulBodyXmlReaderAnonymous26()), properties.GetAttributeOrNone("title"));
            var blips = element.FindChildren("a:graphic").FindChildren("a:graphicData").FindChildren("pic:pic").FindChildren("pic:blipFill").FindChildren("a:blip");
            return ReadBlips(blips, altText);
        }

        public ReadResult ReadBlips(XmlElementList blips, IOptional<string> altText)
        {
            return ReadResult.FlatMap(blips, new StatefulBodyXmlReaderAnonymous27(this, altText));
        }

        public ReadResult ReadBlip(XmlElement blip, IOptional<string> altText)
        {
            var embedRelationshipId = blip.GetAttributeOrNone("r:embed");
            var linkRelationshipId = blip.GetAttributeOrNone("r:link");
            if (embedRelationshipId.IsPresent()) {
                var imagePath = RelationshipIdToDocxPath(embedRelationshipId.Get());
                return ReadImage(imagePath, altText, new StatefulBodyXmlReaderAnonymous28(this, imagePath));
            }

            if (linkRelationshipId.IsPresent()) {
                var imagePath = relationships.FindTargetByRelationshipId(linkRelationshipId.Get());
                return ReadImage(imagePath, altText, new StatefulBodyXmlReaderAnonymous29(this, imagePath));
            }

            return ReadResult.EmptySuccess;
        }

        public ReadResult ReadImage(string imagePath, IOptional<string> altText, IInputStreamSupplier open)
        {
            var contentType = contentTypes.FindContentType(imagePath);
            var image = new Image(altText, contentType, open);
            var contentTypeString = contentType.OrElse("(unknown)");
            if (ImageTypesSupportedByBrowsers.Contains(contentTypeString)) {
                return ReadResult.Success(image);
            }

            return ReadResult.WithWarning(image, $"Image of type {contentTypeString} is unlikely to display in web browsers");
        }

        public ReadResult ReadSdt(XmlElement element)
        {
            return ReadElements(element.FindChildOrEmpty("w:sdtContent").GetChildren());
        }

        public string RelationshipIdToDocxPath(string relationshipId)
        {
            var target = relationships.FindTargetByRelationshipId(relationshipId);
            return Uris.UriToZipEntryName("word", target);
        }

        public IOptional<string> ReadVal(IXmlElementLike element, string name)
        {
            return element.FindChildOrEmpty(name).GetAttributeOrNone("w:val");
        }
    }
}
