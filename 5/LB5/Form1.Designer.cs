namespace TextEditorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem task1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem task2ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.RadioButton rbColor;
        private System.Windows.Forms.RadioButton rbFont;
        private System.Windows.Forms.RadioButton rbSize;
        private System.Windows.Forms.CheckBox cbColor;
        private System.Windows.Forms.CheckBox cbFont;
        private System.Windows.Forms.CheckBox cbSize;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuEdit = new ToolStripMenuItem();
            task1ToolStripMenuItem = new ToolStripMenuItem();
            task2ToolStripMenuItem = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            textBoxInput = new TextBox();
            textBoxOutput = new TextBox();
            labelTask = new Label();
            textBoxInfo = new TextBox();
            rbColor = new RadioButton();
            rbFont = new RadioButton();
            rbSize = new RadioButton();
            cbColor = new CheckBox();
            cbFont = new CheckBox();
            cbSize = new CheckBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuEdit, menuExit });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(600, 28);
            menuStrip1.TabIndex = 10;
            // 
            // menuEdit
            // 
            menuEdit.DropDownItems.AddRange(new ToolStripItem[] { task1ToolStripMenuItem, task2ToolStripMenuItem });
            menuEdit.Name = "menuEdit";
            menuEdit.Size = new Size(110, 24);
            menuEdit.Text = "Редагування";
            // 
            // task1ToolStripMenuItem
            // 
            task1ToolStripMenuItem.Name = "task1ToolStripMenuItem";
            task1ToolStripMenuItem.Size = new Size(224, 26);
            task1ToolStripMenuItem.Text = "Завдання 1";
            task1ToolStripMenuItem.Click += task1ToolStripMenuItem_Click;
            // 
            // task2ToolStripMenuItem
            // 
            task2ToolStripMenuItem.Name = "task2ToolStripMenuItem";
            task2ToolStripMenuItem.Size = new Size(224, 26);
            task2ToolStripMenuItem.Text = "Завдання 2";
            task2ToolStripMenuItem.Click += task2ToolStripMenuItem_Click;
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(60, 24);
            menuExit.Text = "Вихід";
            menuExit.Click += menuExit_Click;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(30, 50);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.ScrollBars = ScrollBars.Vertical;
            textBoxInput.Size = new Size(400, 120);
            textBoxInput.TabIndex = 0;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(30, 190);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.ScrollBars = ScrollBars.Vertical;
            textBoxOutput.Size = new Size(400, 120);
            textBoxOutput.TabIndex = 1;
            // 
            // labelTask
            // 
            labelTask.Location = new Point(30, 20);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(100, 23);
            labelTask.TabIndex = 2;
            labelTask.Text = "Оберіть завдання";
            // 
            // textBoxInfo
            // 
            textBoxInfo.Location = new Point(30, 330);
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Size = new Size(400, 27);
            textBoxInfo.TabIndex = 3;
            // 
            // rbColor
            // 
            rbColor.Location = new Point(470, 60);
            rbColor.Name = "rbColor";
            rbColor.Size = new Size(104, 24);
            rbColor.TabIndex = 4;
            rbColor.Text = "Колір";
            rbColor.CheckedChanged += rbColor_CheckedChanged;
            // 
            // rbFont
            // 
            rbFont.Location = new Point(470, 90);
            rbFont.Name = "rbFont";
            rbFont.Size = new Size(104, 24);
            rbFont.TabIndex = 5;
            rbFont.Text = "Шрифт";
            rbFont.CheckedChanged += rbFont_CheckedChanged;
            // 
            // rbSize
            // 
            rbSize.Location = new Point(470, 120);
            rbSize.Name = "rbSize";
            rbSize.Size = new Size(104, 24);
            rbSize.TabIndex = 6;
            rbSize.Text = "Розмір";
            rbSize.CheckedChanged += rbSize_CheckedChanged;
            // 
            // cbColor
            // 
            cbColor.Location = new Point(470, 200);
            cbColor.Name = "cbColor";
            cbColor.Size = new Size(104, 24);
            cbColor.TabIndex = 7;
            cbColor.Text = "Колір";
            cbColor.CheckedChanged += cbColor_CheckedChanged;
            // 
            // cbFont
            // 
            cbFont.Location = new Point(470, 230);
            cbFont.Name = "cbFont";
            cbFont.Size = new Size(104, 24);
            cbFont.TabIndex = 8;
            cbFont.Text = "Шрифт";
            cbFont.CheckedChanged += cbFont_CheckedChanged;
            // 
            // cbSize
            // 
            cbSize.Location = new Point(470, 260);
            cbSize.Name = "cbSize";
            cbSize.Size = new Size(104, 24);
            cbSize.TabIndex = 9;
            cbSize.Text = "Розмір";
            cbSize.CheckedChanged += cbSize_CheckedChanged;
            // 
            // Form1
            // 
            ClientSize = new Size(600, 380);
            Controls.Add(textBoxInput);
            Controls.Add(textBoxOutput);
            Controls.Add(labelTask);
            Controls.Add(textBoxInfo);
            Controls.Add(rbColor);
            Controls.Add(rbFont);
            Controls.Add(rbSize);
            Controls.Add(cbColor);
            Controls.Add(cbFont);
            Controls.Add(cbSize);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Редагування тексту";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}