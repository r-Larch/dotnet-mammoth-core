using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElementList : ITerable<XmlElement> {
        private IList<XmlElement> _elements;

        internal XmlElementList(IList<XmlElement> elements)
        {
            _elements = elements;
        }

        public ITerator<XmlElement> Iterator()
        {
            return (_elements).Iterator();
        }

        public XmlElementList FindChildren(string name)
        {
            return new XmlElementList(Lists.EagerFlatMap(_elements, new XmlElementListAnonymous0(name)));
        }
    }
}
