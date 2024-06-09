namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class Uris {
        public static string UriToZipEntryName(string @base, string uri)
        {
            if (JavaStringExtensions.StartsWith(uri, "/")) {
                return uri.Substring(1);
            }

            return $"{@base}/{uri}";
        }

        public static string ReplaceFragment(string uri, string fragment)
        {
            var hashIndex = JavaStringExtensions.IndexOf(uri, "#");
            if (hashIndex != -1) {
                uri = uri.Substring(0, hashIndex - 0);
            }

            return $"{uri}#{fragment}";
        }
    }
}
