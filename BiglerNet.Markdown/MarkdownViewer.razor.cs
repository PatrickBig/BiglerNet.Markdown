using Markdig;
using Microsoft.AspNetCore.Components;

namespace BiglerNet.Markdown
{
    public partial class MarkdownViewer : ComponentBase
    {
        private static MarkdownPipeline pipeline = new MarkdownPipelineBuilder()
            .UseAdvancedExtensions()
            .UseEmojiAndSmiley()
            .Build();

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
            }
        }

        [Parameter]
        public string LinkTarget { get; set; }

        public string Html { get; private set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();

            if (!string.IsNullOrEmpty(_content))
            {
                Html = Markdig.Markdown.ToHtml(Content, pipeline);
            }
        }
    }
}