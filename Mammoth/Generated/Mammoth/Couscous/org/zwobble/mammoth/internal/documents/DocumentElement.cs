namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal interface DocumentElement {
        T accept<T, U>(DocumentElementVisitor<T, U> visitor, U context);
    }
}
