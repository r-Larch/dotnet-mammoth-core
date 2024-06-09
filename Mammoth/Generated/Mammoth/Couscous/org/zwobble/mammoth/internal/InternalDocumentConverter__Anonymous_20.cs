using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_20 : Supplier<string> {
        internal DocumentElement _node;

        internal InternalDocumentConverter__Anonymous_20(DocumentElement node)
        {
            _node = node;
        }

        public string get()
        {
            var children = ((Casts.tryCast<HasChildren>(typeof(HasChildren), _node)).map(new InternalDocumentConverter__Anonymous_18())).orElse(Lists.list<DocumentElement>());
            var suffix = ((Casts.tryCast<Paragraph>(typeof(Paragraph), _node)).map(new InternalDocumentConverter__Anonymous_19())).orElse("");
            return InternalDocumentConverter.extractRawText(children) + suffix;
        }
    }
}
