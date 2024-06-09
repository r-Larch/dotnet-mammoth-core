using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_4 : Function<string, StyleMap> {
        public StyleMap apply(string arg0)
        {
            return StyleMapParser.parse(arg0);
        }
    }
}
