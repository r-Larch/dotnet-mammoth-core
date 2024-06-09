namespace Mammoth.Couscous.java.util {
    internal interface ITerator<out T> {
        bool HasNext();
        T Next();
    }
}
