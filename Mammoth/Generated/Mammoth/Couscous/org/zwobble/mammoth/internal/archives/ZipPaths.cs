using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal class ZipPaths {
        public static ZipPathsSplitPath SplitPath(string path)
        {
            var index = JavaStringExtensions.LastIndexOf(path, "/");
            if (index == -1) {
                return new ZipPathsSplitPath("", path);
            }

            var dirname = path[..(index - 0)];
            var basename = path[(index + 1)..];
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

    internal class ZipPathsAnonymous0 : IPredicate<string> {
        public bool Test(string path)
        {
            return !path.IsEmpty();
        }
    }

    internal class ZipPathsSplitPath(string dirname, string basename) {
        public string GetDirname()
        {
            return dirname;
        }

        public string GetBasename()
        {
            return basename;
        }
    }
}
