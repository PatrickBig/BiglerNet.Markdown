using Microsoft.AspNetCore.Components;

namespace Blazor.Markdown
{
    public partial class MarkdownView : ComponentBase
    {
        [Parameter]
        public string Content { get; set; }

        public string Html { get; private set; }

        protected override void OnInitialized()
        {
            Html = Markdig.Markdown.ToHtml(Content);
        }
    }
}