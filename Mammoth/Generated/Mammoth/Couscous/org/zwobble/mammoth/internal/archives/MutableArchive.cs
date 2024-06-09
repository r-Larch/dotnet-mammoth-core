namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal interface IMutableArchive : IArchive {
        void WriteEntry(string path, string content);
    }
}
