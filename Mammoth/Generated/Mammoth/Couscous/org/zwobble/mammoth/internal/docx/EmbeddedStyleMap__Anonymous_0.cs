using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class EmbeddedStyleMapAnonymous0 : IFunction<INputStream, string> {
        public string Apply(INputStream arg0)
        {
            return Streams.ToString(arg0);
        }
    }

    internal class EmbeddedStyleMapAnonymous1(XmlElement element, string identifyingAttribute) : IFunction<XmlElement, bool> {
        public bool Apply(XmlElement childElement)
        {
            return childElement.GetName().Equals(element.GetName()) && childElement.GetAttributeOrNone(identifyingAttribute).Equals(element.GetAttributeOrNone(identifyingAttribute));
        }
    }

    internal class EmbeddedStyleMapAnonymous2(XmlElement element, string identifyingAttribute) : IPredicate<IXmlNode> {
        public bool Test(IXmlNode child)
        {
            return Casts.TryCast<XmlElement>(typeof(XmlElement), child).Map(new EmbeddedStyleMapAnonymous1(element, identifyingAttribute)).OrElse(false);
        }
    }
}
