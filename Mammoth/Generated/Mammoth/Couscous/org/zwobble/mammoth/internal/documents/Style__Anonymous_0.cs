using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class StyleAnonymous0(string styleIdDescription) : IFunction<string, string> {
        public string Apply(string name)
        {
            return $"{name} ({styleIdDescription})";
        }
    }
}
