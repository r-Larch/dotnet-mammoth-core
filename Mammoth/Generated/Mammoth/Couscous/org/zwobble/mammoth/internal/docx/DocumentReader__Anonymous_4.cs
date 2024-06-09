using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReaderAnonymous4 : IPredicate<string> {
        private IArchive _archive;

        internal DocumentReaderAnonymous4(IArchive archive)
        {
            _archive = archive;
        }

        public bool Test(string arg0)
        {
            return (_archive).Exists(arg0);
        }
    }
}
