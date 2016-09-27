//Made by Sam Wyatt as the first summative assignment in ICS3U, Due date: 29 September 2016.
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
            //Set up pens, brushes and fonts 
            Graphics stars = this.CreateGraphics();
            Pen whitePen = new Pen(Color.White);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush highBrush = new SolidBrush(Color.LimeGreen);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Font nameFont = new Font("Times New Roman", 17, FontStyle.Bold);
            Font titleFont = new Font("Times New Roman", 25, FontStyle.Bold | FontStyle.Underline);
            Font desFont = new Font("Courier New", 9);
            Font tDesFont = new Font("Courier New", 25);
            Font highFont = new Font("Courier New", 13, FontStyle.Bold);

            //Leo image is visable 
            stars.DrawImage(Properties.Resources.leo, 100, 20, 400, 400);
            
            //Draw the words on the title 
            stars.DrawString("ICS3U Summative: Constellation Card", titleFont, whiteBrush, 25, 190);
            stars.DrawString("By: Sam Wyatt             Due: 29 September 2016", nameFont, whiteBrush, 100, 430);

            Thread.Sleep(5000);

            stars.Clear(Color.Black);

            Thread.Sleep(1000);

            stars.DrawString("Constalation - Leo", tDesFont, whiteBrush, 25, 318);
            
            stars.DrawLine(whitePen, 30, 320, 580, 320);
            stars.FillEllipse(yellowBrush, 500, 460, 10, 10);

            Thread.Sleep(1000);

            //Background stars
            stars.FillEllipse(whiteBrush, 65, 54, 10, 10); 
            stars.FillEllipse(whiteBrush, 43, 103, 8, 8);
            stars.FillEllipse(whiteBrush, 62, 143, 16, 16);
            stars.FillEllipse(whiteBrush, 79, 207, 6, 6);
            stars.FillEllipse(whiteBrush, 75, 259, 7, 7);
            stars.FillEllipse(whiteBrush, 76, 296, 11, 11);
            Thread.Sleep(25);
            stars.FillEllipse(whiteBrush, 110, 54, 4, 4);
            stars.FillEllipse(whiteBrush, 115, 123, 8, 8); 
            stars.FillEllipse(whiteBrush, 95, 142, 3, 3);
            stars.FillEllipse(whiteBrush, 127, 209, 4, 4);
            stars.FillEllipse(whiteBrush, 101, 267, 9, 9);
            stars.FillEllipse(whiteBrush, 98, 285, 6, 6);
            Thread.Sleep(25);
            stars.FillEllipse(whiteBrush, 175, 59, 9, 9);
            stars.FillEllipse(whiteBrush, 168, 78, 6, 6);
            stars.FillEllipse(whiteBrush, 143, 134, 4, 4); 
            stars.FillEllipse(whiteBrush, 152, 211, 8, 8);
            stars.FillEllipse(whiteBrush, 180, 241, 3, 3);
            stars.FillEllipse(whiteBrush, 156, 294, 4, 4);
            Thread.Sleep(25);
            stars.FillEllipse(whiteBrush, 190, 72, 9, 9);
            stars.FillEllipse(whiteBrush, 207, 94, 8, 8);
            stars.FillEllipse(whiteBrush, 214, 157, 3, 3);
            stars.FillEllipse(whiteBrush, 225, 224, 6, 6); 
            stars.FillEllipse(whiteBrush, 223, 240, 4, 4);
            stars.FillEllipse(whiteBrush, 228, 291, 4, 4);
            Thread.Sleep(25);
            stars.FillEllipse(whiteBrush, 237, 69, 3, 3);
            stars.FillEllipse(whiteBrush, 256, 84, 8, 8);
            stars.FillEllipse(whiteBrush, 274, 139, 16, 16);
            stars.FillEllipse(whiteBrush, 283, 207, 4, 4);
            stars.FillEllipse(whiteBrush, 241, 288, 9, 9); 
            stars.FillEllipse(whiteBrush, 242, 313, 4, 4);
            Thread.Sleep(25);
            stars.FillEllipse(whiteBrush, 289, 71, 3, 3);
            stars.FillEllipse(whiteBrush, 293, 90, 8, 8);
            stars.FillEllipse(whiteBrush, 334, 127, 4, 4);
            stars.FillEllipse(whiteBrush, 317, 222, 6, 6);
            stars.FillEllipse(whiteBrush, 326, 234, 9, 9);
            stars.FillEllipse(whiteBrush, 297, 276, 4, 4);
            Thread.Sleep(25);
            stars.FillEllipse(whiteBrush, 339, 41, 9, 9);
            stars.FillEllipse(whiteBrush, 371, 85, 4, 4);
            stars.FillEllipse(whiteBrush, 364, 135, 6, 6);
            stars.FillEllipse(whiteBrush, 346, 187, 3, 3);
            stars.FillEllipse(whiteBrush, 341, 264, 4, 4);
            stars.FillEllipse(whiteBrush, 378, 310, 8, 8);
            Thread.Sleep(25);
            stars.FillEllipse(whiteBrush, 383, 74, 4, 4);
            stars.FillEllipse(whiteBrush, 408, 81, 4, 4);
            stars.FillEllipse(whiteBrush, 416, 114, 6, 6);
            stars.FillEllipse(whiteBrush, 405, 234, 3, 3);
            stars.FillEllipse(whiteBrush, 422, 263, 9, 9);
            stars.FillEllipse(whiteBrush, 396, 303, 8, 8);
            Thread.Sleep(25);
            stars.FillEllipse(whiteBrush, 456, 67, 8, 8);
            stars.FillEllipse(whiteBrush, 475, 121, 3, 3);
            stars.FillEllipse(whiteBrush, 457, 163, 4, 4);
            stars.FillEllipse(whiteBrush, 462, 191, 6, 6);
            stars.FillEllipse(whiteBrush, 444, 266, 4, 4);
            stars.FillEllipse(whiteBrush, 439, 283, 9, 9);
            Thread.Sleep(25);
            stars.FillEllipse(whiteBrush, 487, 33, 9, 9);
            stars.FillEllipse(whiteBrush, 493, 87, 6, 6);
            stars.FillEllipse(whiteBrush, 534, 132, 4, 4);
            stars.FillEllipse(whiteBrush, 517, 218, 3, 3);
            stars.FillEllipse(whiteBrush, 521, 234, 8, 8);
            stars.FillEllipse(whiteBrush, 504, 267, 4, 4);
            Thread.Sleep(25);
            stars.FillEllipse(whiteBrush, 540, 66, 3, 3);
            stars.FillEllipse(whiteBrush, 576, 126, 4, 4);
            stars.FillEllipse(whiteBrush, 563, 172, 8, 8);
            stars.FillEllipse(whiteBrush, 558, 180, 4, 4);
            stars.FillEllipse(whiteBrush, 537, 267, 9, 9);
            stars.FillEllipse(whiteBrush, 546, 304, 7, 7);      

            //Leo stars
            stars.FillEllipse(whiteBrush, 199, 169, 5, 5);
            stars.FillEllipse(whiteBrush, 82, 248, 5, 5);
            stars.FillEllipse(whiteBrush, 197, 241, 5, 5);
            stars.FillEllipse(whiteBrush, 369, 179, 5, 5);
            stars.FillEllipse(whiteBrush, 413, 222, 5, 5);
            stars.FillEllipse(whiteBrush, 411, 288, 5, 5);
            stars.FillEllipse(whiteBrush, 377, 128, 5, 5);
            stars.FillEllipse(whiteBrush, 449, 86, 5, 5);
            stars.FillEllipse(whiteBrush, 473, 105, 5, 5);

            //Big Dipper stars 
            stars.FillEllipse(whiteBrush, 50, 100, 5, 5);
            stars.FillEllipse(whiteBrush, 112, 64, 5, 5);
            stars.FillEllipse(whiteBrush, 162, 68, 5, 5);
            stars.FillEllipse(whiteBrush, 222, 69, 5, 5);
            stars.FillEllipse(whiteBrush, 254, 102, 5, 5);
            stars.FillEllipse(whiteBrush, 323, 23, 5, 5);
            stars.FillEllipse(whiteBrush, 333, 72, 5, 5);

            Thread.Sleep(1000);
            
            //Drawing the Big Dipper animation 
            stars.DrawLine(whitePen, 56, 99, 111, 70);
            Thread.Sleep(500);
            stars.DrawLine(whitePen, 118, 66, 161, 70);
            Thread.Sleep(500);
            stars.DrawLine(whitePen, 168, 70, 221, 71);
            Thread.Sleep(500);
            stars.DrawLine(whitePen, 228, 71, 322, 26);
            Thread.Sleep(500);
            stars.DrawLine(whitePen, 228, 75, 253, 101);
            Thread.Sleep(500);
            stars.DrawLine(whitePen, 260, 105, 332, 75);
            Thread.Sleep(500);
            stars.DrawLine(whitePen, 336, 71, 326, 29);
            Thread.Sleep(500);

            //Set requirements and then draw the arrow
            Pen whiteArrow = new Pen(Color.White, 10);
            whiteArrow.StartCap = LineCap.ArrowAnchor;
            Pen blackArrow = new Pen(Color.Black, 10);
            blackArrow.StartCap = LineCap.ArrowAnchor;
            stars.DrawLine(whiteArrow, 335, 175, 335, 85);

            //Draw the star name in green with white background and change the description sentance to green             
            SoundPlayer sounds = new SoundPlayer(Properties.Resources.Blink);
            sounds.Play();
            stars.FillRectangle(whiteBrush, 350, 65, 80, 20);
            stars.DrawString("Merak", highFont, highBrush, 360, 65);
            stars.DrawLine(whiteArrow, 335, 175, 335, 85);
            stars.FillEllipse(highBrush, 333, 72, 5, 5);

            stars.DrawString("The Big Dipper is close to Leo and can be identified by the pointer star", desFont, highBrush, 30, 350);
            stars.DrawString("Merak.", desFont, highBrush, 30, 375);

            //Hide the star name and change the description sentance to back to white
            Thread.Sleep(750);

            stars.FillRectangle(blackBrush, 350, 65, 80, 20);
            stars.DrawString("Merak", highFont, blackBrush, 360, 65);
            stars.DrawLine(blackArrow, 335, 175, 335, 85);
            stars.FillEllipse(whiteBrush, 333, 72, 5, 5);

            stars.DrawString("The Big Dipper is close to Leo and can be identified by the pointer star", desFont, whiteBrush, 30, 350);
            stars.DrawString("Merak.", desFont, whiteBrush, 30, 375);

            //Draw the star name in green with white background and change the description sentance to green
            Thread.Sleep(750);
            sounds = new SoundPlayer(Properties.Resources.Blink);
            sounds.Play();
            stars.FillRectangle(whiteBrush, 350, 65, 80, 20);
            stars.DrawString("Merak", highFont, highBrush, 360, 65);
            stars.DrawLine(whiteArrow, 335, 175, 335, 85);
            stars.FillEllipse(highBrush, 333, 72, 5, 5);

            stars.DrawString("The Big Dipper is close to Leo and can be identified by the pointer star", desFont, highBrush, 30, 350);
            stars.DrawString("Merak.", desFont, highBrush, 30, 375);

            //Hide the star name and change the description sentance to back to white
            Thread.Sleep(750);

            stars.FillRectangle(blackBrush, 350, 65, 80, 20);
            stars.DrawString("Merak", highFont, blackBrush, 360, 65);
            stars.DrawLine(blackArrow, 335, 175, 335, 85);
            stars.FillEllipse(whiteBrush, 333, 72, 5, 5);

            stars.DrawString("The Big Dipper is close to Leo and can be identified by the pointer star", desFont, whiteBrush, 30, 350);
            stars.DrawString("Merak.", desFont, whiteBrush, 30, 375);

            //Draw the star name in green with white background and change the description sentance to green
            Thread.Sleep(750);
            sounds = new SoundPlayer(Properties.Resources.Blink);
            sounds.Play();
            stars.FillRectangle(whiteBrush, 350, 65, 80, 20);
            stars.DrawString("Merak", highFont, highBrush, 360, 65);
            stars.DrawLine(whiteArrow, 335, 175, 335, 85);
            stars.FillEllipse(highBrush, 333, 72, 5, 5);

            stars.DrawString("The Big Dipper is close to Leo and can be identified by the pointer star", desFont, highBrush, 30, 350);
            stars.DrawString("Merak.", desFont, highBrush, 30, 375);

            Thread.Sleep(4000);

            //Hide the star name and change the description sentance to back to white
            Thread.Sleep(750);

            stars.FillRectangle(blackBrush, 350, 65, 80, 20);
            stars.DrawString("Merak", highFont, blackBrush, 360, 65);
            stars.DrawLine(blackArrow, 335, 175, 335, 85);
            stars.FillEllipse(whiteBrush, 333, 72, 5, 5);

            stars.DrawString("The Big Dipper is close to Leo and can be identified by the pointer star", desFont, whiteBrush, 30, 350);
            stars.DrawString("Merak.", desFont, whiteBrush, 30, 375);
            stars.DrawString("The constellation becomes visible in the Northern Hemisphere", desFont, whiteBrush, 80, 375);
            stars.DrawString("around the spring equinox and is easily identifiable through May.", desFont, whiteBrush, 30, 400);
         
            //Drawing the Leo animation
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

            whitePen.Color = Color.Red;
            whiteBrush.Color = Color.Red;

            Thread.Sleep(1000);

            //Red Leo Animation
            stars.DrawLine(whitePen, 88, 250, 198, 172);
            stars.FillEllipse(whiteBrush, 82, 248, 5, 5);
            Thread.Sleep(50);
            stars.DrawLine(whitePen, 88, 250, 196, 244);
            stars.FillEllipse(whiteBrush, 199, 169, 5, 5);
            Thread.Sleep(50);
            stars.DrawLine(whitePen, 203, 244, 409, 291);
            stars.FillEllipse(whiteBrush, 197, 241, 5, 5);
            Thread.Sleep(50);
            stars.DrawLine(whitePen, 205, 172, 368, 181);
            stars.FillEllipse(whiteBrush, 369, 179, 5, 5);
            Thread.Sleep(50);
            stars.DrawLine(whitePen, 371, 178, 379, 134);
            stars.FillEllipse(whiteBrush, 413, 222, 5, 5);
            Thread.Sleep(50);
            stars.DrawLine(whitePen, 375, 182, 416, 221);
            stars.FillEllipse(whiteBrush, 411, 288, 5, 5);
            Thread.Sleep(50);
            stars.DrawLine(whitePen, 380, 127, 448, 88);
            stars.FillEllipse(whiteBrush, 377, 128, 5, 5);
            Thread.Sleep(50);
            stars.DrawLine(whitePen, 413, 287, 416, 228);
            stars.FillEllipse(whiteBrush, 449, 86, 5, 5);
            Thread.Sleep(50);          
            stars.DrawLine(whitePen, 455, 88, 475, 104);
            stars.FillEllipse(whiteBrush, 473, 105, 5, 5);

            Thread.Sleep(1000);

            //Changes white Pen and Brush to yellow 
            whitePen.Color = Color.Yellow;
            whiteBrush.Color = Color.Yellow;

            //Draw all Leo lines yellow
            stars.DrawLine(whitePen, 368, 181, 205, 172);            
            stars.DrawLine(whitePen, 198, 172, 88, 250);            
            stars.DrawLine(whitePen, 88, 250, 196, 244);           
            stars.DrawLine(whitePen, 203, 244, 409, 291);           
            stars.DrawLine(whitePen, 413, 287, 416, 228);        
            stars.DrawLine(whitePen, 416, 221, 375, 182);        
            stars.DrawLine(whitePen, 371, 178, 379, 134);     
            stars.DrawLine(whitePen, 380, 127, 448, 88);         
            stars.DrawLine(whitePen, 455, 88, 475, 104);

            //Draw all Leo stars yellow
            stars.FillEllipse(whiteBrush, 199, 169, 5, 5);
            stars.FillEllipse(whiteBrush, 82, 248, 5, 5);
            stars.FillEllipse(whiteBrush, 197, 241, 5, 5);
            stars.FillEllipse(whiteBrush, 369, 179, 5, 5);
            stars.FillEllipse(whiteBrush, 413, 222, 5, 5);
            stars.FillEllipse(whiteBrush, 411, 288, 5, 5);
            stars.FillEllipse(whiteBrush, 377, 128, 5, 5);
            stars.FillEllipse(whiteBrush, 449, 86, 5, 5);
            stars.FillEllipse(whiteBrush, 473, 105, 5, 5);

            stars.DrawString("Leo is a mythalogical lion that was slain by Hercules and represents", desFont, whiteBrush, 30, 425);
            stars.DrawString("us in our past lives and, the debts we still have to repay.", desFont, whiteBrush, 30, 450);

            sounds = new SoundPlayer(Properties.Resources.LionRoar);
            sounds.Play();
        }

        private void stars_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
