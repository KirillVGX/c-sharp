using System;
using System.Windows.Forms;
using System.Drawing;

namespace RotationDemo {
    partial class MainForm {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem modeMenu;
        private System.Windows.Forms.ToolStripMenuItem task1MenuItem;
        private System.Windows.Forms.ToolStripMenuItem task2MenuItem;
        private System.Windows.Forms.ToolStripMenuItem task3MenuItem;
        private System.Windows.Forms.ToolStripMenuItem task4MenuItem;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.menuStrip = new MenuStrip();
            this.modeMenu = new ToolStripMenuItem();
            this.task1MenuItem = new ToolStripMenuItem();
            this.task2MenuItem = new ToolStripMenuItem();
            this.task3MenuItem = new ToolStripMenuItem();
            this.task4MenuItem = new ToolStripMenuItem();

            this.menuStrip.Items.AddRange(new ToolStripItem[] {
                this.modeMenu
            });
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Size = new System.Drawing.Size(900, 24);
            this.menuStrip.Name = "menuStrip";

            this.modeMenu.Text = "Завдання";
            this.modeMenu.DropDownItems.AddRange(new ToolStripItem[] {
                this.task1MenuItem,
                this.task2MenuItem,
                this.task3MenuItem,
                this.task4MenuItem
            });

            this.task1MenuItem.Text = "Завдання 1";
            this.task1MenuItem.Click += new EventHandler(this.task1MenuItem_Click);

            this.task2MenuItem.Text = "Завдання 2";
            this.task2MenuItem.Click += new EventHandler(this.task2MenuItem_Click);

            this.task3MenuItem.Text = "Завдання 3";
            this.task3MenuItem.Click += new EventHandler(this.task3MenuItem_Click);

            this.task4MenuItem.Text = "Завдання 4";
            this.task4MenuItem.Click += new EventHandler(this.task4MenuItem_Click);

            this.ClientSize = new System.Drawing.Size(900, 650);
            this.MainMenuStrip = this.menuStrip;
            this.Text = "Lab 11";
            this.Controls.Add(this.menuStrip);

            this.task1MenuItem.Checked = true;
        }
    }
}