using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__Anonymous_3 : Function<string, string> {
        internal string _basePath;

        internal DocumentReader__Anonymous_3(string basePath)
        {
            _basePath = basePath;
        }

        public string apply(string target)
        {
            return Strings.trimLeft(ZipPaths.joinPath(new[] { _basePath, target }), '/');
        }
    }
}
