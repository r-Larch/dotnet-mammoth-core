namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.styles {
    internal interface IDocumentElementMatcher<in T> {
        bool Matches(T element);
    }
}
