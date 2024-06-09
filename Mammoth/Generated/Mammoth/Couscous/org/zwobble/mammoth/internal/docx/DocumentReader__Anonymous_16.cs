using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReaderAnonymous16 : ISupplier<PassThroughException> {
        private string _name;

        internal DocumentReaderAnonymous16(string name)
        {
            _name = name;
        }

        public PassThroughException Get()
        {
            return new PassThroughException(new IoException("Missing entry in file: " + _name));
        }
    }
}
