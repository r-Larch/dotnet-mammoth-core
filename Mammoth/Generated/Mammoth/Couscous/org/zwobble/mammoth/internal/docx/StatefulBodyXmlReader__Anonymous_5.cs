using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.xml;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_5 : Function<XmlElement, ReadResult> {
        private StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;

        internal StatefulBodyXmlReader__Anonymous_5(StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader)
        {
            _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        }

        public ReadResult apply(XmlElement arg0)
        {
            return (_this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader).readElement(arg0);
        }
    }
}
