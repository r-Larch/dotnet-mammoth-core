using Mammoth.Couscous.java.lang;


namespace Mammoth.Couscous.java.util {
    internal interface IQueue<T> : ITerable<T> {
        void Add(T value);
        T Remove();
    }
}
