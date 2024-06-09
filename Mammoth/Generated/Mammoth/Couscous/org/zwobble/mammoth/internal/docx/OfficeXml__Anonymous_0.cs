using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class OfficeXmlAnonymous0 : IFunction<IXmlNode, ITerable<IXmlNode>> {
        public ITerable<IXmlNode> Apply(IXmlNode arg0)
        {
            return OfficeXml.CollapseAlternateContent(arg0);
        }
    }
}
