namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Uris {
        public static string uriToZipEntryName(string @base, string uri)
        {
            if (uri.startsWith("/")) {
                return uri.Substring(1);
            }

            return (@base + "/") + uri;
        }

        public static string replaceFragment(string uri, string fragment)
        {
            var hashIndex = uri.indexOf("#");
            if (hashIndex != -1) {
                uri = (uri.Substring(0, hashIndex - 0));
            }

            return (uri + "#") + fragment;
        }
    }
}
