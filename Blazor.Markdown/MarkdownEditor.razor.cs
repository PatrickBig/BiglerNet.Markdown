using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Markdown
{
    public partial class MarkdownEditor : InputBase<string>
    {
        [Parameter]
        public string Rows { get; set; }

        protected override bool TryParseValueFromString(string value, [MaybeNullWhen(false)] out string result, [NotNullWhen(false)] out string validationErrorMessage)
        {
            result = value;
            validationErrorMessage = null;
            return true;
        }

        private void Keypress(KeyboardEventArgs args)
        {
            Console.WriteLine("Logging");
        }

        private void SelectionChanged(EventArgs e)
        {
            Console.WriteLine("Here");
        }
    }
}
