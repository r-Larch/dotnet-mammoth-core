namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util {
    internal static class Paths {
        internal static string GetExtension(string path)
        {
            var dotIndex = path.LastIndexOf('.');
            return dotIndex == -1 ? "" : path.Substring(dotIndex + 1);
        }
    }
}
