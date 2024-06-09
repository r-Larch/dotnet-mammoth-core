namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlTextNode : Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode {
        internal string _value;
        internal HtmlTextNode(string value) {
            this._value = value;
        }
        public string getValue() {
            return this._value;
        }
        public void accept(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Visitor visitor) {
            visitor.visit(this);
        }
        public T accept<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode__Mapper<T> visitor) {
            return visitor.visit(this);
        }
    }
}

