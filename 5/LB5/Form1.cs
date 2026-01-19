using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextEditorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void task1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTask.Text = "Завдання 1: Вивести всі слова з тексту, крім слова, номер якого дорівнює заданому числу.";
            textBoxOutput.Clear();

            string text = textBoxInput.Text.Trim();
            string input = Microsoft.VisualBasic.Interaction.InputBox("Введіть номер слова, яке потрібно видалити:", "Введення числа", "1");
            int number = Convert.ToInt32(input);

            string[] words = text.Split(
                new[] { ' ', ',', '.', '?', '!', '\n', '\t' },
                StringSplitOptions.RemoveEmptyEntries
            );
            string result = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (i + 1 != number)
                    result += words[i] + " ";
            }

            textBoxOutput.Text = result;
        }

        private void task2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTask.Text = "Завдання 2: Видалити з рядка всі трьохбуквені слова.";
            textBoxOutput.Clear();

            string text = textBoxInput.Text.Trim();

            string[] words = text.Split(
                new[] { ' ', ',', '.', '?', '!', '\n', '\t' },
                StringSplitOptions.RemoveEmptyEntries
            );

            string result = "";
            foreach (string word in words)
            {
                string clean = word.Trim();
                if (clean.Length != 3)
                    result += clean + " ";
            }

            textBoxOutput.Text = result;
        }

        private void rbColor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbColor.Checked)
            {
                using (ColorDialog colorDialog = new ColorDialog())
                {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                        textBoxInput.ForeColor = colorDialog.Color;
                }
            }
        }

        private void rbFont_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFont.Checked)
            {
                using (FontDialog fontDialog = new FontDialog())
                {
                    fontDialog.Font = textBoxInput.Font;
                    if (fontDialog.ShowDialog() == DialogResult.OK)
                        textBoxInput.Font = fontDialog.Font;
                }
            }
        }

        private void rbSize_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSize.Checked)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Введіть розмір шрифту для поля введення:",
                    "Зміна розміру",
                    textBoxInput.Font.Size.ToString()
                );

                float newSize = float.Parse(input);
                textBoxInput.Font = new Font(textBoxInput.Font.FontFamily, newSize);
            }
        }

        private void cbColor_CheckedChanged(object sender, EventArgs e)
        {
            if (cbColor.Checked)
            {
                using (ColorDialog colorDialog = new ColorDialog())
                {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                        textBoxOutput.ForeColor = colorDialog.Color;
                }
            }
            else {
                textBoxOutput.ForeColor = Color.Black;
            }
        }

        private void cbFont_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFont.Checked)
            {
                using (FontDialog fontDialog = new FontDialog())
                {
                    fontDialog.Font = textBoxOutput.Font;
                    if (fontDialog.ShowDialog() == DialogResult.OK)
                        textBoxOutput.Font = fontDialog.Font;
                }
            }
            else
            {
                textBoxOutput.Font = new Font("Microsoft Sans Serif", 10);
            }
        }

        private void cbSize_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSize.Checked)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Введіть розмір шрифту для поля виводу:",
                    "Зміна розміру",
                    textBoxOutput.Font.Size.ToString()
                );

                float newSize = float.Parse(input);
                textBoxOutput.Font = new Font(textBoxOutput.Font.FontFamily, newSize);
            }
            else
            {
                textBoxOutput.Font = new Font(textBoxOutput.Font.FontFamily, 10);
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}