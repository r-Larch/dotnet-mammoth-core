namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class ReadResult {
        internal static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult _EMPTY_SUCCESS;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _elements;
        internal Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> _extra;
        internal Mammoth.Couscous.java.lang.Iterable<string> _warnings;
        static ReadResult() {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult._EMPTY_SUCCESS = Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>());
        }
        internal ReadResult(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> elements, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> extra, Mammoth.Couscous.java.lang.Iterable<string> warnings) {
            this._elements = elements;
            this._extra = extra;
            this._warnings = warnings;
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult flatMap<T>(Mammoth.Couscous.java.lang.Iterable<T> iterable, Mammoth.Couscous.java.util.function.Function<T, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult> function) {
            Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult> results = Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerMap<T, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult>(iterable, function);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(results, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult__Anonymous_0()), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(results, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult__Anonymous_1()), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyFlatMap<Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult, string>(results, new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult__Anonymous_2()));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult map<T>(Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<T> first, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult second, Mammoth.Couscous.java.util.function.BiFunction<T, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> function) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(function.apply(first.getValue(), second._elements)), second._extra, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyConcat<string>(first.getWarnings(), second._warnings));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult success(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement element) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.success(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(element));
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult success(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> elements) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult(elements, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>());
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult emptyWithWarning(string warning) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.withWarning(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(), warning);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult withWarning(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement element, string warning) {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult.withWarning(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(element), warning);
        }
        public static Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult withWarning(Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> elements, string warning) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult(elements, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<string>(warning));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult map(Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement> function) {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(function.apply(this._elements)), this._extra, this._warnings);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult flatMap(Mammoth.Couscous.java.util.function.Function<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>, Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult> function) {
            Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult result = function.apply(this._elements);
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult(result._elements, Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(this._extra, result._extra), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Iterables.lazyConcat<string>(this._warnings, result._warnings));
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult toExtra() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(this._extra, this._elements), this._warnings);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult appendExtra() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.ReadResult(Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.eagerConcat<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(this._elements, this._extra), Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>(), this._warnings);
        }
        public Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>> toResult() {
            return new Mammoth.Couscous.org.zwobble.mammoth.@internal.results.InternalResult<Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElement>>(this._elements, this._warnings);
        }
    }
}

