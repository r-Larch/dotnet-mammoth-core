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
        public DocumentToHtmlOptions Options;

        internal InternalDocumentConverter(DocumentToHtmlOptions options)
        {
            Options = options;
        }

        public InternalResult<string> ConvertToHtml(INputStream stream)
        {
            return PassThroughException.Unwrap(new InternalDocumentConverterAnonymous1(stream, this));
        }

        public InternalResult<string> ConvertToHtml(File file)
        {
            return PassThroughException.Unwrap(new InternalDocumentConverterAnonymous3(file, this));
        }

        public InternalResult<string> ConvertToHtml(IOptional<Path> path, IArchive zipFile)
        {
            var styleMap = (ReadEmbeddedStyleMap(zipFile)).Map(new InternalDocumentConverterAnonymous4());
            var conversionOptions = (styleMap.Map(new InternalDocumentConverterAnonymous5(this))).OrElse(Options);
            return ((((DocumentReader.ReadDocument(path, zipFile)).FlatMap(new InternalDocumentConverterAnonymous6(conversionOptions))).Map(new InternalDocumentConverterAnonymous7())).Map(new InternalDocumentConverterAnonymous8())).Map(new InternalDocumentConverterAnonymous9());
        }

        public IOptional<string> ReadEmbeddedStyleMap(IArchive zipFile)
        {
            return PassThroughException.Wrap(new InternalDocumentConverterAnonymous10(zipFile));
        }

        public InternalResult<string> ExtractRawText(INputStream stream)
        {
            return PassThroughException.Unwrap(new InternalDocumentConverterAnonymous12(stream, this));
        }

        public InternalResult<string> ExtractRawText(File file)
        {
            return PassThroughException.Unwrap(new InternalDocumentConverterAnonymous14(file, this));
        }

        public InternalResult<string> ExtractRawText(IOptional<Path> path, IArchive zipFile)
        {
            return (DocumentReader.ReadDocument(path, zipFile)).Map(new InternalDocumentConverterAnonymous15());
        }

        public static T WithDocxFile<T>(File file, IFunction<IArchive, T> function)
        {
            IArchive zipFile = new ZippedArchive(file);
            try {
                return function.Apply(zipFile);
            }
            finally {
                zipFile.Close();
            }
        }

        public static T WithDocxFile<T>(INputStream stream, IFunction<IArchive, T> function)
        {
            var zipFile = InMemoryArchive.FromStream(stream);
            try {
                return function.Apply(zipFile);
            }
            finally {
                zipFile.Close();
            }
        }

        public static string ExtractRawTextOfChildren(IHasChildren parent)
        {
            return ExtractRawText(parent.GetChildren());
        }

        public static string ExtractRawText(IList<IDocumentElement> nodes)
        {
            return String.Join("", Iterables.LazyMap(nodes, new InternalDocumentConverterAnonymous16()));
        }

        public static string ExtractRawText(IDocumentElement node)
        {
            return ((Casts.TryCast<Text>(typeof(Text), node)).Map(new InternalDocumentConverterAnonymous17())).OrElseGet(new InternalDocumentConverterAnonymous20(node));
        }
    }
}
