namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal interface IDocumentElement {
        T Accept<T, TU>(IDocumentElementVisitor<T, TU> visitor, TU context);
    }
}
