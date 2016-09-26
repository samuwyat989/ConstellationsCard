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
using System.Drawing.Drawing2D;

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
            SolidBrush highBrush = new SolidBrush(Color.LimeGreen);
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
            stars.DrawString("The Big Dipper is close to Leo and can be identified by the pointer star", desFont, highBrush, 30, 350);
            stars.DrawString("Merak.", desFont, highBrush, 30, 375);
            stars.DrawString("The constellation becomes visible in the Northern Hemisphere", desFont, whiteBrush, 80, 375);
            stars.DrawString("around the spring equinox and is easily identifiable through May.", desFont, whiteBrush, 30, 400);
            stars.DrawString("Leo represents us in our past lives and, and all tails speak of the", desFont, whiteBrush, 30, 425);
            stars.DrawString("past and the debts we still have to repay.", desFont, whiteBrush, 30, 450);
            

            stars.DrawLine(whitePen, 30, 320, 580, 320);
            stars.FillEllipse(yellowBrush, 500, 460, 10, 10);

            Thread.Sleep(1000);

            /*stars.FillEllipse(whiteBrush, 29, 88, 5, 5);
            stars.FillEllipse(whiteBrush, 56, 70, 5, 5);
            stars.FillEllipse(whiteBrush, 78, 71, 5, 5);
            stars.FillEllipse(whiteBrush, 103, 72, 5, 5);
            stars.FillEllipse(whiteBrush, 116, 88, 5, 5);
            stars.FillEllipse(whiteBrush, 145, 48, 5, 5);
            stars.FillEllipse(whiteBrush, 151, 73, 5, 5);*/

            stars.FillEllipse(whiteBrush, 50, 100, 5, 5);
            stars.FillEllipse(whiteBrush, 112, 64, 5, 5);
            stars.FillEllipse(whiteBrush, 162, 68, 5, 5);
            stars.FillEllipse(whiteBrush, 222, 69, 5, 5);
            stars.FillEllipse(whiteBrush, 254, 102, 5, 5);
            stars.FillEllipse(whiteBrush, 323, 23, 5, 5);
            stars.FillEllipse(whiteBrush, 333, 72, 5, 5);

            stars.DrawLine(whitePen, 56, 99, 111, 70);
            stars.DrawLine(whitePen, 118, 66, 161, 70);
            stars.DrawLine(whitePen, 168, 70, 221, 71);
            stars.DrawLine(whitePen, 228, 71, 322, 26);
            stars.DrawLine(whitePen, 228, 75, 253, 101);
            stars.DrawLine(whitePen, 260, 105, 332, 75);
            stars.DrawLine(whitePen, 336, 71, 326, 29);

            Pen arrow = new Pen(Color.White, 15);
            arrow.StartCap = LineCap.ArrowAnchor;
            stars.DrawLine(arrow, 335, 175, 335, 100);

            Font highFont = new Font("Courier New", 13);
            stars.FillRectangle(whiteBrush, 350, 65, 80, 20);
            stars.DrawString("Merak", highFont, highBrush, 360, 65);

            /*stars.FillEllipse(whiteBrush, 62, 228, 5, 5);
            stars.FillEllipse(whiteBrush, 177, 221, 5, 5);
            stars.FillEllipse(whiteBrush, 349, 159, 5, 5);
            stars.FillEllipse(whiteBrush, 393, 202, 5, 5);
            stars.FillEllipse(whiteBrush, 391, 268, 5, 5);
            stars.FillEllipse(whiteBrush, 357, 108, 5, 5);
            stars.FillEllipse(whiteBrush, 429, 66, 5, 5);
            stars.FillEllipse(whiteBrush, 453, 95, 5, 5);*/

            stars.FillEllipse(whiteBrush, 65, 54, 10, 10); 
            stars.FillEllipse(whiteBrush, 43, 103, 8, 8);
            stars.FillEllipse(whiteBrush, 62, 143, 16, 16);
            stars.FillEllipse(whiteBrush, 79, 207, 6, 6);
            stars.FillEllipse(whiteBrush, 75, 259, 7, 7);
            stars.FillEllipse(whiteBrush, 76, 296, 11, 11);
            
            stars.FillEllipse(whiteBrush, 110, 54, 4, 4);
            stars.FillEllipse(whiteBrush, 115, 123, 8, 8); 
            stars.FillEllipse(whiteBrush, 95, 142, 3, 3);
            stars.FillEllipse(yellowBrush, 127, 209, 4, 4);
            stars.FillEllipse(whiteBrush, 101, 267, 9, 9);
            stars.FillEllipse(whiteBrush, 98, 285, 6, 6);
            
            stars.FillEllipse(whiteBrush, 175, 59, 9, 9);
            stars.FillEllipse(whiteBrush, 168, 78, 6, 6);
            stars.FillEllipse(whiteBrush, 143, 134, 4, 4); 
            stars.FillEllipse(yellowBrush, 152, 211, 8, 8);
            stars.FillEllipse(whiteBrush, 180, 241, 3, 3);
            stars.FillEllipse(whiteBrush, 156, 294, 4, 4);
            
            stars.FillEllipse(whiteBrush, 190, 72, 9, 9);
            stars.FillEllipse(whiteBrush, 207, 94, 8, 8);
            stars.FillEllipse(whiteBrush, 214, 157, 3, 3);
            stars.FillEllipse(whiteBrush, 225, 224, 6, 6); 
            stars.FillEllipse(whiteBrush, 223, 240, 4, 4);
            stars.FillEllipse(whiteBrush, 228, 291, 4, 4);
            
            stars.FillEllipse(whiteBrush, 237, 69, 3, 3);
            stars.FillEllipse(whiteBrush, 256, 84, 8, 8);
            stars.FillEllipse(whiteBrush, 274, 139, 16, 16);
            stars.FillEllipse(whiteBrush, 283, 207, 4, 4);
            stars.FillEllipse(whiteBrush, 241, 288, 9, 9); 
            stars.FillEllipse(whiteBrush, 242, 313, 4, 4);
            
            stars.FillEllipse(whiteBrush, 289, 71, 3, 3);
            stars.FillEllipse(whiteBrush, 293, 90, 8, 8);
            stars.FillEllipse(whiteBrush, 334, 127, 4, 4);
            stars.FillEllipse(whiteBrush, 317, 222, 6, 6);
            stars.FillEllipse(yellowBrush, 326, 234, 9, 9);
            stars.FillEllipse(whiteBrush, 297, 276, 4, 4); 
            
            stars.FillEllipse(whiteBrush, 339, 41, 9, 9);
            stars.FillEllipse(whiteBrush, 371, 85, 4, 4);
            stars.FillEllipse(whiteBrush, 364, 135, 6, 6);
            stars.FillEllipse(whiteBrush, 346, 187, 3, 3);
            stars.FillEllipse(whiteBrush, 341, 264, 4, 4);
            stars.FillEllipse(whiteBrush, 378, 310, 8, 8);
            
            stars.FillEllipse(whiteBrush, 383, 74, 4, 4);
            stars.FillEllipse(whiteBrush, 408, 81, 4, 4);
            stars.FillEllipse(whiteBrush, 416, 114, 6, 6);
            stars.FillEllipse(whiteBrush, 405, 234, 3, 3);
            stars.FillEllipse(yellowBrush, 422, 263, 9, 9);
            stars.FillEllipse(whiteBrush, 396, 303, 8, 8);
            
            stars.FillEllipse(yellowBrush, 456, 67, 8, 8);
            stars.FillEllipse(whiteBrush, 475, 121, 3, 3);
            stars.FillEllipse(whiteBrush, 457, 163, 4, 4);
            stars.FillEllipse(whiteBrush, 462, 191, 6, 6);
            stars.FillEllipse(whiteBrush, 444, 266, 4, 4);
            stars.FillEllipse(yellowBrush, 439, 283, 9, 9);
            
            stars.FillEllipse(whiteBrush, 487, 33, 9, 9);
            stars.FillEllipse(whiteBrush, 493, 87, 6, 6);
            stars.FillEllipse(whiteBrush, 534, 132, 4, 4);
            stars.FillEllipse(whiteBrush, 517, 218, 3, 3);
            stars.FillEllipse(whiteBrush, 521, 234, 8, 8);
            stars.FillEllipse(whiteBrush, 504, 267, 4, 4);
            
            stars.FillEllipse(whiteBrush, 540, 66, 3, 3);
            stars.FillEllipse(whiteBrush, 576, 126, 4, 4);
            stars.FillEllipse(whiteBrush, 563, 172, 8, 8);
            stars.FillEllipse(whiteBrush, 558, 180, 4, 4);
            stars.FillEllipse(whiteBrush, 537, 267, 9, 9);
            stars.FillEllipse(whiteBrush, 546, 304, 7, 7);      

            stars.FillEllipse(whiteBrush, 199, 169, 5, 5);
            stars.FillEllipse(whiteBrush, 82, 248, 5, 5);
            stars.FillEllipse(whiteBrush, 197, 241, 5, 5);
            stars.FillEllipse(whiteBrush, 369, 179, 5, 5);
            stars.FillEllipse(whiteBrush, 413, 222, 5, 5);
            stars.FillEllipse(whiteBrush, 411, 288, 5, 5);
            stars.FillEllipse(whiteBrush, 377, 128, 5, 5);
            stars.FillEllipse(whiteBrush, 449, 86, 5, 5);
            stars.FillEllipse(whiteBrush, 473, 105, 5, 5);

            Thread.Sleep(1000);

            stars.DrawLine(whitePen, 368, 181, 205, 172);
            Thread.Sleep(500);
            stars.DrawLine(whitePen, 198, 172, 88, 250);
            Thread.Sleep(500);
            stars.DrawLine(whitePen, 88, 250, 196, 244);
            Thread.Sleep(500);
            stars.DrawLine(whitePen, 203, 244, 409, 291);
            Thread.Sleep(500);
            stars.DrawLine(whitePen, 413, 287, 416, 228);
            Thread.Sleep(500);
            stars.DrawLine(whitePen, 416, 221, 375, 182);
            Thread.Sleep(500);
            stars.DrawLine(whitePen, 371, 178, 379, 134);
            Thread.Sleep(500);
            stars.DrawLine(whitePen, 380, 127, 448, 88);
            Thread.Sleep(500);
            stars.DrawLine(whitePen, 455, 88, 475, 104);

            /*whitePen.Color = Color.Red;
            whiteBrush.Color = Color.Red;

            Thread.Sleep(1000);

            stars.FillEllipse(whiteBrush, 62, 228, 5, 5);
            Thread.Sleep(200);
            stars.FillEllipse(whiteBrush, 177, 221, 5, 5);
            Thread.Sleep(200);
            stars.FillEllipse(whiteBrush, 179, 149, 5, 5);
            Thread.Sleep(200);                     
            stars.FillEllipse(whiteBrush, 349, 159, 5, 5);
            Thread.Sleep(200);
            stars.FillEllipse(whiteBrush, 357, 108, 5, 5);
            Thread.Sleep(200);
            stars.FillEllipse(whiteBrush, 391, 268, 5, 5);
            Thread.Sleep(200);
            stars.FillEllipse(whiteBrush, 393, 202, 5, 5);
            Thread.Sleep(200);           
            stars.FillEllipse(whiteBrush, 429, 66, 5, 5);
            Thread.Sleep(200);
            stars.FillEllipse(whiteBrush, 453, 95, 5, 5);

            Thread.Sleep(1000);

            stars.DrawLine(whitePen, 185, 152, 348, 161);
            Thread.Sleep(500);
            stars.DrawLine(whitePen, 178, 152, 68, 230);
            Thread.Sleep(500);
            stars.DrawLine(whitePen, 68, 230, 176, 224);
            Thread.Sleep(500);
            stars.DrawLine(whitePen, 183, 224, 389, 271);
            Thread.Sleep(500);
            stars.DrawLine(whitePen, 393, 267, 396, 208);
            Thread.Sleep(500);
            stars.DrawLine(whitePen, 396, 201, 355, 162);
            Thread.Sleep(500);
            stars.DrawLine(whitePen, 351, 158, 359, 114);
            Thread.Sleep(500);
            stars.DrawLine(whitePen, 360, 107, 428, 68);
            Thread.Sleep(500);
            stars.DrawLine(whitePen, 435, 68, 455, 94);*/
        }

        private void stars_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
