using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.stream;


namespace Mammoth.Couscous.java.util {
    interface Collection<T> : Iterable<T> {
        bool isEmpty();
        int size();
        bool contains(object value);

        void add(T value);

        Stream<T> stream();
    }
}
