namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_3 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, bool> {
        public bool apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement child) {
            return ((child.getAttributeOrNone("w:val")).map<bool>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_2())).orElse(true);
        }
    }
}

