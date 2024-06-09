namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlContext {
        public bool IsHeader { get; }

        internal DocumentToHtmlContext(bool isHeader)
        {
            IsHeader = isHeader;
        }

        public DocumentToHtmlContext CreateIsHeader(bool isHeader)
        {
            return new DocumentToHtmlContext(isHeader);
        }
    }
}
