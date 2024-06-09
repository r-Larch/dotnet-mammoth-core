namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.docx {
    internal class StatefulBodyXmlReader__Anonymous_24 : Mammoth.Couscous.org.zwobble.mammoth.@internal.util.InputStreamSupplier {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader _this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
        internal string _imagePath;
        internal StatefulBodyXmlReader__Anonymous_24(Mammoth.Couscous.org.zwobble.mammoth.@internal.docx.StatefulBodyXmlReader this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader, string imagePath) {
            this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader = this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader;
            this._imagePath = imagePath;
        }
        public Mammoth.Couscous.java.io.InputStream open() {
            return Mammoth.Couscous.org.zwobble.mammoth.@internal.archives.Archives.getInputStream((this._this_org__zwobble__mammoth__internal__docx__StatefulBodyXmlReader)._file, this._imagePath);
        }
    }
}

