using Mammoth.Couscous.org.zwobble.mammoth.images;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlOptions(
        string idPrefix,
        bool preserveEmptyParagraphs,
        StyleMap map,
        StyleMap embeddedStyleMap,
        bool disableDefaultStyleMap,
        bool disableEmbeddedStyleMap,
        IMageConverterImgElement imageConverter
    ) {
        public static DocumentToHtmlOptions Default = new("", false, styles.StyleMap.Empty, styles.StyleMap.Empty, false, false, new DocumentToHtmlOptionsAnonymous1());


        public DocumentToHtmlOptions IdPrefix(string prefix)
        {
            return new DocumentToHtmlOptions(prefix, preserveEmptyParagraphs, map, embeddedStyleMap, disableDefaultStyleMap, disableEmbeddedStyleMap, imageConverter);
        }

        public DocumentToHtmlOptions PreserveEmptyParagraphs()
        {
            return new DocumentToHtmlOptions(idPrefix, true, map, embeddedStyleMap, disableDefaultStyleMap, disableEmbeddedStyleMap, imageConverter);
        }

        public DocumentToHtmlOptions AddStyleMap(string styleMap)
        {
            return AddStyleMap(StyleMapParser.Parse(styleMap));
        }

        public DocumentToHtmlOptions AddStyleMap(StyleMap styleMap)
        {
            return new DocumentToHtmlOptions(idPrefix, preserveEmptyParagraphs, map.Update(styleMap), embeddedStyleMap, disableDefaultStyleMap, disableEmbeddedStyleMap, imageConverter);
        }

        public DocumentToHtmlOptions DisableDefaultStyleMap()
        {
            return new DocumentToHtmlOptions(idPrefix, preserveEmptyParagraphs, map, embeddedStyleMap, true, disableEmbeddedStyleMap, imageConverter);
        }

        public DocumentToHtmlOptions DisableEmbeddedStyleMap()
        {
            return new DocumentToHtmlOptions(idPrefix, preserveEmptyParagraphs, map, embeddedStyleMap, disableDefaultStyleMap, true, imageConverter);
        }

        public DocumentToHtmlOptions AddEmbeddedStyleMap(StyleMap embeddedStyleMap)
        {
            return new DocumentToHtmlOptions(idPrefix, preserveEmptyParagraphs, map, embeddedStyleMap, disableDefaultStyleMap, disableEmbeddedStyleMap, imageConverter);
        }

        public DocumentToHtmlOptions ImageConverter(IMageConverterImgElement imageConverter)
        {
            return new DocumentToHtmlOptions(idPrefix, preserveEmptyParagraphs, map, embeddedStyleMap, disableDefaultStyleMap, disableEmbeddedStyleMap, imageConverter);
        }

        public string IdPrefix()
        {
            return idPrefix;
        }

        public bool ShouldPreserveEmptyParagraphs()
        {
            return preserveEmptyParagraphs;
        }

        public StyleMap StyleMap()
        {
            var styleMap = styles.StyleMap.Empty;
            if (!disableDefaultStyleMap) {
                styleMap = styleMap.Update(DefaultStyles.DefaultStyleMap);
            }

            if (!disableEmbeddedStyleMap) {
                styleMap = styleMap.Update(embeddedStyleMap);
            }

            styleMap = styleMap.Update(map);
            return styleMap;
        }

        public IMageConverterImgElement ImageConverter()
        {
            return imageConverter;
        }
    }
}
