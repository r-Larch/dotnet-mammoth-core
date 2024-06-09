namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class DocumentReader__PartPaths {
        internal string _mainDocument;
        internal string _comments;
        internal string _endnotes;
        internal string _footnotes;
        internal string _numbering;
        internal string _styles;
        internal DocumentReader__PartPaths(string mainDocument, string comments, string endnotes, string footnotes, string numbering, string styles) {
            this._mainDocument = mainDocument;
            this._comments = comments;
            this._endnotes = endnotes;
            this._footnotes = footnotes;
            this._numbering = numbering;
            this._styles = styles;
        }
        public string getMainDocument() {
            return this._mainDocument;
        }
        public string getComments() {
            return this._comments;
        }
        public string getEndnotes() {
            return this._endnotes;
        }
        public string getFootnotes() {
            return this._footnotes;
        }
        public string getNumbering() {
            return this._numbering;
        }
        public string getStyles() {
            return this._styles;
        }
    }
}

