using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal class DocumentElementMatchingAnonymous2 : IFunction<Style, IOptional<string>> {
        public IOptional<string> Apply(Style arg0)
        {
            return arg0.GetName();
        }
    }
}
