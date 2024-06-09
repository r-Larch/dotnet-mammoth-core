using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.net;
using Mammoth.Couscous.java.nio.file;
using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class PathRelativeFileReader : IFileReader {
        private IOptional<Path> _path;

        internal PathRelativeFileReader(IOptional<Path> path)
        {
            _path = path;
        }

        public INputStream GetInputStream(string uri)
        {
            try {
                var absoluteUri = AsAbsoluteUri(uri);
                if (absoluteUri.IsPresent()) {
                    return Open(absoluteUri.Get());
                }

                if ((_path).IsPresent()) {
                    return Open((((_path).Get()).ToUri()).Resolve(uri));
                }

                throw new IoException("path of document is unknown, but is required for relative URI");
            }
            catch (IoException exception) {
                throw new IoException((("could not open external image '" + uri) + "': ") + exception.GetMessage());
            }
        }

        public static INputStream Open(Uri uri)
        {
            return (uri.ToUrl()).OpenStream();
        }

        public static IOptional<Uri> AsAbsoluteUri(string uriString)
        {
            try {
                var uri = new Uri(uriString);
                return uri.IsAbsolute() ? Optional.Of(uri) : Optional.Empty<Uri>();
            }
            catch (UriSyntaxException exception) {
                return Optional.Empty<Uri>();
            }
        }
    }
}
