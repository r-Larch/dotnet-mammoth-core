namespace Mammoth.Couscous.org.zwobble.mammoth.images {
    internal interface Image {
        Mammoth.Couscous.java.util.Optional<string> getAltText();
        string getContentType();
        Mammoth.Couscous.java.io.InputStream getInputStream();
    }
}

