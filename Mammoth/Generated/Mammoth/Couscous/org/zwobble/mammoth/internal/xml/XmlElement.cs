namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.xml {
    internal class XmlElement : Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike {
        internal string _name;
        internal Mammoth.Couscous.java.util.Map<string, string> _attributes;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> _children;
        internal XmlElement(string name, Mammoth.Couscous.java.util.Map<string, string> attributes, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> children) {
            this._name = name;
            this._attributes = attributes;
            this._children = children;
        }
        public string getName() {
            return this._name;
        }
        public Mammoth.Couscous.java.util.Map<string, string> getAttributes() {
            return this._attributes;
        }
        public string getAttribute(string name) {
            return (this.getAttributeOrNone(name)).orElseThrow<Mammoth.Couscous.java.lang.RuntimeException>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement__Anonymous_0(name));
        }
        public Mammoth.Couscous.java.util.Optional<string> getAttributeOrNone(string name) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Maps.lookup<string, string>(this._attributes, name);
        }
        public string innerText() {
            return java.lang.String.join("", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode, string>(this._children, new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement__Anonymous_1()));
        }
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNodeVisitor<T> visitor) {
            return visitor.visit(this);
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode> getChildren() {
            return this._children;
        }
        public string toString() {
            return ((((("XmlElement(name=" + this._name) + ", attributes=") + this._attributes) + ", children=") + this._children) + ")";
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList findChildren(string name) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementList(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.toList<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(this.findChildrenIterable(name)));
        }
        public Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> findChild(string name) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.getFirst<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(this.findChildrenIterable(name));
        }
        public bool hasChild(string name) {
            return ((this.findChildrenIterable(name)).iterator()).hasNext();
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike findChildOrEmpty(string name) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.getFirst<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElementLike>(this.findChildrenIterable(name), Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.NullXmlElement._INSTANCE);
        }
        public Mammoth.Couscous.java.lang.Iterable<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement> findChildrenIterable(string name) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFilter<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFilter<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlNode, Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement>(this._children, typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement)), new Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement__Anonymous_2(name));
        }
    }
}

