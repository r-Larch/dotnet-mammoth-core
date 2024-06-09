namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_19 : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, bool> {
        public bool apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement element) {
            return ((element.getAttributeOrNone("w:val")).map<bool>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader__Anonymous_18())).orElse(true);
        }
    }
}

