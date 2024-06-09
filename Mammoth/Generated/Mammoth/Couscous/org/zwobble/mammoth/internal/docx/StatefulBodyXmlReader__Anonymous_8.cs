using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReaderAnonymous8 : IFunction<string, IOptional<Style>> {
        private StatefulBodyXmlReader _thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader;

        internal StatefulBodyXmlReaderAnonymous8(StatefulBodyXmlReader thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader)
        {
            _thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader = thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader;
        }

        public IOptional<Style> Apply(string arg0)
        {
            return ((_thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader).Styles).FindParagraphStyleById(arg0);
        }
    }
}
