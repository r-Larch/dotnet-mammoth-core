using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class EmbeddedStyleMapAnonymous0 : IFunction<INputStream, string> {
        public string Apply(INputStream arg0)
        {
            return Streams.ToString(arg0);
        }
    }
}
