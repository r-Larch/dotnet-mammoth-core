using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElementListAnonymous0 : IFunction<XmlElement, ITerable<XmlElement>> {
        private string _name;

        internal XmlElementListAnonymous0(string name)
        {
            _name = name;
        }

        public ITerable<XmlElement> Apply(XmlElement element)
        {
            return element.FindChildren(_name);
        }
    }
}
