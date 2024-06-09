using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.nio.file;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.docx;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles.parsing;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.styles;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.html;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal {
    internal class InternalDocumentConverterAnonymous0(InternalDocumentConverter converter) : IFunction<IArchive, InternalResult<string>> {
        public InternalResult<string> Apply(IArchive zipFile)
        {
            return converter.ConvertToHtml(Optional.Empty<Path>(), zipFile);
        }
    }

    internal class InternalDocumentConverterAnonymous1(INputStream stream, InternalDocumentConverter converter) : ISupplierWithException<InternalResult<string>, IoException> {
        public InternalResult<string> Get()
        {
            return InternalDocumentConverter.WithDocxFile(stream, new InternalDocumentConverterAnonymous0(converter));
        }
    }

    internal class InternalDocumentConverterAnonymous10(IArchive zipFile) : ISupplierWithException<IOptional<string>, IoException> {
        public IOptional<string> Get()
        {
            return EmbeddedStyleMap.ReadStyleMap(zipFile);
        }
    }

    internal class InternalDocumentConverterAnonymous11(InternalDocumentConverter converter) : IFunction<IArchive, InternalResult<string>> {
        public InternalResult<string> Apply(IArchive zipFile)
        {
            return converter.ExtractRawText(Optional.Empty<Path>(), zipFile);
        }
    }

    internal class InternalDocumentConverterAnonymous12(INputStream stream, InternalDocumentConverter converter) : ISupplierWithException<InternalResult<string>, IoException> {
        public InternalResult<string> Get()
        {
            return InternalDocumentConverter.WithDocxFile(stream, new InternalDocumentConverterAnonymous11(converter));
        }
    }

    internal class InternalDocumentConverterAnonymous13(InternalDocumentConverter converter, File file) : IFunction<IArchive, InternalResult<string>> {
        public InternalResult<string> Apply(IArchive zipFile)
        {
            return converter.ExtractRawText(Optional.Of(file.ToPath()), zipFile);
        }
    }

    internal class InternalDocumentConverterAnonymous14(File file, InternalDocumentConverter converter) : ISupplierWithException<InternalResult<string>, IoException> {
        public InternalResult<string> Get()
        {
            return InternalDocumentConverter.WithDocxFile(file, new InternalDocumentConverterAnonymous13(converter, file));
        }
    }

    internal class InternalDocumentConverterAnonymous15 : IFunction<Document, string> {
        public string Apply(Document arg0)
        {
            return InternalDocumentConverter.ExtractRawTextOfChildren(arg0);
        }
    }

    internal class InternalDocumentConverterAnonymous16 : IFunction<IDocumentElement, string> {
        public string Apply(IDocumentElement node)
        {
            return InternalDocumentConverter.ExtractRawText(node);
        }
    }

    internal class InternalDocumentConverterAnonymous17 : IFunction<Text, string> {
        public string Apply(Text arg0)
        {
            return arg0.GetValue();
        }
    }

    internal class InternalDocumentConverterAnonymous18 : IFunction<IHasChildren, IList<IDocumentElement>> {
        public IList<IDocumentElement> Apply(IHasChildren arg0)
        {
            return arg0.GetChildren();
        }
    }

    internal class InternalDocumentConverterAnonymous19 : IFunction<Paragraph, string> {
        public string Apply(Paragraph paragraph)
        {
            return "\n\n";
        }
    }

    internal class InternalDocumentConverterAnonymous2(InternalDocumentConverter converter, File file) : IFunction<IArchive, InternalResult<string>> {
        public InternalResult<string> Apply(IArchive zipFile)
        {
            return converter.ConvertToHtml(Optional.Of(file.ToPath()), zipFile);
        }
    }

    internal class InternalDocumentConverterAnonymous20(IDocumentElement node) : ISupplier<string> {
        public string Get()
        {
            var children = Casts.TryCast<IHasChildren>(typeof(IHasChildren), node).Map(new InternalDocumentConverterAnonymous18()).OrElse(Lists.List<IDocumentElement>());
            var suffix = Casts.TryCast<Paragraph>(typeof(Paragraph), node).Map(new InternalDocumentConverterAnonymous19()).OrElse("");
            return InternalDocumentConverter.ExtractRawText(children) + suffix;
        }
    }

    internal class InternalDocumentConverterAnonymous3(File file, InternalDocumentConverter converter) : ISupplierWithException<InternalResult<string>, IoException> {
        public InternalResult<string> Get()
        {
            return InternalDocumentConverter.WithDocxFile(file, new InternalDocumentConverterAnonymous2(converter, file));
        }
    }

    internal class InternalDocumentConverterAnonymous4 : IFunction<string, StyleMap> {
        public StyleMap Apply(string arg0)
        {
            return StyleMapParser.Parse(arg0);
        }
    }

    internal class InternalDocumentConverterAnonymous5(InternalDocumentConverter converter) : IFunction<StyleMap, DocumentToHtmlOptions> {
        public DocumentToHtmlOptions Apply(StyleMap arg0)
        {
            return converter.Options.AddEmbeddedStyleMap(arg0);
        }
    }

    internal class InternalDocumentConverterAnonymous6(DocumentToHtmlOptions conversionOptions) : IFunction<Document, InternalResult<IList<IHtmlNode>>> {
        public InternalResult<IList<IHtmlNode>> Apply(Document nodes)
        {
            return DocumentToHtml.ConvertToHtml(nodes, conversionOptions);
        }
    }

    internal class InternalDocumentConverterAnonymous7 : IFunction<IList<IHtmlNode>, IList<IHtmlNode>> {
        public IList<IHtmlNode> Apply(IList<IHtmlNode> arg0)
        {
            return Html.StripEmpty(arg0);
        }
    }

    internal class InternalDocumentConverterAnonymous8 : IFunction<IList<IHtmlNode>, IList<IHtmlNode>> {
        public IList<IHtmlNode> Apply(IList<IHtmlNode> arg0)
        {
            return Html.Collapse(arg0);
        }
    }

    internal class InternalDocumentConverterAnonymous9 : IFunction<IList<IHtmlNode>, string> {
        public string Apply(IList<IHtmlNode> arg0)
        {
            return Html.Write(arg0);
        }
    }
}
