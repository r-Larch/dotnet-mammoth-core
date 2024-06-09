namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.documents {
    internal interface IDocumentElementVisitor<out T, in TU> {
        T Visit(Paragraph paragraph, TU context);
        T Visit(Run run, TU context);
        T Visit(Text text, TU context);
        T Visit(Tab tab, TU context);
        T Visit(Break lineBreak, TU context);
        T Visit(Table table, TU context);
        T Visit(TableRow tableRow, TU context);
        T Visit(TableCell tableCell, TU context);
        T Visit(Hyperlink hyperlink, TU context);
        T Visit(Bookmark bookmark, TU context);
        T Visit(NoteReference noteReference, TU context);
        T Visit(CommentReference commentReference, TU context);
        T Visit(Image image, TU context);
    }
}
