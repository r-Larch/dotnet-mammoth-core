using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NumberingXml__Anonymous_2 : Function<XmlElement, Map__Entry<string, Map<string, NumberingLevel>>> {
        internal Map<string, Map<string, NumberingLevel>> _abstractNums;

        internal NumberingXml__Anonymous_2(Map<string, Map<string, NumberingLevel>> abstractNums)
        {
            _abstractNums = abstractNums;
        }

        public Map__Entry<string, Map<string, NumberingLevel>> apply(XmlElement numElement)
        {
            return NumberingXml.readNum(numElement, _abstractNums);
        }
    }
}
