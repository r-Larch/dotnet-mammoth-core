using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.nio.file;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.docx;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter {
        internal DocumentToHtmlOptions _options;

        internal InternalDocumentConverter(DocumentToHtmlOptions options)
        {
            _options = options;
        }

        public InternalResult<string> convertToHtml(InputStream stream)
        {
            return PassThroughException.unwrap(new InternalDocumentConverter__Anonymous_1(stream, this));
        }

        public InternalResult<string> convertToHtml(File file)
        {
            return PassThroughException.unwrap(new InternalDocumentConverter__Anonymous_3(file, this));
        }

        public InternalResult<string> convertToHtml(Optional<Path> path, Archive zipFile)
        {
            var styleMap = (readEmbeddedStyleMap(zipFile)).map(new InternalDocumentConverter__Anonymous_4());
            var conversionOptions = (styleMap.map(new InternalDocumentConverter__Anonymous_5(this))).orElse(_options);
            return ((((DocumentReader.readDocument(path, zipFile)).flatMap(new InternalDocumentConverter__Anonymous_6(conversionOptions))).map(new InternalDocumentConverter__Anonymous_7())).map(new InternalDocumentConverter__Anonymous_8())).map(new InternalDocumentConverter__Anonymous_9());
        }

        public Optional<string> readEmbeddedStyleMap(Archive zipFile)
        {
            return PassThroughException.wrap(new InternalDocumentConverter__Anonymous_10(zipFile));
        }

        public InternalResult<string> extractRawText(InputStream stream)
        {
            return PassThroughException.unwrap(new InternalDocumentConverter__Anonymous_12(stream, this));
        }

        public InternalResult<string> extractRawText(File file)
        {
            return PassThroughException.unwrap(new InternalDocumentConverter__Anonymous_14(file, this));
        }

        public InternalResult<string> extractRawText(Optional<Path> path, Archive zipFile)
        {
            return (DocumentReader.readDocument(path, zipFile)).map(new InternalDocumentConverter__Anonymous_15());
        }

        public static T withDocxFile<T>(File file, Function<Archive, T> function)
        {
            Archive zipFile = new ZippedArchive(file);
            try {
                return function.apply(zipFile);
            }
            finally {
                zipFile.close();
            }
        }

        public static T withDocxFile<T>(InputStream stream, Function<Archive, T> function)
        {
            var zipFile = InMemoryArchive.fromStream(stream);
            try {
                return function.apply(zipFile);
            }
            finally {
                zipFile.close();
            }
        }

        public static string extractRawTextOfChildren(HasChildren parent)
        {
            return extractRawText(parent.getChildren());
        }

        public static string extractRawText(List<DocumentElement> nodes)
        {
            return String.join("", Iterables.lazyMap(nodes, new InternalDocumentConverter__Anonymous_16()));
        }

        public static string extractRawText(DocumentElement node)
        {
            return ((Casts.tryCast<Text>(typeof(Text), node)).map(new InternalDocumentConverter__Anonymous_17())).orElseGet(new InternalDocumentConverter__Anonymous_20(node));
        }
    }
}
