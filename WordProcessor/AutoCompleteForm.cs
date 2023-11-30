/*форма меню автозаполнения */
namespace WordProcessor
{
    public partial class AutoCompleteForm : Form
    {
        public int wordStart;
        public int length;
        public AutoCompleteForm(List<string> options)
        {
            ShowInTaskbar = false;
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            listWords.Items.AddRange(options.ToArray());
            Size = new Size(200, 100);
        }

        public void DisplayAutoCompleteOptions(List<string> options, RichTextBox richTextBox, int caretPosition, int wordStart)
        {
            length = richTextBox.Text.Length;
            Point caretPosScreen = richTextBox.PointToScreen(richTextBox.GetPositionFromCharIndex(caretPosition));
            Location = new Point(caretPosScreen.X - richTextBox.Location.X, caretPosScreen.Y + richTextBox.Location.Y);
            /* Обновляем ListBox с вариантами и располагаем его рядом с текущим словом*/
            listWords.Items.Clear();
            listWords.Items.AddRange(options.ToArray());
            this.wordStart = wordStart;

            TopMost = true;
            Visible = options.Count > 0;
            richTextBox.SelectionStart = richTextBox.Text.Length;
            richTextBox.Focus();
        }

        private void listWords_Click(object sender, EventArgs e)
        {
            /* Заполняем RichTextBox выбранным вариантом при выборе из ListBox*/
            FormWordProcessor mainForm = Application.OpenForms.OfType<FormWordProcessor>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.richTextBox1.Select(wordStart, length - wordStart);
                mainForm.richTextBox1.SelectedText = listWords.SelectedItem?.ToString() + " ";
                Visible = false;
            }
        }
    }
}
