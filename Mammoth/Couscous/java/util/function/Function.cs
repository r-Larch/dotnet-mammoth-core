namespace Mammoth.Couscous.java.util.function {
    internal interface IFunction<T, TU> {
        TU Apply(T arg);
    }
}
