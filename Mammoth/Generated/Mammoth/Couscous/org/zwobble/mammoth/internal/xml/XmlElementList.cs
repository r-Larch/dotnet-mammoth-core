using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElementList(IList<XmlElement> elements) : ITerable<XmlElement> {
        public ITerator<XmlElement> Iterator()
        {
            return elements.Iterator();
        }

        public XmlElementList FindChildren(string name)
        {
            return new XmlElementList(Lists.EagerFlatMap(elements, new XmlElementListAnonymous0(name)));
        }
    }
}
