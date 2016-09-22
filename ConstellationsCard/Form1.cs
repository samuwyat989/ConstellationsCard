﻿using System;
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

            stars.FillEllipse(whiteBrush, 65, 54, 10, 10); 
            stars.FillEllipse(whiteBrush, 43, 103, 8, 8);
            stars.FillEllipse(whiteBrush, 62, 143, 16, 16);
            stars.FillEllipse(whiteBrush, 79, 207, 6, 6);
            stars.FillEllipse(whiteBrush, 75, 259, 7, 7);
            stars.FillEllipse(whiteBrush, 76, 296, 11, 11);
            
            stars.FillEllipse(whiteBrush, 110, 54, 4, 4);
            stars.FillEllipse(whiteBrush, 115, 123, 8, 8); 
            stars.FillEllipse(whiteBrush, 95, 142, 3, 3);
            stars.FillEllipse(whiteBrush, 127, 209, 4, 4);
            stars.FillEllipse(whiteBrush, 101, 267, 9, 9);
            stars.FillEllipse(whiteBrush, 98, 285, 6, 6);
            
            stars.FillEllipse(whiteBrush, 175, 59, 9, 9);
            stars.FillEllipse(whiteBrush, 168, 78, 6, 6);
            stars.FillEllipse(whiteBrush, 143, 134, 4, 4); 
            stars.FillEllipse(whiteBrush, 132, 211, 8, 8);
            stars.FillEllipse(whiteBrush, 180, 241, 3, 3);
            stars.FillEllipse(whiteBrush, 156, 333, 4, 4);
            
            stars.FillEllipse(whiteBrush, 190, 72, 9, 9);
            stars.FillEllipse(whiteBrush, 207, 94, 8, 8);
            stars.FillEllipse(whiteBrush, 214, 157, 3, 3);
            stars.FillEllipse(whiteBrush, 196, 224, 6, 6); 
            stars.FillEllipse(whiteBrush, 223, 240, 4, 4);
            stars.FillEllipse(whiteBrush, 228, 291, 4, 4);
            
            stars.FillEllipse(whiteBrush, 237, 69, 3, 3);
            stars.FillEllipse(whiteBrush, 256, 84, 8, 8);
            stars.FillEllipse(whiteBrush, 274, 139, 16, 16);
            stars.FillEllipse(whiteBrush, 283, 200, 4, 4);
            stars.FillEllipse(whiteBrush, 241, 250, 9, 9); 
            stars.FillEllipse(whiteBrush, 242, 300, 4, 4);
            
            stars.FillEllipse(whiteBrush, 289, 50, 3, 3);
            stars.FillEllipse(whiteBrush, 293, 100, 8, 8);
            stars.FillEllipse(whiteBrush, 334, 150, 4, 4);
            stars.FillEllipse(whiteBrush, 317, 200, 6, 6);
            stars.FillEllipse(whiteBrush, 326, 250, 9, 9);
            stars.FillEllipse(whiteBrush, 297, 300, 4, 4); 
            
            stars.FillEllipse(whiteBrush, 339, 50, 9, 9);
            stars.FillEllipse(whiteBrush, 371, 100, 4, 4);
            stars.FillEllipse(whiteBrush, 364, 150, 6, 6);
            stars.FillEllipse(whiteBrush, 346, 200, 3, 3);
            stars.FillEllipse(whiteBrush, 341, 250, 4, 4);
            stars.FillEllipse(whiteBrush, 378, 300, 8, 8);
            
            stars.FillEllipse(whiteBrush, 383, 50, 4, 4);
            stars.FillEllipse(whiteBrush, 408, 100, 4, 4);
            stars.FillEllipse(whiteBrush, 416, 150, 6, 6);
            stars.FillEllipse(whiteBrush, 392, 200, 3, 3);
            stars.FillEllipse(whiteBrush, 412, 250, 9, 9);
            stars.FillEllipse(whiteBrush, 396, 300, 8, 8);
            
            stars.FillEllipse(whiteBrush, 434, 50, 8, 8);
            stars.FillEllipse(whiteBrush, 475, 100, 3, 3);
            stars.FillEllipse(whiteBrush, 457, 150, 4, 4);
            stars.FillEllipse(whiteBrush, 462, 200, 6, 6);
            stars.FillEllipse(whiteBrush, 444, 250, 4, 4);
            stars.FillEllipse(whiteBrush, 439, 300, 9, 9);
            
            stars.FillEllipse(whiteBrush, 487, 50, 9, 9);
            stars.FillEllipse(whiteBrush, 493, 100, 6, 6);
            stars.FillEllipse(whiteBrush, 534, 150, 4, 4);
            stars.FillEllipse(whiteBrush, 517, 200, 3, 3);
            stars.FillEllipse(whiteBrush, 521, 250, 8, 8);
            stars.FillEllipse(whiteBrush, 504, 300, 4, 4);
            
            stars.FillEllipse(whiteBrush, 540, 50, 3, 3);
            stars.FillEllipse(whiteBrush, 576, 100, 4, 4);
            stars.FillEllipse(whiteBrush, 563, 150, 8, 8);
            stars.FillEllipse(whiteBrush, 558, 200, 4, 4);
            stars.FillEllipse(whiteBrush, 537, 250, 9, 9);
            stars.FillEllipse(whiteBrush, 546, 300, 7, 7);

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
            stars.DrawLine(whitePen, 360, 107, 428, 68);

            stars.DrawLine(whitePen, 435, 68, 455, 94);

        }

        private void stars_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
