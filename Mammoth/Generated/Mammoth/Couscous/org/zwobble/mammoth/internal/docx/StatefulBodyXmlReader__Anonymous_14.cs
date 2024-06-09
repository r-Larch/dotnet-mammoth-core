using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReaderAnonymous14 : IBiFunction<int, IDocumentElement, IDocumentElement> {
        private ISet<IMapEntry<int, int>> _merged;
        private IMap<IMapEntry<int, int>, int> _rowspans;

        internal StatefulBodyXmlReaderAnonymous14(ISet<IMapEntry<int, int>> merged, IMap<IMapEntry<int, int>, int> rowspans)
        {
            _merged = merged;
            _rowspans = rowspans;
        }

        public IDocumentElement Apply(int rowIndex, IDocumentElement rowElement)
        {
            var row = (TableRow) rowElement;
            IList<IDocumentElement> mergedCells = new ArrayList<IDocumentElement>();
            {
                var cellIndex = 0;
                while (cellIndex < (row.GetChildren()).Size()) {
                    var cell = (StatefulBodyXmlReaderUnmergedTableCell) (row.GetChildren()).Get(cellIndex);
                    var position = Maps.Entry(rowIndex, cellIndex);
                    if (!(_merged).Contains(position)) {
                        mergedCells.Add(new TableCell((Maps.Lookup(_rowspans, position)).Get(), cell.Colspan, cell.Children));
                    }

                    cellIndex = cellIndex + 1;
                }
            }
            return new TableRow(mergedCells, row.IsHeader());
        }
    }
}
