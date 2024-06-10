namespace Mammoth.Couscous.java.util.stream;

internal interface Collector<T, A, R> {
    R Collect(Stream<T> stream);
}
