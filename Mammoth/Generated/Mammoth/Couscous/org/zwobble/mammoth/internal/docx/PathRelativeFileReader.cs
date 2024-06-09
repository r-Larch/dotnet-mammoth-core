namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class PathRelativeFileReader : Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.FileReader {
        internal Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.java.nio.file.Path> _path;
        internal PathRelativeFileReader(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.java.nio.file.Path> path) {
            this._path = path;
        }
        public Mammoth.Couscous.java.io.InputStream getInputStream(string uri) {
            try {
                Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.java.net.URI> absoluteUri = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.PathRelativeFileReader.asAbsoluteUri(uri);
                if (absoluteUri.isPresent()) {
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.PathRelativeFileReader.open(absoluteUri.get());
                } else if ((this._path).isPresent()) {
                    return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.PathRelativeFileReader.open((((this._path).get()).toUri()).resolve(uri));
                } else {
                    throw new Mammoth.Couscous.java.io.IOException("path of document is unknown, but is required for relative URI");
                }
            } catch (Mammoth.Couscous.java.io.IOException exception) {
                throw new Mammoth.Couscous.java.io.IOException((("could not open external image '" + uri) + "': ") + exception.getMessage());
            }
        }
        public static Mammoth.Couscous.java.io.InputStream open(Mammoth.Couscous.java.net.URI uri) {
            return (uri.toURL()).openStream();
        }
        public static Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.java.net.URI> asAbsoluteUri(string uriString) {
            try {
                Mammoth.Couscous.java.net.URI uri = new Mammoth.Couscous.java.net.URI(uriString);
                return uri.isAbsolute() ? Mammoth.Couscous.java.util.Optional.of<Mammoth.Couscous.java.net.URI>(uri) : Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.java.net.URI>();
            } catch (Mammoth.Couscous.java.net.URISyntaxException exception) {
                return Mammoth.Couscous.java.util.Optional.empty<Mammoth.Couscous.java.net.URI>();
            }
        }
    }
}

