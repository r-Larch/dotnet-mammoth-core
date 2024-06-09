namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NumberingXml__Anonymous_2 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>> {
        internal Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> _abstractNums;
        internal NumberingXml__Anonymous_2(Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> abstractNums) {
            this._abstractNums = abstractNums;
        }
        public Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement numElement) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml.readNum(numElement, this._abstractNums);
        }
    }
}

