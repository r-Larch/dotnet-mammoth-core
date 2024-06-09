namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__PartPaths {
        private string _comments;
        private string _endnotes;
        private string _footnotes;
        private string _mainDocument;
        private string _numbering;
        private string _styles;

        internal DocumentReader__PartPaths(string mainDocument, string comments, string endnotes, string footnotes, string numbering, string styles)
        {
            _mainDocument = mainDocument;
            _comments = comments;
            _endnotes = endnotes;
            _footnotes = footnotes;
            _numbering = numbering;
            _styles = styles;
        }

        public string getMainDocument()
        {
            return _mainDocument;
        }

        public string getComments()
        {
            return _comments;
        }

        public string getEndnotes()
        {
            return _endnotes;
        }

        public string getFootnotes()
        {
            return _footnotes;
        }

        public string getNumbering()
        {
            return _numbering;
        }

        public string getStyles()
        {
            return _styles;
        }
    }
}
