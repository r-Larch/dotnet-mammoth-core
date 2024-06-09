using Mammoth.Couscous.java.io;
using Mammoth.Couscous.java.lang;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.util {
    internal class PassThroughException : RuntimeException {
        private readonly IoException _exception;

        internal PassThroughException(IoException exception)
        {
            _exception = exception;
        }

        internal static T Wrap<T>(ISupplierWithException<T, IoException> supplier)
        {
            try {
                return supplier.Get();
            }
            catch (IoException exception) {
                throw new PassThroughException(exception);
            }
        }

        internal static T Unwrap<T>(ISupplierWithException<T, IoException> supplier)
        {
            try {
                return supplier.Get();
            }
            catch (PassThroughException exception) {
                throw exception._exception;
            }
        }
    }
}
