using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal class ZipPaths {
        public static ZipPaths__SplitPath splitPath(string path)
        {
            var index = path.lastIndexOf("/");
            if (index == -1) {
                return new ZipPaths__SplitPath("", path);
            }

            var dirname = path.Substring(0, index - 0);
            var basename = path.Substring(index + 1);
            return new ZipPaths__SplitPath(dirname, basename);
        }

        public static string joinPath(string[] paths)
        {
            var nonEmptyPaths = Lists.eagerFilter(Arrays.asList(paths), new ZipPaths__Anonymous_0());
            List<string> relevantPaths = new ArrayList<string>();
            {
                var _couscous_desugar_foreach_to_for0 = nonEmptyPaths.iterator();
                while (_couscous_desugar_foreach_to_for0.hasNext()) {
                    var path = _couscous_desugar_foreach_to_for0.next();
                    if (path.startsWith("/")) {
                        relevantPaths.clear();
                    }

                    relevantPaths.add(path);
                }
            }
            return String.join("/", relevantPaths);
        }
    }
}
