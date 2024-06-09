using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_21 : Function<string, string> {
        internal Optional<string> _anchor;
        internal string _targetHref;

        internal StatefulBodyXmlReader__Anonymous_21(string targetHref, Optional<string> anchor)
        {
            _targetHref = targetHref;
            _anchor = anchor;
        }

        public string apply(string fragment)
        {
            return Uris.replaceFragment(_targetHref, (_anchor).get());
        }
    }
}
