using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReaderAnonymous3 : IFunction<string, string> {
        private string _basePath;

        internal DocumentReaderAnonymous3(string basePath)
        {
            _basePath = basePath;
        }

        public string Apply(string target)
        {
            return Strings.TrimLeft(ZipPaths.JoinPath(new[] { _basePath, target }), '/');
        }
    }
}
