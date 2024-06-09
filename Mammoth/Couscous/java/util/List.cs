namespace Mammoth.Couscous.java.util {
    internal interface IList<T> : ICollection<T> {
        T Get(int index);
        IList<T> SubList(int fromIndex, int toIndex);
        T Remove(int index);
        void Set(int index, T value);
        void Clear();
    }
}
