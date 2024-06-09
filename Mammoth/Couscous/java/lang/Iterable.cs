using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.java.lang {
    internal interface Iterable<out T> {
        Iterator<T> iterator();
    }
}
