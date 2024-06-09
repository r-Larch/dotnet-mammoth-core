namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NumberingXml {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering readNumberingXmlElement(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> abstractNums = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml.readAbstractNums(element.findChildren("w:abstractNum"));
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.Numbering(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml.readNums(element.findChildren("w:num"), abstractNums));
        }
        public static Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> readAbstractNums(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList children) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>(children, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml__Anonymous_0());
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> readAbstractNum(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string abstractNumId = element.getAttribute("w:abstractNumId");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>(abstractNumId, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml.readAbstractNumLevels(element));
        }
        public static Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> readAbstractNumLevels(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(element.findChildren("w:lvl"), new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml__Anonymous_1());
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel> readAbstractNumLevel(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            string levelIndex = element.getAttribute("w:ilvl");
            Mammoth.Couscous.java.util.Optional<string> numFmt = (element.findChildOrEmpty("w:numFmt")).getAttributeOrNone("w:val");
            bool isOrdered = !numFmt.equals(Mammoth.Couscous.java.util.Optional.of<string>("bullet"));
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>(levelIndex, new Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel(levelIndex, isOrdered));
        }
        public static Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> readNums(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList numElements, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> abstractNums) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.toMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>(numElements, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.NumberingXml__Anonymous_2(abstractNums));
        }
        public static Mammoth.Couscous.java.util.Map__Entry<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> readNum(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement numElement, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>> abstractNums) {
            string numId = numElement.getAttribute("w:numId");
            string abstractNumId = ((numElement.findChild("w:abstractNumId")).get()).getAttribute("w:val");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.entry<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>(numId, (Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, Mammoth.Couscous.java.util.Map<string, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NumberingLevel>>(abstractNums, abstractNumId)).get());
        }
    }
}

