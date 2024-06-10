using System.Linq;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.java.util.stream;

internal class Collectors {
    public static Collector<T, Mammoth.Couscous.java.lang.Object, Map<K, U>> toMap<T, K, U>(Function<T, K> var0, Function<T, U> var1)
    {
        return new MapCollector<T, K, U>(var0, var1);
    }
}

internal class MapCollector<T, K, V>(Function<T, K> var0, Function<T, V> var1) : Collector<T, Mammoth.Couscous.java.lang.Object, Map<K, V>> {
    public Map<K, V> Collect(Stream<T> stream)
    {
        var map = stream.ToDictionary(var0.apply, var1.apply);
        return new HashMap<K, V>(map);
    }
}
