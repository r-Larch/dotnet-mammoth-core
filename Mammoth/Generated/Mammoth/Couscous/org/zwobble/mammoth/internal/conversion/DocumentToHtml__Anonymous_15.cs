using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlAnonymous15 : ISupplier<RuntimeException> {
        private string _commentId;

        internal DocumentToHtmlAnonymous15(string commentId)
        {
            _commentId = commentId;
        }

        public RuntimeException Get()
        {
            return new RuntimeException("Referenced comment could not be found, id: " + _commentId);
        }
    }
}
