using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElementList : Iterable<XmlElement> {
        private List<XmlElement> _elements;

        internal XmlElementList(List<XmlElement> elements)
        {
            _elements = elements;
        }

        public Iterator<XmlElement> iterator()
        {
            return (_elements).iterator();
        }

        public XmlElementList findChildren(string name)
        {
            return new XmlElementList(Lists.eagerFlatMap(_elements, new XmlElementList__Anonymous_0(name)));
        }
    }
}
