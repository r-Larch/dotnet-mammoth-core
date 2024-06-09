using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.results;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReaderAnonymous9 : IFunction<string, InternalResult<IOptional<Style>>> {
        private IFunction<string, IOptional<Style>> _findStyleById;
        private string _styleType;
        private StatefulBodyXmlReader _thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader;

        internal StatefulBodyXmlReaderAnonymous9(StatefulBodyXmlReader thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader, string styleType, IFunction<string, IOptional<Style>> findStyleById)
        {
            _thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader = thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader;
            _styleType = styleType;
            _findStyleById = findStyleById;
        }

        public InternalResult<IOptional<Style>> Apply(string styleId)
        {
            return (_thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader).FindStyleById(_styleType, styleId, _findStyleById);
        }
    }
}
