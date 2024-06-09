using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatchingAnonymous0 : IFunction<Style, string> {
        public string Apply(Style arg0)
        {
            return arg0.GetStyleId();
        }
    }
}
