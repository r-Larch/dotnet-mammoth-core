namespace Mammoth.Couscous.java.util.function {
    internal interface IBiFunction<T1, T2, TU> {
        TU Apply(T1 first, T2 second);
    }
}
