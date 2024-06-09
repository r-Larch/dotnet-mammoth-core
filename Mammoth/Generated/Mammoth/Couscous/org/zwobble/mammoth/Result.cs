using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth {
    internal interface Result<T> {
        T getValue();
        Set<string> getWarnings();
    }
}
