using System;
using System.Windows.Forms;

namespace LB6
{
    public partial class SecondForm : Form
    {
        public SecondForm(int count)
        {
            InitializeComponent();
            labelResult.Text = "Кількість слів з 3 букв: " + count;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
