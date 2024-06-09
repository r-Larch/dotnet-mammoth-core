namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal static class DocumentReader__Anonymous_17 {
    }
}
namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_17<T> : Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, T> {
        internal Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader, T> _readPart;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader _bodyReader;
        internal DocumentReader__Anonymous_17(Mammoth.Couscous.java.util.function.BiFunction<Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader, T> readPart, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.BodyXmlReader bodyReader) {
            this._readPart = readPart;
            this._bodyReader = bodyReader;
        }
        public T apply(Mammoth.Couscous.org.zwobble.mammoth.@internal.xml.XmlElement root) {
            return (this._readPart).apply(root, this._bodyReader);
        }
    }
}

