namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal interface DocumentElementVisitor<T, U> {
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Paragraph paragraph, U context);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Run run, U context);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Text text, U context);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Tab tab, U context);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Break lineBreak, U context);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Table table, U context);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableRow tableRow, U context);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.TableCell tableCell, U context);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Hyperlink hyperlink, U context);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Bookmark bookmark, U context);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.NoteReference noteReference, U context);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.CommentReference commentReference, U context);
        T visit(Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image image, U context);
    }
}

