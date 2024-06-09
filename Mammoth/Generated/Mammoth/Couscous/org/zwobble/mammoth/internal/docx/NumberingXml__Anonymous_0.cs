using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class NumberingXmlAnonymous0 : IFunction<XmlElement, IMapEntry<string, IMap<string, NumberingLevel>>> {
        public IMapEntry<string, IMap<string, NumberingLevel>> Apply(XmlElement arg0)
        {
            return NumberingXml.ReadAbstractNum(arg0);
        }
    }
}
