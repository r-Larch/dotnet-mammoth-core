namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal interface DocumentElement {
        T accept<T, U>(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.DocumentElementVisitor<T, U> visitor, U context);
    }
}

