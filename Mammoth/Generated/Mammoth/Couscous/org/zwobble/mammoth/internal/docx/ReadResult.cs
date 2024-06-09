using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ReadResult {
        public static ReadResult EmptySuccess;
        public IList<IDocumentElement> Elements;
        public IList<IDocumentElement> Extra;
        public ITerable<string> Warnings;

        static ReadResult()
        {
            EmptySuccess = Success(Lists.List<IDocumentElement>());
        }

        internal ReadResult(IList<IDocumentElement> elements, IList<IDocumentElement> extra, ITerable<string> warnings)
        {
            Elements = elements;
            Extra = extra;
            Warnings = warnings;
        }

        public static ReadResult FlatMap<T>(ITerable<T> iterable, IFunction<T, ReadResult> function)
        {
            var results = Lists.EagerMap(iterable, function);
            return new ReadResult(Lists.EagerFlatMap(results, new ReadResultAnonymous0()), Lists.EagerFlatMap(results, new ReadResultAnonymous1()), Iterables.LazyFlatMap(results, new ReadResultAnonymous2()));
        }

        public static ReadResult Map<T>(InternalResult<T> first, ReadResult second, IBiFunction<T, IList<IDocumentElement>, IDocumentElement> function)
        {
            return new ReadResult(Lists.List(function.Apply(first.GetValue(), second.Elements)), second.Extra, Iterables.LazyConcat(first.GetWarnings(), second.Warnings));
        }

        public static ReadResult Success(IDocumentElement element)
        {
            return Success(Lists.List(element));
        }

        public static ReadResult Success(IList<IDocumentElement> elements)
        {
            return new ReadResult(elements, Lists.List<IDocumentElement>(), Lists.List<string>());
        }

        public static ReadResult EmptyWithWarning(string warning)
        {
            return WithWarning(Lists.List<IDocumentElement>(), warning);
        }

        public static ReadResult WithWarning(IDocumentElement element, string warning)
        {
            return WithWarning(Lists.List(element), warning);
        }

        public static ReadResult WithWarning(IList<IDocumentElement> elements, string warning)
        {
            return new ReadResult(elements, Lists.List<IDocumentElement>(), Lists.List(warning));
        }

        public ReadResult Map(IFunction<IList<IDocumentElement>, IDocumentElement> function)
        {
            return new ReadResult(Lists.List(function.Apply(Elements)), Extra, Warnings);
        }

        public ReadResult FlatMap(IFunction<IList<IDocumentElement>, ReadResult> function)
        {
            var result = function.Apply(Elements);
            return new ReadResult(result.Elements, Lists.EagerConcat(Extra, result.Extra), Iterables.LazyConcat(Warnings, result.Warnings));
        }

        public ReadResult ToExtra()
        {
            return new ReadResult(Lists.List<IDocumentElement>(), Lists.EagerConcat(Extra, Elements), Warnings);
        }

        public ReadResult AppendExtra()
        {
            return new ReadResult(Lists.EagerConcat(Elements, Extra), Lists.List<IDocumentElement>(), Warnings);
        }

        public InternalResult<IList<IDocumentElement>> ToResult()
        {
            return new InternalResult<IList<IDocumentElement>>(Elements, Warnings);
        }
    }
}
