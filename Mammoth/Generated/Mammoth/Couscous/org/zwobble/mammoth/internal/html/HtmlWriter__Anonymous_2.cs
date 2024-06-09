using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlWriterAnonymous2 : IFunction<IMapEntry<string, string>, string> {
        public string Apply(IMapEntry<string, string> arg0)
        {
            return arg0.GetKey();
        }
    }
}
