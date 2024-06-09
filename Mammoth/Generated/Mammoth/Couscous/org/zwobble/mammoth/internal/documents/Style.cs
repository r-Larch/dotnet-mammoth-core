using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal class Style {
        private Optional<string> _name;
        private string _styleId;

        internal Style(string styleId, Optional<string> name)
        {
            _styleId = styleId;
            _name = name;
        }

        public string getStyleId()
        {
            return _styleId;
        }

        public Optional<string> getName()
        {
            return _name;
        }

        public string describe()
        {
            var styleIdDescription = "Style ID: " + _styleId;
            return ((_name).map(new Style__Anonymous_0(styleIdDescription))).orElse(styleIdDescription);
        }
    }
}
