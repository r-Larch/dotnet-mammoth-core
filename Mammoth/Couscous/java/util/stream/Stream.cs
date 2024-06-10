using Mammoth.Couscous.java.util.function;
using System.Collections.Generic;


namespace Mammoth.Couscous.java.util.stream;

internal interface Stream<T> : IEnumerable<T> {
    Stream<T> filter(Predicate<T> var1);
    Stream<R> flatMap<R>(Function<T, Stream<R>> var1);

    R collect<R, A>(Collector<T, A, R> var1);
}