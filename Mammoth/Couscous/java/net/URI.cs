using System;
using System.IO;


namespace Mammoth.Couscous.java.net {
    internal class Uri {
        private readonly System.Uri _uri;

        internal Uri(string uri)
        {
            try {
                _uri = new System.Uri(uri, UriKind.RelativeOrAbsolute);
            }
            catch (UriFormatException exception) {
                throw new UriSyntaxException(exception.Message);
            }
        }

        internal Uri(System.Uri uri)
        {
            _uri = uri;
        }

        internal bool IsAbsolute()
        {
            return _uri.IsAbsoluteUri;
        }

        internal Url ToUrl()
        {
            return new Url(_uri.ToString());
        }

        internal Uri Resolve(string relativeUri)
        {
            if (new Uri(relativeUri).IsAbsolute()) {
                return new Uri(relativeUri);
            }

            if (_uri.IsAbsoluteUri) {
                return new Uri(new System.Uri(_uri, relativeUri));
            }

            var path = _uri.ToString();
            var basePath = Path.GetDirectoryName(path);
            return new Uri(Path.Combine(basePath, relativeUri));
        }
    }
}
