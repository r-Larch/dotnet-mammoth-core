using Mammoth.Couscous.org.zwobble.mammoth.images;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlOptions {
        public static DocumentToHtmlOptions Default;
        private bool _disableDefaultStyleMap;
        private bool _disableEmbeddedStyleMap;
        private StyleMap _embeddedStyleMap;
        private string _idPrefix;
        private IMageConverterImgElement _imageConverter;
        private bool _preserveEmptyParagraphs;
        private StyleMap _styleMap;

        static DocumentToHtmlOptions()
        {
            Default = new DocumentToHtmlOptions("", false, styles.StyleMap.Empty, styles.StyleMap.Empty, false, false, new DocumentToHtmlOptionsAnonymous1());
        }

        internal DocumentToHtmlOptions(string idPrefix, bool preserveEmptyParagraphs, StyleMap styleMap, StyleMap embeddedStyleMap, bool disableDefaultStyleMap, bool disableEmbeddedStyleMap, IMageConverterImgElement imageConverter)
        {
            _idPrefix = idPrefix;
            _preserveEmptyParagraphs = preserveEmptyParagraphs;
            _styleMap = styleMap;
            _embeddedStyleMap = embeddedStyleMap;
            _disableDefaultStyleMap = disableDefaultStyleMap;
            _disableEmbeddedStyleMap = disableEmbeddedStyleMap;
            _imageConverter = imageConverter;
        }

        public DocumentToHtmlOptions IdPrefix(string prefix)
        {
            return new DocumentToHtmlOptions(prefix, _preserveEmptyParagraphs, _styleMap, _embeddedStyleMap, _disableDefaultStyleMap, _disableEmbeddedStyleMap, _imageConverter);
        }

        public DocumentToHtmlOptions PreserveEmptyParagraphs()
        {
            return new DocumentToHtmlOptions(_idPrefix, true, _styleMap, _embeddedStyleMap, _disableDefaultStyleMap, _disableEmbeddedStyleMap, _imageConverter);
        }

        public DocumentToHtmlOptions AddStyleMap(string styleMap)
        {
            return AddStyleMap(StyleMapParser.Parse(styleMap));
        }

        public DocumentToHtmlOptions AddStyleMap(StyleMap styleMap)
        {
            return new DocumentToHtmlOptions(_idPrefix, _preserveEmptyParagraphs, (_styleMap).Update(styleMap), _embeddedStyleMap, _disableDefaultStyleMap, _disableEmbeddedStyleMap, _imageConverter);
        }

        public DocumentToHtmlOptions DisableDefaultStyleMap()
        {
            return new DocumentToHtmlOptions(_idPrefix, _preserveEmptyParagraphs, _styleMap, _embeddedStyleMap, true, _disableEmbeddedStyleMap, _imageConverter);
        }

        public DocumentToHtmlOptions DisableEmbeddedStyleMap()
        {
            return new DocumentToHtmlOptions(_idPrefix, _preserveEmptyParagraphs, _styleMap, _embeddedStyleMap, _disableDefaultStyleMap, true, _imageConverter);
        }

        public DocumentToHtmlOptions AddEmbeddedStyleMap(StyleMap embeddedStyleMap)
        {
            return new DocumentToHtmlOptions(_idPrefix, _preserveEmptyParagraphs, _styleMap, embeddedStyleMap, _disableDefaultStyleMap, _disableEmbeddedStyleMap, _imageConverter);
        }

        public DocumentToHtmlOptions ImageConverter(IMageConverterImgElement imageConverter)
        {
            return new DocumentToHtmlOptions(_idPrefix, _preserveEmptyParagraphs, _styleMap, _embeddedStyleMap, _disableDefaultStyleMap, _disableEmbeddedStyleMap, imageConverter);
        }

        public string IdPrefix()
        {
            return _idPrefix;
        }

        public bool ShouldPreserveEmptyParagraphs()
        {
            return _preserveEmptyParagraphs;
        }

        public StyleMap StyleMap()
        {
            var styleMap = styles.StyleMap.Empty;
            if (!_disableDefaultStyleMap) {
                styleMap = styleMap.Update(DefaultStyles.DefaultStyleMap);
            }

            if (!_disableEmbeddedStyleMap) {
                styleMap = styleMap.Update(_embeddedStyleMap);
            }

            styleMap = styleMap.Update(_styleMap);
            return styleMap;
        }

        public IMageConverterImgElement ImageConverter()
        {
            return _imageConverter;
        }
    }
}
