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
           
            ///http://www.siwallpaperhd.com/night-sky-hd-wallpaper.html/night-sky-hd-wallpaper-2
            Graphics stars = this.CreateGraphics();
            Pen whitePen = new Pen(Color.White);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            Font nameFont = new Font("Times New Roman", 20, FontStyle.Bold);
            Font titleFont = new Font("Times New Roman", 35, FontStyle.Bold);
            Font desFont = new Font("Courier New", 9);
            Font tDesFont = new Font("Courier New", 25);

            stars.DrawString("ICS3U First Summative", titleFont, whiteBrush, 55, 190);
            stars.DrawString("By: Sam Wyatt", nameFont, whiteBrush, 350, 430);

            Thread.Sleep(2000);

            stars.Clear(Color.Black);

            Thread.Sleep(1000);

            stars.DrawString("Constalation - Leo", tDesFont, whiteBrush, 25, 318);
            stars.DrawString("The Big Dipper is close to Leo and can be identified by the pointer star", desFont, whiteBrush, 30, 350);
            stars.DrawString("Merak. The constellation becomes visible in the Northern Hemisphere ", desFont, whiteBrush, 30, 375);
            stars.DrawString("around the spring equinox and is easily identifiable through May.", desFont, whiteBrush, 30, 400);
            stars.DrawString("Leo represents us in our past lives and, and all tails speak of the", desFont, whiteBrush, 30, 425);
            stars.DrawString("past and the debts we still have to repay.", desFont, whiteBrush, 30, 450);
            

            stars.DrawLine(whitePen, 30, 320, 580, 320);
            stars.FillEllipse(yellowBrush, 500, 460, 10, 10);

            /*stars.FillEllipse(whiteBrush, 50, 50, 10, 10); 
            stars.FillEllipse(whiteBrush, 50, 100, 8, 8);
            stars.FillEllipse(whiteBrush, 50, 150, 16, 16);
            stars.FillEllipse(whiteBrush, 50, 200, 6, 6);
            stars.FillEllipse(whiteBrush, 50, 250, 7, 7);
            stars.FillEllipse(whiteBrush, 50, 300, 11, 11);
            
            stars.FillEllipse(whiteBrush, 100, 50, 4, 4);
            stars.FillEllipse(whiteBrush, 100, 100, 8, 8); 
            stars.FillEllipse(whiteBrush, 100, 150, 3, 3);
            stars.FillEllipse(whiteBrush, 100, 200, 4, 4);
            stars.FillEllipse(whiteBrush, 100, 250, 9, 9);
            stars.FillEllipse(whiteBrush, 100, 300, 6, 6);
            
            stars.FillEllipse(whiteBrush, 150, 50, 10, 10);
            stars.FillEllipse(whiteBrush, 150, 100, 8, 8);
            stars.FillEllipse(whiteBrush, 150, 150, 16, 16); 
            stars.FillEllipse(whiteBrush, 150, 200, 6, 6);
            stars.FillEllipse(whiteBrush, 150, 250, 7, 7);
            stars.FillEllipse(whiteBrush, 150, 300, 11, 11);
            
            stars.FillEllipse(whiteBrush, 200, 50, 4, 4);
            stars.FillEllipse(whiteBrush, 200, 100, 10, 10);
            stars.FillEllipse(whiteBrush, 200, 150, 10, 10);
            stars.FillEllipse(whiteBrush, 200, 200, 10, 10); 
            stars.FillEllipse(whiteBrush, 200, 250, 10, 10);
            stars.FillEllipse(whiteBrush, 200, 300, 10, 10);
            
            stars.FillEllipse(whiteBrush, 250, 50, 10, 10);
            stars.FillEllipse(whiteBrush, 250, 100, 10, 10);
            stars.FillEllipse(whiteBrush, 250, 150, 10, 10);
            stars.FillEllipse(whiteBrush, 250, 200, 10, 10);
            stars.FillEllipse(whiteBrush, 250, 250, 10, 10); 
            stars.FillEllipse(whiteBrush, 250, 300, 10, 10);
            
            stars.FillEllipse(whiteBrush, 300, 50, 10, 10);
            stars.FillEllipse(whiteBrush, 300, 100, 10, 10);
            stars.FillEllipse(whiteBrush, 300, 150, 10, 10);
            stars.FillEllipse(whiteBrush, 300, 200, 10, 10);
            stars.FillEllipse(whiteBrush, 300, 250, 10, 10);
            stars.FillEllipse(whiteBrush, 300, 300, 10, 10); 
            
            stars.FillEllipse(whiteBrush, 350, 50, 10, 10);
            stars.FillEllipse(whiteBrush, 350, 100, 10, 10);
            stars.FillEllipse(whiteBrush, 350, 150, 10, 10);
            stars.FillEllipse(whiteBrush, 350, 200, 10, 10);
            stars.FillEllipse(whiteBrush, 350, 250, 10, 10);
            stars.FillEllipse(whiteBrush, 350, 300, 10, 10);
            
            stars.FillEllipse(whiteBrush, 400, 50, 10, 10);
            stars.FillEllipse(whiteBrush, 400, 100, 10, 10);
            stars.FillEllipse(whiteBrush, 400, 150, 10, 10);
            stars.FillEllipse(whiteBrush, 400, 200, 10, 10);
            stars.FillEllipse(whiteBrush, 400, 250, 10, 10);
            stars.FillEllipse(whiteBrush, 400, 300, 10, 10);
            
            stars.FillEllipse(whiteBrush, 450, 50, 10, 10);
            stars.FillEllipse(whiteBrush, 450, 100, 10, 10);
            stars.FillEllipse(whiteBrush, 450, 150, 10, 10);
            stars.FillEllipse(whiteBrush, 450, 200, 10, 10);
            stars.FillEllipse(whiteBrush, 450, 250, 10, 10);
            stars.FillEllipse(whiteBrush, 450, 300, 10, 10);
            
            stars.FillEllipse(whiteBrush, 500, 50, 10, 10);
            stars.FillEllipse(whiteBrush, 500, 100, 10, 10);
            stars.FillEllipse(whiteBrush, 500, 150, 10, 10);
            stars.FillEllipse(whiteBrush, 500, 200, 10, 10);
            stars.FillEllipse(whiteBrush, 500, 250, 10, 10);
            stars.FillEllipse(whiteBrush, 500, 300, 10, 10);
            
            stars.FillEllipse(whiteBrush, 550, 50, 10, 10);
            stars.FillEllipse(whiteBrush, 550, 100, 10, 10);
            stars.FillEllipse(whiteBrush, 550, 150, 10, 10);
            stars.FillEllipse(whiteBrush, 550, 200, 10, 10);
            stars.FillEllipse(whiteBrush, 550, 250, 10, 10);
            stars.FillEllipse(whiteBrush, 550, 300, 10, 10);*/

            stars.FillEllipse(whiteBrush, 179, 149, 5, 5);
            stars.FillEllipse(whiteBrush, 62, 228, 5, 5);
            stars.FillEllipse(whiteBrush, 177, 221, 5, 5);

            stars.FillEllipse(whiteBrush, 349, 159, 5, 5);
            stars.FillEllipse(whiteBrush, 393, 202, 5, 5);
            stars.FillEllipse(whiteBrush, 391, 268, 5, 5);

            stars.FillEllipse(whiteBrush, 357, 108, 5, 5);
            stars.FillEllipse(whiteBrush, 429, 66, 5, 5);
            stars.FillEllipse(whiteBrush, 453, 95, 5, 5);

            stars.DrawLine(whitePen, 185, 152, 348, 161);
            stars.DrawLine(whitePen, 178, 152, 68, 230);
            stars.DrawLine(whitePen, 68, 230, 176, 224);

            stars.DrawLine(whitePen, 183, 224, 389, 271);
            stars.DrawLine(whitePen, 393, 267, 396, 208);
            stars.DrawLine(whitePen, 396, 201, 355, 162);

            stars.DrawLine(whitePen, 351, 158, 359, 114);
        }

        private void stars_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
