using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElementAnonymous2 : IPredicate<XmlElement> {
        private string _name;

        internal XmlElementAnonymous2(string name)
        {
            _name = name;
        }

        public bool Test(XmlElement child)
        {
            return (child.GetName()).Equals(_name);
        }
    }
}
