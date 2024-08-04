using Markdig;
using Microsoft.AspNetCore.Components;

namespace BiglerNet.Markdown
{
    /// <summary>
    /// Renders Markdown as HTML.
    /// </summary>
    public partial class MarkdownViewer : ComponentBase
    {
        private static readonly MarkdownPipeline _pipeline = new MarkdownPipelineBuilder()
            .UseAdvancedExtensions()
            .UseEmojiAndSmiley()
            .Build();

        /// <summary>
        /// Gets or sets the content to be rendered.
        /// </summary>
        [Parameter]
        [EditorRequired]
        public string Content { get; set; }

        /// <summary>
        /// Gets the rendered HTML.
        /// </summary>
        public string Html { get; private set; }

        /// <inheritdoc/>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            if (!string.IsNullOrEmpty(Content))
            {
                Html = Markdig.Markdown.ToHtml(Content, _pipeline);
            }
        }
    }
}