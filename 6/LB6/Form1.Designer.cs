namespace LB6
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button btnProcess;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            this.textBoxInput.Location = new System.Drawing.Point(20, 20);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(300, 80);
            this.textBoxInput.TabIndex = 0;
             
            this.btnProcess.Location = new System.Drawing.Point(20, 120);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(120, 35);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Обробити";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.ClientSize = new System.Drawing.Size(360, 200);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.textBoxInput);
            this.Name = "MainForm";
            this.Text = "Головна форма";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
