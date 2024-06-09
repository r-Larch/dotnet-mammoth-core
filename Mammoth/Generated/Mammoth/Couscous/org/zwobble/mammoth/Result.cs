using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth {
    internal interface IResult<out T> {
        T GetValue();
        ISet<string> GetWarnings();
    }
}
