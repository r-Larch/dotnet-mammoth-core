using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_9 : Function<string, InternalResult<Optional<Style>>> {
        internal Function<string, Optional<Style>> _findStyleById;
        internal string _styleType;
        internal StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;

        internal StatefulBodyXmlReader__Anonymous_9(StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, string styleType, Function<string, Optional<Style>> findStyleById)
        {
            _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
            _styleType = styleType;
            _findStyleById = findStyleById;
        }

        public InternalResult<Optional<Style>> apply(string styleId)
        {
            return (_this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).findStyleById(_styleType, styleId, _findStyleById);
        }
    }
}
