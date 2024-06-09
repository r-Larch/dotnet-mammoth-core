using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReaderAnonymous21 : IFunction<string, string> {
        private IOptional<string> _anchor;
        private string _targetHref;

        internal StatefulBodyXmlReaderAnonymous21(string targetHref, IOptional<string> anchor)
        {
            _targetHref = targetHref;
            _anchor = anchor;
        }

        public string Apply(string fragment)
        {
            return Uris.ReplaceFragment(_targetHref, (_anchor).Get());
        }
    }
}
