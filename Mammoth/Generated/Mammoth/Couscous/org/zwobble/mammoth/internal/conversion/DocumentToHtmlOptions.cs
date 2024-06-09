using Mammoth.Couscous.org.zwobble.mammoth.images;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlOptions {
        internal static DocumentToHtmlOptions _DEFAULT;
        internal bool _disableDefaultStyleMap;
        internal bool _disableEmbeddedStyleMap;
        internal StyleMap _embeddedStyleMap;
        internal string _idPrefix;
        internal ImageConverter__ImgElement _imageConverter;
        internal bool _preserveEmptyParagraphs;
        internal StyleMap _styleMap;

        static DocumentToHtmlOptions()
        {
            _DEFAULT = new DocumentToHtmlOptions("", false, StyleMap._EMPTY, StyleMap._EMPTY, false, false, new DocumentToHtmlOptions__Anonymous_1());
        }

        internal DocumentToHtmlOptions(string idPrefix, bool preserveEmptyParagraphs, StyleMap styleMap, StyleMap embeddedStyleMap, bool disableDefaultStyleMap, bool disableEmbeddedStyleMap, ImageConverter__ImgElement imageConverter)
        {
            _idPrefix = idPrefix;
            _preserveEmptyParagraphs = preserveEmptyParagraphs;
            _styleMap = styleMap;
            _embeddedStyleMap = embeddedStyleMap;
            _disableDefaultStyleMap = disableDefaultStyleMap;
            _disableEmbeddedStyleMap = disableEmbeddedStyleMap;
            _imageConverter = imageConverter;
        }

        public DocumentToHtmlOptions idPrefix(string prefix)
        {
            return new DocumentToHtmlOptions(prefix, _preserveEmptyParagraphs, _styleMap, _embeddedStyleMap, _disableDefaultStyleMap, _disableEmbeddedStyleMap, _imageConverter);
        }

        public DocumentToHtmlOptions preserveEmptyParagraphs()
        {
            return new DocumentToHtmlOptions(_idPrefix, true, _styleMap, _embeddedStyleMap, _disableDefaultStyleMap, _disableEmbeddedStyleMap, _imageConverter);
        }

        public DocumentToHtmlOptions addStyleMap(string styleMap)
        {
            return addStyleMap(StyleMapParser.parse(styleMap));
        }

        public DocumentToHtmlOptions addStyleMap(StyleMap styleMap)
        {
            return new DocumentToHtmlOptions(_idPrefix, _preserveEmptyParagraphs, (_styleMap).update(styleMap), _embeddedStyleMap, _disableDefaultStyleMap, _disableEmbeddedStyleMap, _imageConverter);
        }

        public DocumentToHtmlOptions disableDefaultStyleMap()
        {
            return new DocumentToHtmlOptions(_idPrefix, _preserveEmptyParagraphs, _styleMap, _embeddedStyleMap, true, _disableEmbeddedStyleMap, _imageConverter);
        }

        public DocumentToHtmlOptions disableEmbeddedStyleMap()
        {
            return new DocumentToHtmlOptions(_idPrefix, _preserveEmptyParagraphs, _styleMap, _embeddedStyleMap, _disableDefaultStyleMap, true, _imageConverter);
        }

        public DocumentToHtmlOptions addEmbeddedStyleMap(StyleMap embeddedStyleMap)
        {
            return new DocumentToHtmlOptions(_idPrefix, _preserveEmptyParagraphs, _styleMap, embeddedStyleMap, _disableDefaultStyleMap, _disableEmbeddedStyleMap, _imageConverter);
        }

        public DocumentToHtmlOptions imageConverter(ImageConverter__ImgElement imageConverter)
        {
            return new DocumentToHtmlOptions(_idPrefix, _preserveEmptyParagraphs, _styleMap, _embeddedStyleMap, _disableDefaultStyleMap, _disableEmbeddedStyleMap, imageConverter);
        }

        public string idPrefix()
        {
            return _idPrefix;
        }

        public bool shouldPreserveEmptyParagraphs()
        {
            return _preserveEmptyParagraphs;
        }

        public StyleMap styleMap()
        {
            var styleMap = StyleMap._EMPTY;
            if (!_disableDefaultStyleMap) {
                styleMap = styleMap.update(DefaultStyles._DEFAULT_STYLE_MAP);
            }

            if (!_disableEmbeddedStyleMap) {
                styleMap = styleMap.update(_embeddedStyleMap);
            }

            styleMap = styleMap.update(_styleMap);
            return styleMap;
        }

        public ImageConverter__ImgElement imageConverter()
        {
            return _imageConverter;
        }
    }
}
