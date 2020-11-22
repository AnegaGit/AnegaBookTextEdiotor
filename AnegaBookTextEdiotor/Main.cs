using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Main : Form
    {
        private string testText;
        private string[] displayText = { "" };
        private string[] splitText = { "<p>" };
        private List<RichTextBox> pages = new List<RichTextBox>();
        private int firstPage = 0;


        public Main()
        {
            InitializeComponent();
            pages.Add(Page0);
            pages.Add(Page1);
            pages.Add(Page2);
            pages.Add(Page3);
            pages.Add(Page4);
            pages.Add(Page5);
            pages.Add(Page6);
            pages.Add(Page7);
            pages.Add(Page8);
            pages.Add(Page9);
        }

        private void ButtonApplyText_Click(object sender, EventArgs e)
        {
            testText = ioBookText.Text;
            displayText = testText.Split(splitText, StringSplitOptions.None);
            labelBookLength.Text = string.Format("Book has {0} pages", displayText.Length);

            ioFirstPage.Maximum = Math.Max(0, displayText.Length - 7);

            if (displayText.Length <= pages.Count-2 || firstPage >= displayText.Length)
            {
                firstPage = 0;
            }

            int current = 0;
            for (int i = firstPage; i < displayText.Length; i++)
            {
                var sb = new StringBuilder();
                sb.Append(@"{\rtf1\ansi \b0 \i0 ");
                string finalText = displayText[i].Replace("\n", @"\line ").Replace("<b>", @"\b ").Replace("</b>", @"\b0 ").Replace("<i>", @"\i ").Replace("</i>", @"\i0 ").Replace("  ", " ");
                sb.Append(finalText);
                sb.Append(@"}");
                pages[current].Rtf = sb.ToString();
                pages[current].BackColor = Color.White;
                current++;
                if (current >= pages.Count) break;
            }
            if (current < pages.Count - 1)
            {
                for (int i = current; i < pages.Count; i++)
                {
                    pages[i].Rtf = "";
                    pages[i].BackColor = Color.LightGray;
                }
            }


        }

        private void buttonTexxtToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ioBookText.Text);
        }

        private void ioFirstPage_ValueChanged(object sender, EventArgs e)
        {
            firstPage = (int)ioFirstPage.Value;
        }
    }
}
