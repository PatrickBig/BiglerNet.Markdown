using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Markdown
{
    public partial class MarkdownView : ComponentBase
    {
        [Parameter]
        public string Content { get; set; }
    }
}
