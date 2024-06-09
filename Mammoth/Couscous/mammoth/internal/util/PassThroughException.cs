using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.lang;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util {
    internal class PassThroughException : RuntimeException {
        private readonly IOException _exception;

        internal PassThroughException(IOException exception)
        {
            _exception = exception;
        }

        internal static T wrap<T>(SupplierWithException<T, IOException> supplier)
        {
            try {
                return supplier.get();
            }
            catch (IOException exception) {
                throw new PassThroughException(exception);
            }
        }

        internal static T unwrap<T>(SupplierWithException<T, IOException> supplier)
        {
            try {
                return supplier.get();
            }
            catch (PassThroughException exception) {
                throw exception._exception;
            }
        }
    }
}
