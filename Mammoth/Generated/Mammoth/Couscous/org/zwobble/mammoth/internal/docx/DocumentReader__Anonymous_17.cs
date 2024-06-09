using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal static class DocumentReader__Anonymous_17 {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_17<T> : Function<XmlElement, T> {
        internal BodyXmlReader _bodyReader;
        internal BiFunction<XmlElement, BodyXmlReader, T> _readPart;

        internal DocumentReader__Anonymous_17(BiFunction<XmlElement, BodyXmlReader, T> readPart, BodyXmlReader bodyReader)
        {
            _readPart = readPart;
            _bodyReader = bodyReader;
        }

        public T apply(XmlElement root)
        {
            return (_readPart).apply(root, _bodyReader);
        }
    }
}
