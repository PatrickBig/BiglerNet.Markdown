namespace BiglerNet.Markdown
{
    /// <summary>
    /// Information about the currently selected text in the editor control.
    /// </summary>
    public class TextSelectionInformation
    {
        /// <summary>
        /// Gets or sets the currently selected text in editor control.
        /// </summary>
        public string SelectedText { get; set; }

        /// <summary>
        /// Gets or sets the starting location of the selected text.
        /// </summary>
        public int SelectionStart { get; set; }

        /// <summary>
        /// Gets or sets the end location of the selected text.
        /// </summary>
        public int SelectionEnd { get; set; }
    }
}
