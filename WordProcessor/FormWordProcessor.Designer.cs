namespace WordProcessor
{
    partial class FormWordProcessor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            ToolStripMenuIDictionary = new ToolStripMenuItem();
            ToolStripMenuAddDictionary = new ToolStripMenuItem();
            ToolStripMenuUpdateDictionary = new ToolStripMenuItem();
            ToolStripMenuClearDictionary = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuIDictionary });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuIDictionary
            // 
            ToolStripMenuIDictionary.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuAddDictionary, ToolStripMenuUpdateDictionary, ToolStripMenuClearDictionary });
            ToolStripMenuIDictionary.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ToolStripMenuIDictionary.Name = "ToolStripMenuIDictionary";
            ToolStripMenuIDictionary.Size = new Size(66, 20);
            ToolStripMenuIDictionary.Text = "Словарь";
            // 
            // ToolStripMenuAddDictionary
            // 
            ToolStripMenuAddDictionary.Name = "ToolStripMenuAddDictionary";
            ToolStripMenuAddDictionary.Size = new Size(191, 22);
            ToolStripMenuAddDictionary.Text = "Создание словаря";
            ToolStripMenuAddDictionary.Click += ToolStripMenuAddDictionary_Click;
            // 
            // ToolStripMenuUpdateDictionary
            // 
            ToolStripMenuUpdateDictionary.Name = "ToolStripMenuUpdateDictionary";
            ToolStripMenuUpdateDictionary.Size = new Size(191, 22);
            ToolStripMenuUpdateDictionary.Text = "Обновление словаря";
            ToolStripMenuUpdateDictionary.Click += ToolStripMenuUpdateDictionary_Click;
            // 
            // ToolStripMenuClearDictionary
            // 
            ToolStripMenuClearDictionary.Name = "ToolStripMenuClearDictionary";
            ToolStripMenuClearDictionary.Size = new Size(191, 22);
            ToolStripMenuClearDictionary.Text = "Очистить словарь";
            ToolStripMenuClearDictionary.Click += ToolStripMenuClearDictionary_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 426);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += RichTextBox_TextChanged;
            richTextBox1.KeyDown += RichTextBox_KeyDown;
            richTextBox1.KeyPress += RichTextBox_KeyPress;
            // 
            // FormWordProcessor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormWordProcessor";
            Text = "Текстовый процессор";
            Deactivate += FormWordProcessor_Deactivate;
            MouseMove += FormWordProcessor_MouseMove;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripMenuIDictionary;
        private ToolStripMenuItem ToolStripMenuAddDictionary;
        private ToolStripMenuItem ToolStripMenuUpdateDictionary;
        private ToolStripMenuItem ToolStripMenuClearDictionary;
        public RichTextBox richTextBox1;
    }
}