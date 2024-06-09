using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NumberingXml {
        public static Numbering ReadNumberingXmlElement(XmlElement element)
        {
            var abstractNums = ReadAbstractNums(element.FindChildren("w:abstractNum"));
            return new Numbering(ReadNums(element.FindChildren("w:num"), abstractNums));
        }

        public static IMap<string, IMap<string, NumberingLevel>> ReadAbstractNums(XmlElementList children)
        {
            return Maps.ToMap(children, new NumberingXmlAnonymous0());
        }

        public static IMapEntry<string, IMap<string, NumberingLevel>> ReadAbstractNum(XmlElement element)
        {
            var abstractNumId = element.GetAttribute("w:abstractNumId");
            return Maps.Entry(abstractNumId, ReadAbstractNumLevels(element));
        }

        public static IMap<string, NumberingLevel> ReadAbstractNumLevels(XmlElement element)
        {
            return Maps.ToMap(element.FindChildren("w:lvl"), new NumberingXmlAnonymous1());
        }

        public static IMapEntry<string, NumberingLevel> ReadAbstractNumLevel(XmlElement element)
        {
            var levelIndex = element.GetAttribute("w:ilvl");
            var numFmt = element.FindChildOrEmpty("w:numFmt").GetAttributeOrNone("w:val");
            var isOrdered = !numFmt.Equals(Optional.Of("bullet"));
            return Maps.Entry(levelIndex, new NumberingLevel(levelIndex, isOrdered));
        }

        public static IMap<string, IMap<string, NumberingLevel>> ReadNums(XmlElementList numElements, IMap<string, IMap<string, NumberingLevel>> abstractNums)
        {
            return Maps.ToMap(numElements, new NumberingXmlAnonymous2(abstractNums));
        }

        public static IMapEntry<string, IMap<string, NumberingLevel>> ReadNum(XmlElement numElement, IMap<string, IMap<string, NumberingLevel>> abstractNums)
        {
            var numId = numElement.GetAttribute("w:numId");
            var abstractNumId = numElement.FindChild("w:abstractNumId").Get().GetAttribute("w:val");
            return Maps.Entry(numId, Maps.Lookup(abstractNums, abstractNumId).Get());
        }
    }

    internal class NumberingXmlAnonymous0 : IFunction<XmlElement, IMapEntry<string, IMap<string, NumberingLevel>>> {
        public IMapEntry<string, IMap<string, NumberingLevel>> Apply(XmlElement arg0)
        {
            return NumberingXml.ReadAbstractNum(arg0);
        }
    }

    internal class NumberingXmlAnonymous1 : IFunction<XmlElement, IMapEntry<string, NumberingLevel>> {
        public IMapEntry<string, NumberingLevel> Apply(XmlElement arg0)
        {
            return NumberingXml.ReadAbstractNumLevel(arg0);
        }
    }

    internal class NumberingXmlAnonymous2(IMap<string, IMap<string, NumberingLevel>> abstractNums) : IFunction<XmlElement, IMapEntry<string, IMap<string, NumberingLevel>>> {
        public IMapEntry<string, IMap<string, NumberingLevel>> Apply(XmlElement numElement)
        {
            return NumberingXml.ReadNum(numElement, abstractNums);
        }
    }
}
