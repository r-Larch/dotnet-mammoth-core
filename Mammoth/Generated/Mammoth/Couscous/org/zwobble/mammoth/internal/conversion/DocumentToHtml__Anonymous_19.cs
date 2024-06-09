namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion {
    internal class DocumentToHtml__Anonymous_19 : Mammoth.Couscous.java.util.function.Function<string, Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>> {
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml _this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
        internal Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image _image;
        internal DocumentToHtml__Anonymous_19(Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml this_org__zwobble__mammoth__internal__conversion__DocumentToHtml, Mammoth.Couscous.org.zwobble.mammoth.@internal.documents.Image image) {
            this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml = this_org__zwobble__mammoth__internal__conversion__DocumentToHtml;
            this._image = image;
        }
        public Mammoth.Couscous.java.util.List<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode> apply(string contentType) {
            try {
                Mammoth.Couscous.java.util.Map<string, string> attributes = new Mammoth.Couscous.java.util.HashMap<string, string>(((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._imageConverter).convert(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_17(this._image, contentType)));
                ((this._image).getAltText()).ifPresent(new Mammoth.Couscous.org.zwobble.mammoth.@internal.conversion.DocumentToHtml__Anonymous_18(attributes));
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>(Mammoth.Couscous.org.zwobble.mammoth.@internal.html.Html.element("img", attributes));
            } catch (Mammoth.Couscous.java.io.IOException exception) {
                ((this._this_org__zwobble__mammoth__internal__conversion__DocumentToHtml)._warnings).add(exception.getMessage());
                return Mammoth.Couscous.org.zwobble.mammoth.@internal.util.Lists.list<Mammoth.Couscous.org.zwobble.mammoth.@internal.html.HtmlNode>();
            }
        }
    }
}

