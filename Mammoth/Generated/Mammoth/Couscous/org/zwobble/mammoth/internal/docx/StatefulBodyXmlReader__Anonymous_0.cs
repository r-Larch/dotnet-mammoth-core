using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReaderAnonymous0(StatefulBodyXmlReader reader, IXmlElementLike properties) : IBiFunction<IOptional<Style>, IList<IDocumentElement>, IDocumentElement> {
        public IDocumentElement Apply(IOptional<Style> style, IList<IDocumentElement> children)
        {
            var hyperlinkHref = reader.CurrentHyperlinkHref();
            if (hyperlinkHref.IsPresent()) {
                children = Lists.List<IDocumentElement>(Hyperlink.Href(hyperlinkHref.Get(), Optional.Empty<string>(), children));
            }

            return new Run(reader.IsBold(properties), reader.IsItalic(properties), reader.IsUnderline(properties), reader.IsStrikethrough(properties), reader.IsSmallCaps(properties), reader.ReadVerticalAlignment(properties), style, children);
        }
    }

    internal class StatefulBodyXmlReaderAnonymous1 : IFunction<StatefulBodyXmlReaderHyperlinkComplexField, string> {
        public string Apply(StatefulBodyXmlReaderHyperlinkComplexField field)
        {
            return field.Href;
        }
    }

    internal class StatefulBodyXmlReaderAnonymous10(StatefulBodyXmlReader reader) : IBiFunction<string, string, IOptional<NumberingLevel>> {
        public IOptional<NumberingLevel> Apply(string arg0, string arg1)
        {
            return reader.Numbering.FindLevel(arg0, arg1);
        }
    }

    internal class StatefulBodyXmlReaderAnonymous11(StatefulBodyXmlReader reader) : IFunction<IList<IDocumentElement>, ReadResult> {
        public ReadResult Apply(IList<IDocumentElement> arg0)
        {
            return reader.CalculateRowspans(arg0);
        }
    }

    internal class StatefulBodyXmlReaderAnonymous12 : IBiFunction<IOptional<Style>, IList<IDocumentElement>, IDocumentElement> {
        public IDocumentElement Apply(IOptional<Style> arg0, IList<IDocumentElement> arg1)
        {
            return new Table(arg0, arg1);
        }
    }

    internal class StatefulBodyXmlReaderAnonymous13(StatefulBodyXmlReader reader) : IFunction<string, IOptional<Style>> {
        public IOptional<Style> Apply(string arg0)
        {
            return reader.Styles.FindTableStyleById(arg0);
        }
    }

    internal class StatefulBodyXmlReaderAnonymous14(ISet<IMapEntry<int, int>> merged, IMap<IMapEntry<int, int>, int> rowspans) : IBiFunction<int, IDocumentElement, IDocumentElement> {
        public IDocumentElement Apply(int rowIndex, IDocumentElement rowElement)
        {
            var row = (TableRow) rowElement;
            IList<IDocumentElement> mergedCells = new ArrayList<IDocumentElement>();
            {
                var cellIndex = 0;
                while (cellIndex < row.GetChildren().Size()) {
                    var cell = (StatefulBodyXmlReaderUnmergedTableCell) row.GetChildren().Get(cellIndex);
                    var position = Maps.Entry(rowIndex, cellIndex);
                    if (!merged.Contains(position)) {
                        mergedCells.Add(new TableCell(Maps.Lookup(rowspans, position).Get(), cell.Colspan, cell.Children));
                    }

                    cellIndex += 1;
                }
            }
            return new TableRow(mergedCells, row.IsHeader());
        }
    }

    internal class StatefulBodyXmlReaderAnonymous15(bool isHeader) : IFunction<IList<IDocumentElement>, IDocumentElement> {
        public IDocumentElement Apply(IList<IDocumentElement> children)
        {
            return new TableRow(children, isHeader);
        }
    }

    internal class StatefulBodyXmlReaderAnonymous16 : IFunction<string, int> {
        public int Apply(string arg0)
        {
            return int.Parse(arg0);
        }
    }

    internal class StatefulBodyXmlReaderAnonymous17(StatefulBodyXmlReader reader, IXmlElementLike properties, int colspan) : IFunction<IList<IDocumentElement>, IDocumentElement> {
        public IDocumentElement Apply(IList<IDocumentElement> children)
        {
            return new StatefulBodyXmlReaderUnmergedTableCell(reader.ReadVmerge(properties), colspan, children);
        }
    }

    internal class StatefulBodyXmlReaderAnonymous18 : IFunction<string, bool> {
        public bool Apply(string val)
        {
            return val.Equals("continue");
        }
    }

    internal class StatefulBodyXmlReaderAnonymous19 : IFunction<XmlElement, bool> {
        public bool Apply(XmlElement element)
        {
            return element.GetAttributeOrNone("w:val").Map(new StatefulBodyXmlReaderAnonymous18()).OrElse(true);
        }
    }

    internal class StatefulBodyXmlReaderAnonymous2 : IFunction<string, bool> {
        public bool Apply(string value)
        {
            return !value.Equals("false") && !value.Equals("0");
        }
    }

    internal class StatefulBodyXmlReaderAnonymous20 : IPredicate<string> {
        public bool Test(string value)
        {
            return !value.IsEmpty();
        }
    }

    internal class StatefulBodyXmlReaderAnonymous21(string targetHref, IOptional<string> anchor) : IFunction<string, string> {
        public string Apply(string fragment)
        {
            return Uris.ReplaceFragment(targetHref, anchor.Get());
        }
    }

    internal class StatefulBodyXmlReaderAnonymous22(string href, IOptional<string> targetFrame) : IFunction<IList<IDocumentElement>, IDocumentElement> {
        public IDocumentElement Apply(IList<IDocumentElement> children)
        {
            return Hyperlink.Href(href, targetFrame, children);
        }
    }

    internal class StatefulBodyXmlReaderAnonymous23(IOptional<string> anchor, IOptional<string> targetFrame) : IFunction<IList<IDocumentElement>, IDocumentElement> {
        public IDocumentElement Apply(IList<IDocumentElement> children)
        {
            return Hyperlink.Anchor(anchor.Get(), targetFrame, children);
        }
    }

    internal class StatefulBodyXmlReaderAnonymous24(StatefulBodyXmlReader reader, string imagePath) : IInputStreamSupplier {
        public INputStream Open()
        {
            return Archives.GetInputStream(reader.File, imagePath);
        }
    }

    internal class StatefulBodyXmlReaderAnonymous25(XmlElement element, StatefulBodyXmlReader reader) : IFunction<string, ReadResult> {
        public ReadResult Apply(string relationshipId)
        {
            var title = element.GetAttributeOrNone("o:title");
            var imagePath = reader.RelationshipIdToDocxPath(relationshipId);
            return reader.ReadImage(imagePath, title, new StatefulBodyXmlReaderAnonymous24(reader, imagePath));
        }
    }

    internal class StatefulBodyXmlReaderAnonymous26 : IPredicate<string> {
        public bool Test(string description)
        {
            return !JavaStringExtensions.Trim(description).IsEmpty();
        }
    }

    internal class StatefulBodyXmlReaderAnonymous27(StatefulBodyXmlReader reader, IOptional<string> altText) : IFunction<XmlElement, ReadResult> {
        public ReadResult Apply(XmlElement blip)
        {
            return reader.ReadBlip(blip, altText);
        }
    }

    internal class StatefulBodyXmlReaderAnonymous28(StatefulBodyXmlReader reader, string imagePath) : IInputStreamSupplier {
        public INputStream Open()
        {
            return Archives.GetInputStream(reader.File, imagePath);
        }
    }

    internal class StatefulBodyXmlReaderAnonymous29(StatefulBodyXmlReader reader, string imagePath) : IInputStreamSupplier {
        public INputStream Open()
        {
            return reader.FileReader.GetInputStream(imagePath);
        }
    }

    internal class StatefulBodyXmlReaderAnonymous3 : IFunction<XmlElement, bool> {
        public bool Apply(XmlElement child)
        {
            return child.GetAttributeOrNone("w:val").Map(new StatefulBodyXmlReaderAnonymous2()).OrElse(true);
        }
    }

    internal class StatefulBodyXmlReaderAnonymous30 : IStatefulBodyXmlReaderComplexField {
    }

    internal class StatefulBodyXmlReaderAnonymous4(StatefulBodyXmlReader reader) : IFunction<string, IOptional<Style>> {
        public IOptional<Style> Apply(string arg0)
        {
            return reader.Styles.FindCharacterStyleById(arg0);
        }
    }

    internal class StatefulBodyXmlReaderAnonymous5(StatefulBodyXmlReader reader) : IFunction<XmlElement, ReadResult> {
        public ReadResult Apply(XmlElement arg0)
        {
            return reader.ReadElement(arg0);
        }
    }

    internal class StatefulBodyXmlReaderAnonymous6(IOptional<NumberingLevel> numbering, ParagraphIndent indent) : IBiFunction<IOptional<Style>, IList<IDocumentElement>, IDocumentElement> {
        public IDocumentElement Apply(IOptional<Style> style, IList<IDocumentElement> children)
        {
            return new Paragraph(style, numbering, indent, children);
        }
    }

    internal class StatefulBodyXmlReaderAnonymous7 : IFunction<string, IStatefulBodyXmlReaderComplexField> {
        public IStatefulBodyXmlReaderComplexField Apply(string href)
        {
            return StatefulBodyXmlReaderComplexFieldStatic.Hyperlink(href);
        }
    }

    internal interface IStatefulBodyXmlReaderComplexField {
    }

    internal class StatefulBodyXmlReaderAnonymous8(StatefulBodyXmlReader reader) : IFunction<string, IOptional<Style>> {
        public IOptional<Style> Apply(string arg0)
        {
            return reader.Styles.FindParagraphStyleById(arg0);
        }
    }

    internal class StatefulBodyXmlReaderAnonymous9(StatefulBodyXmlReader reader, string styleType, IFunction<string, IOptional<Style>> findStyleById) : IFunction<string, InternalResult<IOptional<Style>>> {
        public InternalResult<IOptional<Style>> Apply(string styleId)
        {
            return reader.FindStyleById(styleType, styleId, findStyleById);
        }
    }

    internal class StatefulBodyXmlReaderComplexFieldStatic {
        internal static IStatefulBodyXmlReaderComplexField Unknown = new StatefulBodyXmlReaderAnonymous30();

        public static IStatefulBodyXmlReaderComplexField Hyperlink(string href)
        {
            return new StatefulBodyXmlReaderHyperlinkComplexField(href);
        }
    }

    internal class StatefulBodyXmlReaderHyperlinkComplexField : IStatefulBodyXmlReaderComplexField {
        public string Href;

        internal StatefulBodyXmlReaderHyperlinkComplexField(string href)
        {
            Href = href;
        }
    }

    internal class StatefulBodyXmlReaderUnmergedTableCell(bool vmerge, int colspan, IList<IDocumentElement> children) : IDocumentElement {
        public IList<IDocumentElement> Children = children;
        public int Colspan = colspan;
        public bool Vmerge = vmerge;

        public T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context)
        {
            return visitor.Visit(new TableCell(1, Colspan, Children), context);
        }
    }
}
