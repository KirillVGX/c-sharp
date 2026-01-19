using System;
using System.Windows.Forms;

namespace LB6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private int Count3LetterWords(string text)
        {
            string[] words = text.Split(
                new[] { ' ', ',', '.', '?', '!', '\n', '\t' },
                StringSplitOptions.RemoveEmptyEntries
            );

            int count = 0;

            foreach (string word in words)
            {
                if (word.Count(char.IsLetter) == 3)
                {
                    count++;
                }
            }

            return count;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            int count = Count3LetterWords(textBoxInput.Text);

            using (SecondForm f2 = new SecondForm(count))
            {
                DialogResult result = f2.ShowDialog();

                if (result == DialogResult.OK)
                {
                    ThirdForm f3 = new ThirdForm(count);
                    f3.Show();
                    this.Hide();
                }
            }
        }
    }
}
