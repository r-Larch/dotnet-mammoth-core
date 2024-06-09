using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReaderAnonymous10 : IBiFunction<string, string, IOptional<NumberingLevel>> {
        private StatefulBodyXmlReader _thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader;

        internal StatefulBodyXmlReaderAnonymous10(StatefulBodyXmlReader thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader)
        {
            _thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader = thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader;
        }

        public IOptional<NumberingLevel> Apply(string arg0, string arg1)
        {
            return ((_thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader).Numbering).FindLevel(arg0, arg1);
        }
    }
}
