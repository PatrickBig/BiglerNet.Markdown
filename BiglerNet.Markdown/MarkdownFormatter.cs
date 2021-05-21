using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiglerNet.Markdown
{
    public class MarkdownFormatter
    {
        public static string SurroundText(string value, string surroundWith, TextSelectionInformation textSelectionInformation)
        {
            if (!string.IsNullOrEmpty(value))
            {
                StringBuilder sb = new StringBuilder(value.Length);
                
                bool hasStaringText = textSelectionInformation.SelectionStart > 0;
                bool hasEndingText = textSelectionInformation.SelectionEnd < value.Length;

                if (hasStaringText)
                {
                    sb.Append(value.Substring(0, textSelectionInformation.SelectionStart));
                }

                sb.Append($"{surroundWith}{textSelectionInformation.SelectedText}{surroundWith}");

                if (hasEndingText)
                {
                    sb.Append(value.Substring(textSelectionInformation.SelectionEnd, value.Length - textSelectionInformation.SelectionEnd - 1));
                }

                return sb.ToString();
            }

            return value;
        }
    }
}
