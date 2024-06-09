using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal class ZipPaths {
        public static ZipPathsSplitPath SplitPath(string path)
        {
            var index = JavaStringExtensions.LastIndexOf(path, "/");
            if (index == -1) {
                return new ZipPathsSplitPath("", path);
            }

            var dirname = path.Substring(0, index - 0);
            var basename = path.Substring(index + 1);
            return new ZipPathsSplitPath(dirname, basename);
        }

        public static string JoinPath(string[] paths)
        {
            var nonEmptyPaths = Lists.EagerFilter(Arrays.AsList(paths), new ZipPathsAnonymous0());
            IList<string> relevantPaths = new ArrayList<string>();
            {
                var couscousDesugarForeachToFor0 = nonEmptyPaths.Iterator();
                while (couscousDesugarForeachToFor0.HasNext()) {
                    var path = couscousDesugarForeachToFor0.Next();
                    if (JavaStringExtensions.StartsWith(path, "/")) {
                        relevantPaths.Clear();
                    }

                    relevantPaths.Add(path);
                }
            }
            return String.Join("/", relevantPaths);
        }
    }
}
