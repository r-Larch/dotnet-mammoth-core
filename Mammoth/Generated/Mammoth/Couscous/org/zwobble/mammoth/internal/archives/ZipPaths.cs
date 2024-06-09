namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal class ZipPaths {
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.ZipPaths__SplitPath splitPath(string path) {
            int index = path.lastIndexOf("/");
            if (index == -1) {
                return new Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.ZipPaths__SplitPath("", path);
            } else {
                string dirname = path.Substring(0, index - 0);
                string basename = path.Substring(index + 1);
                return new Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.ZipPaths__SplitPath(dirname, basename);
            }
        }
        public static string joinPath(string[] paths) {
            Mammoth.Couscous.java.util.List<string> nonEmptyPaths = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFilter<string>(Mammoth.Couscous.java.util.Arrays.asList<string>(paths), new Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.ZipPaths__Anonymous_0());
            Mammoth.Couscous.java.util.List<string> relevantPaths = new Mammoth.Couscous.java.util.ArrayList<string>();
             {
                Mammoth.Couscous.java.util.Iterator<string> _couscous_desugar_foreach_to_for0 = nonEmptyPaths.iterator();
                while (_couscous_desugar_foreach_to_for0.hasNext()) {
                    string path = _couscous_desugar_foreach_to_for0.next();
                    if (path.startsWith("/")) {
                        relevantPaths.clear();
                    }
                    relevantPaths.add(path);
                }
            }
            return java.lang.String.join("/", relevantPaths);
        }
    }
}

