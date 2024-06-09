using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReaderAnonymous12 : IBiFunction<IOptional<Style>, IList<IDocumentElement>, IDocumentElement> {
        public IDocumentElement Apply(IOptional<Style> arg0, IList<IDocumentElement> arg1)
        {
            return new Table(arg0, arg1);
        }
    }
}
