namespace WordProcessor
{
    partial class AutoCompleteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listWords = new ListBox();
            SuspendLayout();
            // 
            // listWords
            // 
            listWords.Dock = DockStyle.Fill;
            listWords.FormattingEnabled = true;
            listWords.ItemHeight = 15;
            listWords.Location = new Point(0, 0);
            listWords.Name = "listWords";
            listWords.Size = new Size(800, 450);
            listWords.TabIndex = 0;
            listWords.Click += listWords_Click;
            // 
            // AutoCompleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listWords);
            Name = "AutoCompleteForm";
            StartPosition = FormStartPosition.Manual;
            Text = "AutoCompleteForm";
            ResumeLayout(false);
        }

        #endregion

        public ListBox listWords;
    }
}