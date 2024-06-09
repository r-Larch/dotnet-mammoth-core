using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_4 : Predicate<string> {
        internal Archive _archive;

        internal DocumentReader__Anonymous_4(Archive archive)
        {
            _archive = archive;
        }

        public bool test(string arg0)
        {
            return (_archive).exists(arg0);
        }
    }
}
