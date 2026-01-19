using System;
using System.Drawing;
using System.Windows.Forms;

namespace RotationDemo {
    public partial class MainForm : Form {
        private readonly Timer _timer;
        private readonly PointF[] _shape;

        public MainForm() {
            InitializeComponent();

            DoubleBuffered = true;

            _shape = new PointF[]
            {
                new PointF( 0, -70),
                new PointF( 18, -20),
                new PointF( 70, -20),
                new PointF( 28, 10),
                new PointF( 44, 60),
                new PointF( 0, 30),
                new PointF(-44, 60),
                new PointF(-28, 10),
                new PointF(-70, -20),
                new PointF(-18, -20)
            };

            _timer = new Timer();
            _timer.Interval = 20;
            _timer.Tick += (s, e) => Invalidate();
            _timer.Start();

            Paint += MainForm_Paint;
        }

        private int _mode = 0; 

        private void SetMode(int m) {
            _mode = m;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            double t = (Environment.TickCount / 1000.0) % 10.0;

            float cx = ClientSize.Width / 2f;
            float cy = ClientSize.Height / 2f;

            float moveX = 0;
            float moveY = 0;

            if (_mode == 2 || _mode == 3) {
                moveX = (float)(4 - 2 * t);
                moveY = (float)(2 - Math.Pow(t, 3));
            }

            float lx = 0;
            float ly = ClientSize.Height;

            float objX = cx + moveX;
            float objY = cy - moveY;

            float dx = objX - lx;
            float dy = objY - ly;

            float dist = (float)Math.Sqrt(dx * dx + dy * dy);
            float scale = 600f / (dist + 200f);
            scale = Math.Clamp(scale, 0.4f, 2.0f);

            double phi = -2.0 * Math.Cos(t);
            float angle = (float)(phi * 180.0 / Math.PI);

            g.TranslateTransform(objX, objY);
            g.ScaleTransform(scale, scale);

            if (_mode == 1 || _mode == 3)
                g.RotateTransform(angle);

            using (Brush b = new SolidBrush(Color.SkyBlue))
            using (Pen p = new Pen(Color.DarkBlue, 2)) {
                g.FillPolygon(b, _shape);
                g.DrawPolygon(p, _shape);
            }

            g.ResetTransform();
        }

        private void task1MenuItem_Click(object sender, EventArgs e) => SetMode(0);
        private void task2MenuItem_Click(object sender, EventArgs e) => SetMode(1);
        private void task3MenuItem_Click(object sender, EventArgs e) => SetMode(2);
        private void task4MenuItem_Click(object sender, EventArgs e) => SetMode(3);
    }
}