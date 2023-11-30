using WordProcessor.ApplicationLayer;
/*форма текстового процессора*/
namespace WordProcessor
{
    public partial class FormWordProcessor : Form
    {
        private IInputService _InputService;
        private IDictionaryService _DictionaryService;
        private AutoCompleteForm autoCompleteForm;
        /*—писок всех слов в словаре*/
        private List<string> allWords;
        public FormWordProcessor(IInputService inputService, IDictionaryService dictionaryService)
        {
            _InputService = inputService;
            _DictionaryService = dictionaryService;
            InitializeComponent();
            allWords = _InputService.GetWordsDictionary().Select(option => option.word).ToList();
            autoCompleteForm = new AutoCompleteForm(allWords);
        }
        private void FormWordProcessor_Deactivate(object sender, EventArgs e)
        {
            if (ActiveForm != this)
            {
                if (ActiveForm != autoCompleteForm)
                {
                    autoCompleteForm.Hide();
                }
            }
        }
        /*—обытие закрывает форму автодополнени€ при нажатии Enter*/
        private void RichTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                autoCompleteForm.Hide();
            }
        }
        /*—обытие показывает при печатании текста форму автодополнени€*/
        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = richTextBox1.SelectionStart;
            string text = richTextBox1.Text;
            var v = richTextBox1.Text;

            int caretPosition = richTextBox1.GetFirstCharIndexOfCurrentLine() + selectionStart;
            int wordStart = richTextBox1.Text.LastIndexOf(' ', Math.Max(0, caretPosition - 1)) + 1;
            int wordEnd = text.IndexOf(' ', caretPosition);
            if (wordEnd == -1)
            {
                wordEnd = text.Length;
            }
            string currentWord = text.Substring(wordStart, wordEnd - wordStart).Trim();
            if (currentWord.Length > 2)
            {
                /*ќбновл€ем список вариантов автозаполнени€ на основе текущего слова*/
                List<string> matchingOptions = allWords
                    .Where(option => option.StartsWith(currentWord, StringComparison.OrdinalIgnoreCase)).Take(5)
                    .ToList();
                /*ќтображаем форму с вариантами автозаполнени€ р€дом с текущим словом*/
                autoCompleteForm.DisplayAutoCompleteOptions(matchingOptions, richTextBox1, caretPosition, wordStart);
            }
            else
            {
                autoCompleteForm.Hide();
            }

        }
        /*—обытие при перемещении формы. «акрываетс€ окно автодополнени€*/
        private void FormWordProcessor_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                autoCompleteForm.Hide();
            }
        }
        private void ToolStripMenuAddDictionary_Click(object sender, EventArgs e)
        {
            var filePath = GetStringPathInOpenDialog();
            _DictionaryService.AddDictionary(filePath);
            allWords = _InputService.GetWordsDictionary().Select(option => option.word).ToList();

        }

        private void ToolStripMenuUpdateDictionary_Click(object sender, EventArgs e)
        {
            var filePath = GetStringPathInOpenDialog();
            _DictionaryService.UpdateDictionary(filePath);
            allWords = _InputService.GetWordsDictionary().Select(option => option.word).ToList();
        }

        /*событие отчищает словарь*/
        private void ToolStripMenuClearDictionary_Click(object sender, EventArgs e)
        {
            autoCompleteForm.Hide();
            _DictionaryService.ClearDictionary();
            allWords.Clear();
        }
        private string GetStringPathInOpenDialog()
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files(*.txt)| *.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                autoCompleteForm.Hide();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    /*ѕолучаем путь к указанному файлу*/
                    filePath = openFileDialog.FileName;
                }
            }
            return filePath;
        }

        private void RichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                DeleteSpace();
            }
            if(e.KeyChar == ',')
            {
                DeleteSpace();
            }
        }
        private void DeleteSpace()
        {
            int currentPosition = richTextBox1.SelectionStart;
            string text = richTextBox1.Text;
            if (currentPosition > 0 && text[currentPosition-1]== ' ')
            {
                if (currentPosition>1 && text[currentPosition - 2]!=' ')
                {
                    richTextBox1.Text = text.Remove(currentPosition - 1, 1);
                }
            }
                
        }
    }
}
