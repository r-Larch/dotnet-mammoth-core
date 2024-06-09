using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverterAnonymous20 : ISupplier<string> {
        private IDocumentElement _node;

        internal InternalDocumentConverterAnonymous20(IDocumentElement node)
        {
            _node = node;
        }

        public string Get()
        {
            var children = ((Casts.TryCast<IHasChildren>(typeof(IHasChildren), _node)).Map(new InternalDocumentConverterAnonymous18())).OrElse(Lists.List<IDocumentElement>());
            var suffix = ((Casts.TryCast<Paragraph>(typeof(Paragraph), _node)).Map(new InternalDocumentConverterAnonymous19())).OrElse("");
            return InternalDocumentConverter.ExtractRawText(children) + suffix;
        }
    }
}
