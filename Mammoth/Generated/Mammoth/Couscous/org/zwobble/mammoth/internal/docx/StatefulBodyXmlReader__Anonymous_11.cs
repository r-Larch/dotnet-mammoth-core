using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_11 : Function<List<DocumentElement>, ReadResult> {
        private StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;

        internal StatefulBodyXmlReader__Anonymous_11(StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader)
        {
            _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        }

        public ReadResult apply(List<DocumentElement> arg0)
        {
            return (_this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).calculateRowspans(arg0);
        }
    }
}
