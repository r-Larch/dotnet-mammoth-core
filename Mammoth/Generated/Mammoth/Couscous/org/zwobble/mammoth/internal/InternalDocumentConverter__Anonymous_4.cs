using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverterAnonymous4 : IFunction<string, StyleMap> {
        public StyleMap Apply(string arg0)
        {
            return StyleMapParser.Parse(arg0);
        }
    }
}
