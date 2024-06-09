using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverterAnonymous5 : IFunction<StyleMap, DocumentToHtmlOptions> {
        private InternalDocumentConverter _thisOrgZwobbleMammothInternalInternalDocumentConverter;

        internal InternalDocumentConverterAnonymous5(InternalDocumentConverter thisOrgZwobbleMammothInternalInternalDocumentConverter)
        {
            _thisOrgZwobbleMammothInternalInternalDocumentConverter = thisOrgZwobbleMammothInternalInternalDocumentConverter;
        }

        public DocumentToHtmlOptions Apply(StyleMap arg0)
        {
            return ((_thisOrgZwobbleMammothInternalInternalDocumentConverter).Options).AddEmbeddedStyleMap(arg0);
        }
    }
}
