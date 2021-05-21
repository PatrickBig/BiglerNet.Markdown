using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace BiglerNet.Markdown
{
    public partial class MarkdownEditor : InputBase<string>
    {
        [Parameter]
        public string Rows { get; set; }

        [Inject]
        private IJSRuntime JSRuntime { get; set; }

        protected override bool TryParseValueFromString(string value, [MaybeNullWhen(false)] out string result, [NotNullWhen(false)] out string validationErrorMessage)
        {
            result = value;
            validationErrorMessage = null;
            return true;
        }

        private async Task Keypress(KeyboardEventArgs args)
        {
            if (args.CtrlKey && args.Code == "KeyB")
            {
                await BoldSelectedText();
            }
            else if (args.CtrlKey && args.Code == "KeyI")
            {
                await ItalicizeText();
            }
        }

        private async Task BoldSelectedText()
        {
            var selectionInformation = await JSRuntime.InvokeAsync<TextSelectionInformation>("getSelectedTextInformation");

            Value = MarkdownFormatter.SurroundText(Value, "**", selectionInformation);

            StateHasChanged();
        }

        private async Task ItalicizeText()
        {
            var selectionInformation = await JSRuntime.InvokeAsync<TextSelectionInformation>("getSelectedTextInformation");

            Value = MarkdownFormatter.SurroundText(Value, "*", selectionInformation);

            StateHasChanged();
        }
    }
}
