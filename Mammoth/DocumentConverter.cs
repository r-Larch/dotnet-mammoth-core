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
        private readonly DocumentToHtmlOptions _options;

        public DocumentConverter() : this(DocumentToHtmlOptions.Default)
        {
        }

        private DocumentConverter(DocumentToHtmlOptions options)
        {
            this._options = options;
        }

        public DocumentConverter IdPrefix(string idPrefix)
        {
            return new DocumentConverter(_options.IdPrefix(idPrefix));
        }

        public DocumentConverter PreserveEmptyParagraphs()
        {
            return new DocumentConverter(_options.PreserveEmptyParagraphs());
        }

        public DocumentConverter AddStyleMap(string styleMap)
        {
            return new DocumentConverter(_options.AddStyleMap(styleMap));
        }

        public DocumentConverter DisableDefaultStyleMap()
        {
            return new DocumentConverter(_options.DisableDefaultStyleMap());
        }

        public DocumentConverter DisableEmbeddedStyleMap()
        {
            return new DocumentConverter(_options.DisableEmbeddedStyleMap());
        }

        public DocumentConverter ImageConverter(Func<IImage, IDictionary<string, string>> imageConverter)
        {
            return new DocumentConverter(_options.ImageConverter(new ImageConverterShim(imageConverter)));
        }

        public IResult<string> ConvertToHtml(Stream stream)
        {
            return SimpleResult.ToResult(new InternalDocumentConverter(_options)
                    .ConvertToHtml(ToJava.StreamToInputStream(stream)));
        }

        public IResult<string> ConvertToHtml(string path)
        {
            return SimpleResult.ToResult(new InternalDocumentConverter(_options)
                    .ConvertToHtml(new File(path)));
        }

        public IResult<string> ExtractRawText(Stream stream)
        {
            return SimpleResult.ToResult(new InternalDocumentConverter(_options)
                    .ExtractRawText(ToJava.StreamToInputStream(stream)));
        }

        public IResult<string> ExtractRawText(string path)
        {
            return SimpleResult.ToResult(new InternalDocumentConverter(_options)
                    .ExtractRawText(new File(path)));
        }

        internal class ImageConverterShim : IMageConverterImgElement {
            private readonly Func<IImage, IDictionary<string, string>> _func;

            internal ImageConverterShim(Func<IImage, IDictionary<string, string>> func)
            {
                this._func = func;
            }

            public IMap<string, string> Convert(Couscous.org.zwobble.mammoth.images.IImage image)
            {
                return ToJava.DictionaryToMap(_func(new Image(image)));
            }
        }

        internal class Image : IImage {
            private readonly Couscous.org.zwobble.mammoth.images.IImage _image;

            internal Image(Couscous.org.zwobble.mammoth.images.IImage image)
            {
                this._image = image;
            }

            public string AltText => _image.GetAltText().OrElse(null);
            public string ContentType => _image.GetContentType();

            public Stream GetStream()
            {
                return _image.GetInputStream().Stream;
            }
        }
    }
}
