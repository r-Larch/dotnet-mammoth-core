namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal interface MutableArchive : Archive {
        void writeEntry(string path, string content);
    }
}
