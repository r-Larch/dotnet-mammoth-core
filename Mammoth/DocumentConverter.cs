using System;
using System.Collections.Generic;
using System.IO;
using Mammoth.Couscous;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.org.zwobble.mammoth.images;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion;
using Mammoth.Couscous.org.zwobble.mammoth.@internal;
using File = Mammoth.Couscous.java.io.File;


namespace Mammoth {
    public class DocumentConverter {
        private readonly DocumentToHtmlOptions options;

        public DocumentConverter() : this(DocumentToHtmlOptions._DEFAULT)
        {
        }

        private DocumentConverter(DocumentToHtmlOptions options)
        {
            this.options = options;
        }

        public DocumentConverter IdPrefix(string idPrefix)
        {
            return new DocumentConverter(options.idPrefix(idPrefix));
        }

        public DocumentConverter PreserveEmptyParagraphs()
        {
            return new DocumentConverter(options.preserveEmptyParagraphs());
        }

        public DocumentConverter AddStyleMap(string styleMap)
        {
            return new DocumentConverter(options.addStyleMap(styleMap));
        }

        public DocumentConverter DisableDefaultStyleMap()
        {
            return new DocumentConverter(options.disableDefaultStyleMap());
        }

        public DocumentConverter DisableEmbeddedStyleMap()
        {
            return new DocumentConverter(options.disableEmbeddedStyleMap());
        }

        public DocumentConverter ImageConverter(Func<IImage, IDictionary<string, string>> imageConverter)
        {
            return new DocumentConverter(options.imageConverter(new ImageConverterShim(imageConverter)));
        }

        public IResult<string> ConvertToHtml(Stream stream)
        {
            return new InternalDocumentConverter(options)
                .convertToHtml(ToJava.StreamToInputStream(stream))
                .ToResult();
        }

        public IResult<string> ConvertToHtml(string path)
        {
            return new InternalDocumentConverter(options)
                .convertToHtml(new File(path))
                .ToResult();
        }

        public IResult<string> ExtractRawText(Stream stream)
        {
            return new InternalDocumentConverter(options)
                .extractRawText(ToJava.StreamToInputStream(stream))
                .ToResult();
        }

        public IResult<string> ExtractRawText(string path)
        {
            return new InternalDocumentConverter(options)
                .extractRawText(new File(path))
                .ToResult();
        }

        internal class ImageConverterShim : ImageConverter__ImgElement {
            private readonly Func<IImage, IDictionary<string, string>> func;

            internal ImageConverterShim(Func<IImage, IDictionary<string, string>> func)
            {
                this.func = func;
            }

            public Map<string, string> convert(Couscous.org.zwobble.mammoth.images.Image image)
            {
                return ToJava.DictionaryToMap(func(new Image(image)));
            }
        }

        internal class Image : IImage {
            private readonly Couscous.org.zwobble.mammoth.images.Image image;

            internal Image(Couscous.org.zwobble.mammoth.images.Image image)
            {
                this.image = image;
            }

            public string AltText => image.getAltText().orElse(null);
            public string ContentType => image.getContentType();

            public Stream GetStream()
            {
                return image.getInputStream().Stream;
            }
        }
    }
}
