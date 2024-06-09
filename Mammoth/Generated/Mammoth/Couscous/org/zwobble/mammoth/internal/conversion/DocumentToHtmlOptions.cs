namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlOptions {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions _DEFAULT;
        internal string _idPrefix;
        internal bool _preserveEmptyParagraphs;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap _styleMap;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap _embeddedStyleMap;
        internal bool _disableDefaultStyleMap;
        internal bool _disableEmbeddedStyleMap;
        internal Mammoth.Couscous.org.zwobble.mammoth.images.ImageConverter__ImgElement _imageConverter;
        static DocumentToHtmlOptions() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions._DEFAULT = new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions("", false, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap._EMPTY, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap._EMPTY, false, false, new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions__Anonymous_1());
        }
        internal DocumentToHtmlOptions(string idPrefix, bool preserveEmptyParagraphs, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap styleMap, Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap embeddedStyleMap, bool disableDefaultStyleMap, bool disableEmbeddedStyleMap, Mammoth.Couscous.org.zwobble.mammoth.images.ImageConverter__ImgElement imageConverter) {
            this._idPrefix = idPrefix;
            this._preserveEmptyParagraphs = preserveEmptyParagraphs;
            this._styleMap = styleMap;
            this._embeddedStyleMap = embeddedStyleMap;
            this._disableDefaultStyleMap = disableDefaultStyleMap;
            this._disableEmbeddedStyleMap = disableEmbeddedStyleMap;
            this._imageConverter = imageConverter;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions idPrefix(string prefix) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions(prefix, this._preserveEmptyParagraphs, this._styleMap, this._embeddedStyleMap, this._disableDefaultStyleMap, this._disableEmbeddedStyleMap, this._imageConverter);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions preserveEmptyParagraphs() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions(this._idPrefix, true, this._styleMap, this._embeddedStyleMap, this._disableDefaultStyleMap, this._disableEmbeddedStyleMap, this._imageConverter);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions addStyleMap(string styleMap) {
            return this.addStyleMap(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing.StyleMapParser.parse(styleMap));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions addStyleMap(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap styleMap) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions(this._idPrefix, this._preserveEmptyParagraphs, (this._styleMap).update(styleMap), this._embeddedStyleMap, this._disableDefaultStyleMap, this._disableEmbeddedStyleMap, this._imageConverter);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions disableDefaultStyleMap() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions(this._idPrefix, this._preserveEmptyParagraphs, this._styleMap, this._embeddedStyleMap, true, this._disableEmbeddedStyleMap, this._imageConverter);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions disableEmbeddedStyleMap() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions(this._idPrefix, this._preserveEmptyParagraphs, this._styleMap, this._embeddedStyleMap, this._disableDefaultStyleMap, true, this._imageConverter);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions addEmbeddedStyleMap(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap embeddedStyleMap) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions(this._idPrefix, this._preserveEmptyParagraphs, this._styleMap, embeddedStyleMap, this._disableDefaultStyleMap, this._disableEmbeddedStyleMap, this._imageConverter);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions imageConverter(Mammoth.Couscous.org.zwobble.mammoth.images.ImageConverter__ImgElement imageConverter) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions(this._idPrefix, this._preserveEmptyParagraphs, this._styleMap, this._embeddedStyleMap, this._disableDefaultStyleMap, this._disableEmbeddedStyleMap, imageConverter);
        }
        public string idPrefix() {
            return this._idPrefix;
        }
        public bool shouldPreserveEmptyParagraphs() {
            return this._preserveEmptyParagraphs;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap styleMap() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap styleMap = Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap._EMPTY;
            if (!this._disableDefaultStyleMap) {
                styleMap = styleMap.update(Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.DefaultStyles._DEFAULT_STYLE_MAP);
            }
            if (!this._disableEmbeddedStyleMap) {
                styleMap = styleMap.update(this._embeddedStyleMap);
            }
            styleMap = styleMap.update(this._styleMap);
            return styleMap;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.images.ImageConverter__ImgElement imageConverter() {
            return this._imageConverter;
        }
    }
}

