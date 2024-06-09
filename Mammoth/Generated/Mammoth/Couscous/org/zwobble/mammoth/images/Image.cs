using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.images {
    internal interface Image {
        Optional<string> getAltText();
        string getContentType();
        InputStream getInputStream();
    }
}
