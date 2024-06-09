using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ContentTypesXmlAnonymous0 : IFunction<XmlElement, IMapEntry<string, string>> {
        public IMapEntry<string, string> Apply(XmlElement arg0)
        {
            return ContentTypesXml.ReadDefault(arg0);
        }
    }
}
