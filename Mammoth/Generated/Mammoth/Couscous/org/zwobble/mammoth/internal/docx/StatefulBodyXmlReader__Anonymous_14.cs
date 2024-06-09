using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_14 : BiFunction<int, DocumentElement, DocumentElement> {
        internal Set<Map__Entry<int, int>> _merged;
        internal Map<Map__Entry<int, int>, int> _rowspans;

        internal StatefulBodyXmlReader__Anonymous_14(Set<Map__Entry<int, int>> merged, Map<Map__Entry<int, int>, int> rowspans)
        {
            _merged = merged;
            _rowspans = rowspans;
        }

        public DocumentElement apply(int rowIndex, DocumentElement rowElement)
        {
            var row = (TableRow) rowElement;
            List<DocumentElement> mergedCells = new ArrayList<DocumentElement>();
            {
                var cellIndex = 0;
                while (cellIndex < (row.getChildren()).size()) {
                    var cell = (StatefulBodyXmlReader__UnmergedTableCell) (row.getChildren()).get(cellIndex);
                    var position = Maps.entry(rowIndex, cellIndex);
                    if (!(_merged).contains(position)) {
                        mergedCells.add(new TableCell((Maps.lookup(_rowspans, position)).get(), cell._colspan, cell._children));
                    }

                    cellIndex = cellIndex + 1;
                }
            }
            return new TableRow(mergedCells, row.isHeader());
        }
    }
}
