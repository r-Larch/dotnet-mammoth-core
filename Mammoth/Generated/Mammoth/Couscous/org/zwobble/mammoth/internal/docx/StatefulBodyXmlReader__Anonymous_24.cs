using Mammoth.Couscous.java.io;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReaderAnonymous24 : INputStreamSupplier {
        private string _imagePath;
        private StatefulBodyXmlReader _thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader;

        internal StatefulBodyXmlReaderAnonymous24(StatefulBodyXmlReader thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader, string imagePath)
        {
            _thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader = thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader;
            _imagePath = imagePath;
        }

        public INputStream Open()
        {
            return Archives.GetInputStream((_thisOrgZwobbleMammothInternalDocxStatefulBodyXmlReader).File, _imagePath);
        }
    }
}
