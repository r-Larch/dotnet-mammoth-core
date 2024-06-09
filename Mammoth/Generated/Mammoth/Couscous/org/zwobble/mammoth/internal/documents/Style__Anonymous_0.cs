using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class StyleAnonymous0 : IFunction<string, string> {
        private string _styleIdDescription;

        internal StyleAnonymous0(string styleIdDescription)
        {
            _styleIdDescription = styleIdDescription;
        }

        public string Apply(string name)
        {
            return ((name + " (") + _styleIdDescription) + ")";
        }
    }
}
