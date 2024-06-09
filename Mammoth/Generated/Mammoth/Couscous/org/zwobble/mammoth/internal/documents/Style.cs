using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Style {
        private IOptional<string> _name;
        private string _styleId;

        internal Style(string styleId, IOptional<string> name)
        {
            _styleId = styleId;
            _name = name;
        }

        public string GetStyleId()
        {
            return _styleId;
        }

        public IOptional<string> GetName()
        {
            return _name;
        }

        public string Describe()
        {
            var styleIdDescription = "Style ID: " + _styleId;
            return ((_name).Map(new StyleAnonymous0(styleIdDescription))).OrElse(styleIdDescription);
        }
    }
}
