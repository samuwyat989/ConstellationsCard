using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ConstellationsCard
{
    public partial class stars : Form
    {
        public stars()
        {
            InitializeComponent();
        }

        private void stars_Click(object sender, EventArgs e)
        {
            ///https://stardate.org/astro-guide/pegasus-flying-horse-0
            ///http://www.siwallpaperhd.com/night-sky-hd-wallpaper.html/night-sky-hd-wallpaper-2
            Graphics stars = this.CreateGraphics();
            Pen whitePen = new Pen(Color.White);
            SolidBrush whiteBrush = new SolidBrush(Color.White);

            //FillElipse(x, y, width, height)
            stars.FillEllipse(whiteBrush, 100, 100, 10, 10);

            PictureBox box = new PictureBox(Properties. Resources. night_sky_hd_wallpaper);
            box.DisplayRectangle();
        }
    }
}
