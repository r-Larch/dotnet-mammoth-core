using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_15 : SupplierWithException<Optional<XmlElement>, IOException> {
        private string _name;
        private Archive _zipFile;

        internal DocumentReader__Anonymous_15(Archive zipFile, string name)
        {
            _zipFile = zipFile;
            _name = name;
        }

        public Optional<XmlElement> get()
        {
            return ((_zipFile).tryGetInputStream(_name)).map(new DocumentReader__Anonymous_14());
        }
    }
}
