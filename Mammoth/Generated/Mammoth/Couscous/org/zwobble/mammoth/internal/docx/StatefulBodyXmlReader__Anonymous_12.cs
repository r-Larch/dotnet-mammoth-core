using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_12 : BiFunction<Optional<Style>, List<DocumentElement>, DocumentElement> {
        public DocumentElement apply(Optional<Style> arg0, List<DocumentElement> arg1)
        {
            return new Table(arg0, arg1);
        }
    }
}
