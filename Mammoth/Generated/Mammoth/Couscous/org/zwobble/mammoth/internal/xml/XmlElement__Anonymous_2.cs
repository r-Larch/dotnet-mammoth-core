using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElement__Anonymous_2 : Predicate<XmlElement> {
        private string _name;

        internal XmlElement__Anonymous_2(string name)
        {
            _name = name;
        }

        public bool test(XmlElement child)
        {
            return (child.getName()).Equals(_name);
        }
    }
}
