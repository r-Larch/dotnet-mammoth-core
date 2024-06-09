using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal static class DocumentReaderAnonymous17 {
    }
}

namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReaderAnonymous17<T> : IFunction<XmlElement, T> {
        private BodyXmlReader _bodyReader;
        private IBiFunction<XmlElement, BodyXmlReader, T> _readPart;

        internal DocumentReaderAnonymous17(IBiFunction<XmlElement, BodyXmlReader, T> readPart, BodyXmlReader bodyReader)
        {
            _readPart = readPart;
            _bodyReader = bodyReader;
        }

        public T Apply(XmlElement root)
        {
            return (_readPart).Apply(root, _bodyReader);
        }
    }
}
