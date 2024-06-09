using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ReadResultAnonymous2 : IFunction<ReadResult, ITerable<string>> {
        public ITerable<string> Apply(ReadResult result)
        {
            return result.Warnings;
        }
    }
}
