using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StylesXmlAnonymous1 : IFunction<XmlElement, IMapEntry<string, Style>> {
        public IMapEntry<string, Style> Apply(XmlElement arg0)
        {
            return StylesXml.ReadStyle(arg0);
        }
    }
}
