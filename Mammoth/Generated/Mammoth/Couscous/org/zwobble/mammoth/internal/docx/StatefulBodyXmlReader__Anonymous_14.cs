namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_14 : Mammoth.Couscous.java.util.function.BiFunction<int, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> {
        internal Mammoth.Couscous.java.util.Set<Mammoth.Couscous.java.util.Map__Entry<int, int>> _merged;
        internal Mammoth.Couscous.java.util.Map<Mammoth.Couscous.java.util.Map__Entry<int, int>, int> _rowspans;
        internal StatefulBodyXmlReader__Anonymous_14(Mammoth.Couscous.java.util.Set<Mammoth.Couscous.java.util.Map__Entry<int, int>> merged, Mammoth.Couscous.java.util.Map<Mammoth.Couscous.java.util.Map__Entry<int, int>, int> rowspans) {
            this._merged = merged;
            this._rowspans = rowspans;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement apply(int rowIndex, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement rowElement) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow row = (Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow) rowElement;
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> mergedCells = new Mammoth.Couscous.java.util.ArrayList<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>();
             {
                int cellIndex = 0;
                while (cellIndex < (row.getChildren()).size()) {
                    Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__UnmergedTableCell cell = (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__UnmergedTableCell) (row.getChildren()).get(cellIndex);
                    Mammoth.Couscous.java.util.Map__Entry<int, int> position = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<int, int>(rowIndex, cellIndex);
                    if (!(this._merged).contains(position)) {
                        mergedCells.add(new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableCell((Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<Mammoth.Couscous.java.util.Map__Entry<int, int>, int>(this._rowspans, position)).get(), cell._colspan, cell._children));
                    }
                    cellIndex = cellIndex + 1;
                }
            }
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow(mergedCells, row.isHeader());
        }
    }
}

