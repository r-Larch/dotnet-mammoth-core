using System.IO;
using System.Text;
using Mammoth.Couscous.java.io;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util {
    internal static class Streams {
        internal static string ToString(INputStream stream)
        {
            return new StreamReader(stream.Stream, Encoding.UTF8).ReadToEnd();
        }
    }
}
