using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_18 : Function<HasChildren, List<DocumentElement>> {
        public List<DocumentElement> apply(HasChildren arg0)
        {
            return arg0.getChildren();
        }
    }
}
