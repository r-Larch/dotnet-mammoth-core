using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NumberingXmlAnonymous2 : IFunction<XmlElement, IMapEntry<string, IMap<string, NumberingLevel>>> {
        private IMap<string, IMap<string, NumberingLevel>> _abstractNums;

        internal NumberingXmlAnonymous2(IMap<string, IMap<string, NumberingLevel>> abstractNums)
        {
            _abstractNums = abstractNums;
        }

        public IMapEntry<string, IMap<string, NumberingLevel>> Apply(XmlElement numElement)
        {
            return NumberingXml.ReadNum(numElement, _abstractNums);
        }
    }
}
