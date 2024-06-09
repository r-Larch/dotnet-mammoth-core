using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.net;
using Mammoth.Couscous.java.nio.file;
using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class PathRelativeFileReader : FileReader {
        internal Optional<Path> _path;

        internal PathRelativeFileReader(Optional<Path> path)
        {
            _path = path;
        }

        public InputStream getInputStream(string uri)
        {
            try {
                var absoluteUri = asAbsoluteUri(uri);
                if (absoluteUri.isPresent()) {
                    return open(absoluteUri.get());
                }

                if ((_path).isPresent()) {
                    return open((((_path).get()).toUri()).resolve(uri));
                }

                throw new IOException("path of document is unknown, but is required for relative URI");
            }
            catch (IOException exception) {
                throw new IOException((("could not open external image '" + uri) + "': ") + exception.getMessage());
            }
        }

        public static InputStream open(URI uri)
        {
            return (uri.toURL()).openStream();
        }

        public static Optional<URI> asAbsoluteUri(string uriString)
        {
            try {
                var uri = new URI(uriString);
                return uri.isAbsolute() ? Optional.of(uri) : Optional.empty<URI>();
            }
            catch (URISyntaxException exception) {
                return Optional.empty<URI>();
            }
        }
    }
}
