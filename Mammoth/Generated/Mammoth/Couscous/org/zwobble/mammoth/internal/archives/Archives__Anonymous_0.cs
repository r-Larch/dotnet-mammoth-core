using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.archives {
    internal class ArchivesAnonymous0 : ISupplier<IoException> {
        private string _name;

        internal ArchivesAnonymous0(string name)
        {
            _name = name;
        }

        public IoException Get()
        {
            return new IoException("Missing entry in file: " + _name);
        }
    }
}
