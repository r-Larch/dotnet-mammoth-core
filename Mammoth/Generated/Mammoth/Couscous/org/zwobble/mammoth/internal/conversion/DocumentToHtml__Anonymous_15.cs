using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util.function;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_15 : Supplier<RuntimeException> {
        internal string _commentId;

        internal DocumentToHtml__Anonymous_15(string commentId)
        {
            _commentId = commentId;
        }

        public RuntimeException get()
        {
            return new RuntimeException("Referenced comment could not be found, id: " + _commentId);
        }
    }
}
