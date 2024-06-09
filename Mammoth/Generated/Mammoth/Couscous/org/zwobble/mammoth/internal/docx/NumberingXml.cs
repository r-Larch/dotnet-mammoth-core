using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NumberingXml {
        public static Numbering readNumberingXmlElement(XmlElement element)
        {
            var abstractNums = readAbstractNums(element.findChildren("w:abstractNum"));
            return new Numbering(readNums(element.findChildren("w:num"), abstractNums));
        }

        public static Map<string, Map<string, NumberingLevel>> readAbstractNums(XmlElementList children)
        {
            return Maps.toMap(children, new NumberingXml__Anonymous_0());
        }

        public static Map__Entry<string, Map<string, NumberingLevel>> readAbstractNum(XmlElement element)
        {
            var abstractNumId = element.getAttribute("w:abstractNumId");
            return Maps.entry(abstractNumId, readAbstractNumLevels(element));
        }

        public static Map<string, NumberingLevel> readAbstractNumLevels(XmlElement element)
        {
            return Maps.toMap(element.findChildren("w:lvl"), new NumberingXml__Anonymous_1());
        }

        public static Map__Entry<string, NumberingLevel> readAbstractNumLevel(XmlElement element)
        {
            var levelIndex = element.getAttribute("w:ilvl");
            var numFmt = (element.findChildOrEmpty("w:numFmt")).getAttributeOrNone("w:val");
            var isOrdered = !numFmt.equals(Optional.of("bullet"));
            return Maps.entry(levelIndex, new NumberingLevel(levelIndex, isOrdered));
        }

        public static Map<string, Map<string, NumberingLevel>> readNums(XmlElementList numElements, Map<string, Map<string, NumberingLevel>> abstractNums)
        {
            return Maps.toMap(numElements, new NumberingXml__Anonymous_2(abstractNums));
        }

        public static Map__Entry<string, Map<string, NumberingLevel>> readNum(XmlElement numElement, Map<string, Map<string, NumberingLevel>> abstractNums)
        {
            var numId = numElement.getAttribute("w:numId");
            var abstractNumId = ((numElement.findChild("w:abstractNumId")).get()).getAttribute("w:val");
            return Maps.entry(numId, (Maps.lookup(abstractNums, abstractNumId)).get());
        }
    }
}
