using System.Drawing;
using System.Windows.Forms;

namespace LB6
{
    public class ThirdForm : Form
    {
        private Label labelFinal;

        public ThirdForm(int count)
        {
            this.Text = "Результат";
            this.Width = 300;
            this.Height = 150;

            labelFinal = new Label();
            labelFinal.AutoSize = true;
            labelFinal.Location = new Point(20, 30);
            labelFinal.Text = "Кількість слів з 3 букв: " + count;

            this.Controls.Add(labelFinal);
        }
    }
}
