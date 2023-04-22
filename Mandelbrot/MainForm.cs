using Mandelbrot.helper;
using Mandelbrot.maths;
using System.Diagnostics;

namespace Mandelbrot
{
    public partial class MainForm : Form
    {
        private String title = "ComplexPlot";
        private AbstractComplexFunction f = new MandelBrot(255);
        private CoordinateSystem coordinateSystem;
        private void forceAspectRatio()
        {
            int x = (this.Width < this.Height) ? this.Width : this.Height;

            this.Width = x;
            this.Height = x;
        }
        public MainForm()
        {
            this.coordinateSystem = new CoordinateSystem(new ComplexPoint(-2, 2), new ComplexPoint(2, -2), this.Width, this.Height);
            

            InitializeComponent();

            this.Text = title;
            forceAspectRatio();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            forceAspectRatio();
            this.coordinateSystem.resetSize(this.Width, this.Height);

            if (this.BackgroundImage != null) this.BackgroundImage = null;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = this.title + "  (" + coordinateSystem.PixelToComplex(e.X, e.Y).ToString() + ")";
        }

        private void plot(AbstractComplexFunction f)
        {
            Bitmap rBitmap = new Bitmap(this.Width, this.Height);

            for (int x = 0; x < this.Width; x++)
            {
                for (int y = 0; y < this.Height; y++)
                {
                    ComplexPoint c = coordinateSystem.PixelToComplex(x, y);
                    int e = f.Calculate(c);
                    rBitmap.SetPixel(x, y, Color.FromArgb(0, 0, e));
                }
            }

            this.BackgroundImage = rBitmap;
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            plot(this.f);
        }
    }
}