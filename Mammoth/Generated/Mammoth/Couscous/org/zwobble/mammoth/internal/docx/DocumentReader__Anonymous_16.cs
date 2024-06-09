using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_16 : Supplier<PassThroughException> {
        private string _name;

        internal DocumentReader__Anonymous_16(string name)
        {
            _name = name;
        }

        public PassThroughException get()
        {
            return new PassThroughException(new IOException("Missing entry in file: " + _name));
        }
    }
}
