using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_0 : Function<Comment, string> {
        public string apply(Comment arg0)
        {
            return arg0.getCommentId();
        }
    }
}
