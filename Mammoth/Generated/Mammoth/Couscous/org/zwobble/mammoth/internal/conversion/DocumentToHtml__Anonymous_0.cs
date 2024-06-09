using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.documents;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtmlAnonymous0 : IFunction<Comment, string> {
        public string Apply(Comment arg0)
        {
            return arg0.GetCommentId();
        }
    }
}
