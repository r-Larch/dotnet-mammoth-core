using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ReadResult {
        internal static ReadResult _EMPTY_SUCCESS;
        internal List<DocumentElement> _elements;
        internal List<DocumentElement> _extra;
        internal Iterable<string> _warnings;

        static ReadResult()
        {
            _EMPTY_SUCCESS = success(Lists.list<DocumentElement>());
        }

        internal ReadResult(List<DocumentElement> elements, List<DocumentElement> extra, Iterable<string> warnings)
        {
            _elements = elements;
            _extra = extra;
            _warnings = warnings;
        }

        public static ReadResult flatMap<T>(Iterable<T> iterable, Function<T, ReadResult> function)
        {
            var results = Lists.eagerMap(iterable, function);
            return new ReadResult(Lists.eagerFlatMap(results, new ReadResult__Anonymous_0()), Lists.eagerFlatMap(results, new ReadResult__Anonymous_1()), Iterables.lazyFlatMap(results, new ReadResult__Anonymous_2()));
        }

        public static ReadResult map<T>(InternalResult<T> first, ReadResult second, BiFunction<T, List<DocumentElement>, DocumentElement> function)
        {
            return new ReadResult(Lists.list(function.apply(first.getValue(), second._elements)), second._extra, Iterables.lazyConcat(first.getWarnings(), second._warnings));
        }

        public static ReadResult success(DocumentElement element)
        {
            return success(Lists.list(element));
        }

        public static ReadResult success(List<DocumentElement> elements)
        {
            return new ReadResult(elements, Lists.list<DocumentElement>(), Lists.list<string>());
        }

        public static ReadResult emptyWithWarning(string warning)
        {
            return withWarning(Lists.list<DocumentElement>(), warning);
        }

        public static ReadResult withWarning(DocumentElement element, string warning)
        {
            return withWarning(Lists.list(element), warning);
        }

        public static ReadResult withWarning(List<DocumentElement> elements, string warning)
        {
            return new ReadResult(elements, Lists.list<DocumentElement>(), Lists.list(warning));
        }

        public ReadResult map(Function<List<DocumentElement>, DocumentElement> function)
        {
            return new ReadResult(Lists.list(function.apply(_elements)), _extra, _warnings);
        }

        public ReadResult flatMap(Function<List<DocumentElement>, ReadResult> function)
        {
            var result = function.apply(_elements);
            return new ReadResult(result._elements, Lists.eagerConcat(_extra, result._extra), Iterables.lazyConcat(_warnings, result._warnings));
        }

        public ReadResult toExtra()
        {
            return new ReadResult(Lists.list<DocumentElement>(), Lists.eagerConcat(_extra, _elements), _warnings);
        }

        public ReadResult appendExtra()
        {
            return new ReadResult(Lists.eagerConcat(_elements, _extra), Lists.list<DocumentElement>(), _warnings);
        }

        public InternalResult<List<DocumentElement>> toResult()
        {
            return new InternalResult<List<DocumentElement>>(_elements, _warnings);
        }
    }
}
