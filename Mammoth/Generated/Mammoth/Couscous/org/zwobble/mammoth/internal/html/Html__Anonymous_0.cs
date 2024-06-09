using Mammoth.Couscous.java.lang;
using Mammoth.Couscous.java.util;
using Mammoth.Couscous.java.util.function;
using Mammoth.Couscous.org.zwobble.mammoth.@internal.util;


namespace Mammoth.Couscous.org.zwobble.mammoth.@internal.html {
    internal class HtmlAnonymous0(StringBuilder builder) : IConsumer<IHtmlNode> {
        public void Accept(IHtmlNode node)
        {
            HtmlWriter.Write(node, builder);
        }
    }

    internal class HtmlAnonymous1 : IFunction<IHtmlNode, ITerable<IHtmlNode>> {
        public ITerable<IHtmlNode> Apply(IHtmlNode node)
        {
            return Html.StripEmpty(node);
        }
    }

    internal class HtmlAnonymous2 : IHtmlNodeMapper<IList<IHtmlNode>> {
        public IList<IHtmlNode> Visit(HtmlElement element)
        {
            var children = Html.StripEmpty(element.GetChildren());
            if (children.IsEmpty() && !element.IsVoid()) {
                return Lists.List<IHtmlNode>();
            }

            return Lists.List<IHtmlNode>(new HtmlElement(element.GetTag(), children));
        }

        public IList<IHtmlNode> Visit(HtmlTextNode node)
        {
            if (node.GetValue().IsEmpty()) {
                return Lists.List<IHtmlNode>();
            }

            return Lists.List<IHtmlNode>(node);
        }

        public IList<IHtmlNode> Visit(HtmlForceWrite forceWrite)
        {
            return Lists.List<IHtmlNode>(forceWrite);
        }
    }

    internal class HtmlAnonymous3 : IHtmlNodeMapper<IHtmlNode> {
        public IHtmlNode Visit(HtmlElement element)
        {
            return new HtmlElement(element.GetTag(), Html.Collapse(element.GetChildren()));
        }

        public IHtmlNode Visit(HtmlTextNode node)
        {
            return node;
        }

        public IHtmlNode Visit(HtmlForceWrite forceWrite)
        {
            return forceWrite;
        }
    }

    internal class HtmlAnonymous4 : IFunction<IHtmlNode, IOptional<HtmlElement>> {
        public IOptional<HtmlElement> Apply(IHtmlNode last)
        {
            return Casts.TryCast<HtmlElement>(typeof(HtmlElement), last);
        }
    }

    internal class HtmlAnonymous5 : IBiFunction<HtmlElement, HtmlElement, bool> {
        public bool Apply(HtmlElement last, HtmlElement next)
        {
            if (next.IsCollapsible() && Html.IsMatch(last, next)) {
                var separator = next.GetSeparator();
                if (!separator.IsEmpty()) {
                    last.GetChildren().Add(Html.Text(separator));
                }

                {
                    var couscousDesugarForeachToFor4 = next.GetChildren().Iterator();
                    while (couscousDesugarForeachToFor4.HasNext()) {
                        var child = couscousDesugarForeachToFor4.Next();
                        Html.CollapsingAdd(last.GetChildren(), child);
                    }
                }
                return true;
            }

            return false;
        }
    }
}
