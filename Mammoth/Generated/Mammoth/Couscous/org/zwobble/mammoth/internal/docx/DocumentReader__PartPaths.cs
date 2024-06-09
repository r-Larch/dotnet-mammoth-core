namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReaderPartPaths {
        private string _comments;
        private string _endnotes;
        private string _footnotes;
        private string _mainDocument;
        private string _numbering;
        private string _styles;

        internal DocumentReaderPartPaths(string mainDocument, string comments, string endnotes, string footnotes, string numbering, string styles)
        {
            _mainDocument = mainDocument;
            _comments = comments;
            _endnotes = endnotes;
            _footnotes = footnotes;
            _numbering = numbering;
            _styles = styles;
        }

        public string GetMainDocument()
        {
            return _mainDocument;
        }

        public string GetComments()
        {
            return _comments;
        }

        public string GetEndnotes()
        {
            return _endnotes;
        }

        public string GetFootnotes()
        {
            return _footnotes;
        }

        public string GetNumbering()
        {
            return _numbering;
        }

        public string GetStyles()
        {
            return _styles;
        }
    }
}
