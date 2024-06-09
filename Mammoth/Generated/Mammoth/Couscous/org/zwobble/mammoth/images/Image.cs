using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.images {
    internal interface IMage {
        IOptional<string> GetAltText();
        string GetContentType();
        INputStream GetInputStream();
    }
}
