namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Context {
        public bool _isHeader;

        internal DocumentToHtml__Context(bool isHeader)
        {
            _isHeader = isHeader;
        }

        public DocumentToHtml__Context isHeader(bool isHeader)
        {
            return new DocumentToHtml__Context(isHeader);
        }
    }
}
