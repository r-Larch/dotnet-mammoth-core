using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.java.lang {
    internal interface ITerable<out T> {
        ITerator<T> Iterator();
    }
}
