using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Style(string styleId, IOptional<string> name) {
        public string GetStyleId()
        {
            return styleId;
        }

        public IOptional<string> GetName()
        {
            return name;
        }

        public string Describe()
        {
            var styleIdDescription = $"Style ID: {styleId}";
            return name.Map(new StyleAnonymous0(styleIdDescription)).OrElse(styleIdDescription);
        }
    }
}
