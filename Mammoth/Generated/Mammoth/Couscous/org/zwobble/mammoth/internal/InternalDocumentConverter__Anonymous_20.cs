namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter__Anonymous_20 : Mammoth.Couscous.java.util.function.Supplier<string> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement _node;
        internal InternalDocumentConverter__Anonymous_20(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement node) {
            this._node = node;
        }
        public string get() {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> children = ((Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Casts.tryCast<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren>(typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren), this._node)).map<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_18())).orElse(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>());
            string suffix = ((Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Casts.tryCast<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph>(typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph), this._node)).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_19())).orElse("");
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter.extractRawText(children) + suffix;
        }
    }
}

