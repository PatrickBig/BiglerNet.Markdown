using Microsoft.AspNetCore.Components;

namespace Blazor.Markdown
{
    public partial class MarkdownViewer : ComponentBase
    {
        private string _content;

        [Parameter]
        public string Content
        {
            get
            {
                return _content;
            }
            set
            {
                _content = value;
                Html = Markdig.Markdown.ToHtml(Content);
            }
        }

        public string Html { get; private set; }
    }
}