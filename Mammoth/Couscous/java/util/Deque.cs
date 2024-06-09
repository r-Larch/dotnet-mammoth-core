namespace Mammoth.Couscous.java.util {
    internal interface IDeque<T> {
        int Size();
        T GetFirst();
        T GetLast();

        void Add(T value);
        T RemoveLast();
    }
}
