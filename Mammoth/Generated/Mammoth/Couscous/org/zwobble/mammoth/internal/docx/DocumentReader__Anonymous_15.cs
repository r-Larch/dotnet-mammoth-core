using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReaderAnonymous15 : ISupplierWithException<IOptional<XmlElement>, IoException> {
        private string _name;
        private IArchive _zipFile;

        internal DocumentReaderAnonymous15(IArchive zipFile, string name)
        {
            _zipFile = zipFile;
            _name = name;
        }

        public IOptional<XmlElement> Get()
        {
            return ((_zipFile).TryGetInputStream(_name)).Map(new DocumentReaderAnonymous14());
        }
    }
}
