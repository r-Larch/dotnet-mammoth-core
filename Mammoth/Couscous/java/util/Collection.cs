using Mammoth.Couscous.java.lang;


namespace Mammoth.Couscous.java.util {
    internal interface ICollection<T> : ITerable<T> {
        bool IsEmpty();
        int Size();
        bool Contains(object value);

        void Add(T value);
    }
}
