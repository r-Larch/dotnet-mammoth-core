using System;
using System.IO;


namespace Mammoth.Couscous.java.net {
    internal class URI {
        private readonly Uri _uri;

        internal URI(string uri)
        {
            try {
                _uri = new Uri(uri, UriKind.RelativeOrAbsolute);
            }
            catch (UriFormatException exception) {
                throw new URISyntaxException(exception.Message);
            }
        }

        internal URI(Uri uri)
        {
            _uri = uri;
        }

        internal bool isAbsolute()
        {
            return _uri.IsAbsoluteUri;
        }

        internal URL toURL()
        {
            return new URL(_uri.ToString());
        }

        internal URI resolve(string relativeUri)
        {
            if (new URI(relativeUri).isAbsolute()) {
                return new URI(relativeUri);
            }

            if (_uri.IsAbsoluteUri) {
                return new URI(new Uri(_uri, relativeUri));
            }

            var path = _uri.ToString();
            var basePath = Path.GetDirectoryName(path);
            return new URI(Path.Combine(basePath, relativeUri));
        }
    }
}
