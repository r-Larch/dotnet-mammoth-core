using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.java.util.stream;

internal readonly struct StreamSupport<T>(IEnumerable<T> enumerable) : Stream<T> {
    public IEnumerator<T> GetEnumerator() => enumerable.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public Stream<T> filter(Predicate<T> var1)
    {
        return new StreamSupport<T>(this.Where(var1.test));
    }

    public Stream<R> flatMap<R>(Function<T, Stream<R>> var1)
    {
        return new StreamSupport<R>(this.SelectMany(var1.apply));
    }

    public R collect<R, A>(Collector<T, A, R> var1)
    {
        return var1.Collect(this);
    }
}
