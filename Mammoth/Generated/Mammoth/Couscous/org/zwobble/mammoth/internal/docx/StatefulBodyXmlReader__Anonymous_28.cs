using Mammoth.Couscous.java.io;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.archives;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_28 : InputStreamSupplier {
        private string _imagePath;
        private StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;

        internal StatefulBodyXmlReader__Anonymous_28(StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, string imagePath)
        {
            _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
            _imagePath = imagePath;
        }

        public InputStream open()
        {
            return Archives.getInputStream((_this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader)._file, _imagePath);
        }
    }
}
