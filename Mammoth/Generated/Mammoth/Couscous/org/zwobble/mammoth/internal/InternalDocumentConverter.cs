namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverter {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions _options;
        internal InternalDocumentConverter(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions options) {
            this._options = options;
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> convertToHtml(Mammoth.Couscous.java.io.InputStream stream) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException.unwrap<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_1(stream, this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> convertToHtml(Mammoth.Couscous.java.io.File file) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException.unwrap<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_3(file, this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> convertToHtml(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.java.nio.file.Path> path, Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile) {
            Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap> styleMap = (this.readEmbeddedStyleMap(zipFile)).map<Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.StyleMap>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_4());
            Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions conversionOptions = (styleMap.map<Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtmlOptions>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_5(this))).orElse(this._options);
            return ((((Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readDocument(path, zipFile)).flatMap<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_6(conversionOptions))).map<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_7())).map<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_8())).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_9());
        }
        public Mammoth.Couscous.java.util.Optional<string> readEmbeddedStyleMap(Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException.wrap<Mammoth.Couscous.java.util.Optional<string>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_10(zipFile));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> extractRawText(Mammoth.Couscous.java.io.InputStream stream) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException.unwrap<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_12(stream, this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> extractRawText(Mammoth.Couscous.java.io.File file) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.PassThroughException.unwrap<Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string>>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_14(file, this));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<string> extractRawText(Mammoth.Couscous.java.util.Optional<Mammoth.Couscous.java.nio.file.Path> path, Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile) {
            return (Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.DocumentReader.readDocument(path, zipFile)).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_15());
        }
        public static T withDocxFile<T>(Mammoth.Couscous.java.io.File file, Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive, T> function) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile = new Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.ZippedArchive(file);
            try {
                return function.apply(zipFile);
            } finally {
                zipFile.close();
            }
        }
        public static T withDocxFile<T>(Mammoth.Couscous.java.io.InputStream stream, Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive, T> function) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archive zipFile = Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.InMemoryArchive.fromStream(stream);
            try {
                return function.apply(zipFile);
            } finally {
                zipFile.close();
            }
        }
        public static string extractRawTextOfChildren(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.HasChildren parent) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter.extractRawText(parent.getChildren());
        }
        public static string extractRawText(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> nodes) {
            return java.lang.String.join("", Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement, string>(nodes, new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_16()));
        }
        public static string extractRawText(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement node) {
            return ((Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Casts.tryCast<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text>(typeof(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text), node)).map<string>(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_17())).orElseGet(new Mammoth.Couscous.org.zwobble.mammoth.@internal.InternalDocumentConverter__Anonymous_20(node));
        }
    }
}

