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
using System.Threading;

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
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            Font nameFont = new Font("Times New Roman", 20, FontStyle.Bold);
            Font titleFont = new Font("Times New Roman", 35, FontStyle.Bold);

            stars.DrawString("ICS3U First Summative", titleFont, whiteBrush, 140, 190);
            stars.DrawString("By: Sam Wyatt", nameFont, whiteBrush, 500, 430);

            Thread.Sleep(1000);

            stars.Clear(Color.Black);
            
            //FillElipse(x, y, width, height)
            /*stars.FillEllipse(whiteBrush, 100, 100, 10, 10);
            stars.FillEllipse(whiteBrush, 150, 100, 10, 10);
            stars.FillEllipse(whiteBrush, 200, 100, 10, 10);
            stars.FillEllipse(whiteBrush, 100, 150, 10, 10);
            stars.FillEllipse(whiteBrush, 100, 200, 10, 10);
            stars.FillEllipse(whiteBrush, 150, 150, 10, 10);
            stars.FillEllipse(whiteBrush, 200, 200, 10, 10);
            stars.FillEllipse(whiteBrush, 150, 200, 10, 10);
            stars.FillEllipse(whiteBrush, 100, 100, 10, 10);
            stars.FillEllipse(whiteBrush, 350, 100, 10, 10);
            stars.FillEllipse(whiteBrush, 300, 300, 10, 10);
            stars.FillEllipse(whiteBrush, 300, 150, 10, 10);
            stars.FillEllipse(whiteBrush, 300, 200, 10, 10);
            stars.FillEllipse(whiteBrush, 450, 100, 10, 10);
            stars.FillEllipse(whiteBrush, 400, 300, 10, 10);
            stars.FillEllipse(whiteBrush, 400, 150, 10, 10);
            stars.FillEllipse(whiteBrush, 400, 200, 10, 10);
            stars.FillEllipse(whiteBrush, 550, 100, 10, 10);
            stars.FillEllipse(whiteBrush, 500, 300, 10, 10);
            stars.FillEllipse(whiteBrush, 500, 150, 10, 10);
            stars.FillEllipse(whiteBrush, 500, 200, 10, 10);*/

            Thread.Sleep(1000);

            stars.FillEllipse(yellowBrush, 500, 460, 10, 10);

            stars.FillEllipse(whiteBrush, 50, 50, 10, 10);
            stars.FillEllipse(whiteBrush, 50, 100, 10, 10);
            stars.FillEllipse(whiteBrush, 100, 150, 10, 10);
            stars.FillEllipse(whiteBrush, 100, 200, 10, 10);
            stars.FillEllipse(whiteBrush, 100, 250, 10, 10);
            stars.FillEllipse(whiteBrush, 100, 300, 10, 10);
            stars.FillEllipse(whiteBrush, 100, 350, 10, 10);
            stars.FillEllipse(whiteBrush, 100, 400, 10, 10);
            stars.FillEllipse(whiteBrush, 100, 450, 10, 10);

            stars.FillEllipse(whiteBrush, 100, 50, 10, 10);
            stars.FillEllipse(whiteBrush, 100, 100, 10, 10);
            stars.FillEllipse(whiteBrush, 100, 150, 10, 10);
            stars.FillEllipse(whiteBrush, 100, 200, 10, 10);
            stars.FillEllipse(whiteBrush, 100, 250, 10, 10);
            stars.FillEllipse(whiteBrush, 100, 300, 10, 10);
            stars.FillEllipse(whiteBrush, 100, 350, 10, 10);
            stars.FillEllipse(whiteBrush, 100, 400, 10, 10);
            stars.FillEllipse(whiteBrush, 100, 450, 10, 10);

        }

        private void stars_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
