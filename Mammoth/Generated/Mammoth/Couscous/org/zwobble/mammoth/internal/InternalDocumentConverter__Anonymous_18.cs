using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverterAnonymous18 : IFunction<IHasChildren, IList<IDocumentElement>> {
        public IList<IDocumentElement> Apply(IHasChildren arg0)
        {
            return arg0.GetChildren();
        }
    }
}
