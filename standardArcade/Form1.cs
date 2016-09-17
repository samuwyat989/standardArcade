using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace standardArcade
{
    public partial class standardArcade : Form
    {
        public standardArcade()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Controls.Remove(playButton);
            packMan.Visible = false;
            /*countdown.ForeColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            SoundPlayer player = new SoundPlayer(Properties.Resources.countdown_alert);
            player.Play();
            countdown.Text = "Game will start in: 3";

            Refresh();
            Thread.Sleep(1000);

            player = new SoundPlayer(Properties.Resources.countdown_alert);
            player.Play();
            countdown.Text = "Game will start in: 2";

            Refresh();
            Thread.Sleep(1000);

            player = new SoundPlayer(Properties.Resources.countdown_alert);
            player.Play();
            countdown.Text = "Game will start in: 1";

            Refresh();
            Thread.Sleep(1000);

            player = new SoundPlayer(Properties.Resources.Air_Horn_SoundBible_com_964603082);
            player.Play();
            Controls.Remove(countdown);
            BackColor = Color.Green;

            go.BackColor = Color.Green;
            go.ForeColor = Color.White;

            Refresh();
            Thread.Sleep(1000);*/

            Controls.Remove(countdown);
            Controls.Remove(go);

            Graphics ramsLogo = this.CreateGraphics();
            Pen redPen = new Pen(Color.Red, 10);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            Font ramsFont = new Font("Modern No. 20", 24, FontStyle.Bold);
            Font cFont = new Font("Times New Roman", 120, FontStyle.Bold);
            Font smallFont = new Font("Arial", 8);
            //You can change the colour of a pen or brush after it has been created by using the following code: drawPen.Color = Color.Black;  drawBrush.Color = Color.Red;

            //DrawEllipse(pen, x, y, width, height)
            ramsLogo.DrawEllipse(redPen, 40, 60, 200, 150);
            ramsLogo.FillEllipse(redBrush, 40, 60, 200, 150);
            ramsLogo.DrawString("R A M S", ramsFont, whiteBrush, 105, 120);
            ramsLogo.DrawString("C", cFont, whiteBrush, 30, 45);

            ramsLogo.TranslateTransform(250, 190); 
            ramsLogo.RotateTransform(270);
            ramsLogo.DrawString("Central Rams Arcade", smallFont, whiteBrush, new Rectangle());
            ramsLogo.ResetTransform();

            Thread.Sleep(2000);

            redPen.Color = Color.Blue;
            ramsLogo.Clear(Color.Black);
            //DrawLine (pen, x1, y1, x2, y2)
            ramsLogo.DrawLine(redPen, 30, 40, 250, 40);
            ramsLogo.DrawLine(redPen, 30, 100, 180, 100);
            ramsLogo.DrawLine(redPen, 250, 35, 250, 245);
            ramsLogo.DrawLine(redPen, 175, 95, 175, 245);

            redPen.Color = Color.White;
            ramsLogo.DrawLine(redPen, 90, 70, 100, 70);
            ramsLogo.DrawLine(redPen, 130, 70, 140, 70);
            ramsLogo.DrawLine(redPen, 170, 70, 180, 70);
            ramsLogo.DrawLine(redPen, 210, 70, 220, 70);

            ramsLogo.DrawLine(redPen, 215, 100, 215, 110);
            ramsLogo.DrawLine(redPen, 215, 140, 215, 150);
            ramsLogo.DrawLine(redPen, 215, 180, 215, 190);
            ramsLogo.DrawLine(redPen, 215, 220, 215, 230);

            redPen.Color = Color.Yellow;
            whiteBrush.Color = Color.Yellow;
            //FillPie(brush, x, y, width, height, startAngle, arcAngle)
            //DrawPie (pen, x, y, width, height, startAngle, arcAngle) 
            ramsLogo.DrawPie(redPen, 35, 55, 30, 30, 40, 260);
            ramsLogo.FillPie(whiteBrush, 35, 55, 30, 30, 40, 260);

            packMan.Visible = true;
            packMan.ForeColor = Color.White;

        }

        private void playButton_MouseHover(object sender, EventArgs e)
        {
            playButton.BackColor = Color.Green;
        }

        private void playButton_MouseLeave(object sender, EventArgs e)
        {
            playButton.BackColor = Color.Black;
        }

        private void packMan_Click(object sender, EventArgs e)
        {
            Graphics packManGame = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 10);
            Pen yellowPen = new Pen(Color.Yellow, 10);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            Font endFont = new Font("Modern No. 20", 16, FontStyle.Bold);

            //FillPie(brush, x, y, width, height, startAngle, arcAngle)
            //DrawPie (pen, x, y, width, height, startAngle, arcAngle)

            packManGame.FillPie(blackBrush, 35, 55, 30, 30, 40, 260);
            packManGame.DrawPie(blackPen, 35, 55, 30, 30, 40, 260);

            packManGame.DrawPie(yellowPen, 70, 55, 30, 30, 40, 360);
            packManGame.FillPie(yellowBrush, 70, 55, 30, 30, 40, 360);

            Thread.Sleep(0200);

            packManGame.DrawPie(blackPen, 70, 55, 30, 30, 40, 360);
            packManGame.FillPie(blackBrush, 70, 55, 30, 30, 40, 360);

            Thread.Sleep(0200);

            packManGame.FillPie(yellowBrush, 70, 55, 30, 30, 40, 260);
            packManGame.DrawPie(yellowPen, 70, 55, 30, 30, 40, 260);

            Thread.Sleep(0200);

            packManGame.FillPie(blackBrush, 70, 55, 30, 30, 40, 260);
            packManGame.DrawPie(blackPen, 70, 55, 30, 30, 40, 260);

            Thread.Sleep(0200);

            packManGame.DrawPie(yellowPen, 120, 55, 30, 30, 40, 360);
            packManGame.FillPie(yellowBrush, 120, 55, 30, 30, 40, 360);
           
            Thread.Sleep(0200);

            packManGame.DrawPie(blackPen, 120, 55, 30, 30, 40, 360);
            packManGame.FillPie(blackBrush, 120, 55, 30, 30, 40, 360);

            Thread.Sleep(0200);

            packManGame.DrawPie(yellowPen, 160, 55, 30, 30, 40, 260);
            packManGame.FillPie(yellowBrush, 160, 55, 30, 30, 40, 260);

            Thread.Sleep(0200);

            packManGame.DrawPie(blackPen, 160, 55, 30, 30, 40, 360);
            packManGame.FillPie(blackBrush, 160, 55, 30, 30, 40, 360);

            Thread.Sleep(0200);

            packManGame.DrawPie(yellowPen, 200, 55, 30, 30, 40, 260);
            packManGame.FillPie(yellowBrush, 200, 55, 30, 30, 40, 260);

            Thread.Sleep(0200);

            packManGame.DrawPie(blackPen, 200, 55, 30, 30, 40, 260);
            packManGame.FillPie(blackBrush, 200, 55, 30, 30, 40, 260);

            Thread.Sleep(0200);

            packManGame.DrawPie(yellowPen, 200, 55, 30, 30, 40, 360);
            packManGame.FillPie(yellowBrush, 200, 55, 30, 30, 40, 360);

            Thread.Sleep(0200);

            packManGame.DrawPie(blackPen, 200, 55, 30, 30, 40, 360);
            packManGame.FillPie(blackBrush, 200, 55, 30, 30, 40, 360);

            Thread.Sleep(0200);

            //
            //packManGame.RotateTransform(180);
            //

            packManGame.DrawPie(yellowPen, 200, 100, 30, 30, 40, 260);
            packManGame.FillPie(yellowBrush, 200, 100, 30, 30, 40, 260);

            Thread.Sleep(0200);

            packManGame.DrawPie(blackPen, 200, 100, 30, 30, 40, 260);
            packManGame.FillPie(blackBrush, 200, 100, 30, 30, 40, 260);
            
            Thread.Sleep(0200);

            packManGame.DrawPie(yellowPen, 200, 100, 30, 30, 40, 360);
            packManGame.FillPie(yellowBrush, 200, 100, 30, 30, 40, 360);

            Thread.Sleep(0200);

            packManGame.DrawPie(blackPen, 200, 100, 30, 30, 40, 360);
            packManGame.FillPie(blackBrush, 200, 100, 30, 30, 40, 360);

            Thread.Sleep(0200);

            packManGame.DrawPie(yellowPen, 200, 125, 30, 30, 40, 260);
            packManGame.FillPie(yellowBrush, 200, 125, 30, 30, 40, 260);

            Thread.Sleep(0200);

            packManGame.DrawPie(blackPen, 200, 125, 30, 30, 40, 260);
            packManGame.FillPie(blackBrush, 200, 125, 30, 30, 40, 260);

            Thread.Sleep(0200);

            packManGame.DrawPie(yellowPen, 200, 165, 30, 30, 40, 260);
            packManGame.FillPie(yellowBrush, 200, 165, 30, 30, 40, 260);

            Thread.Sleep(0200);

            packManGame.DrawPie(yellowPen, 200, 165, 30, 30, 40, 360);
            packManGame.FillPie(yellowBrush, 200, 165, 30, 30, 40, 360);

            Thread.Sleep(0200);

            packManGame.DrawPie(blackPen, 200, 165, 30, 30, 40, 360);
            packManGame.FillPie(blackBrush, 200, 165, 30, 30, 40, 360);

            Thread.Sleep(0200);

            packManGame.DrawPie(blackPen, 200, 180, 30, 30, 40, 260);
            packManGame.FillPie(blackBrush, 200, 180, 30, 30, 40, 260);

            Thread.Sleep(0200);

            packManGame.DrawPie(yellowPen, 200, 200, 30, 30, 40, 260);
            packManGame.FillPie(yellowBrush, 200, 200, 30, 30, 40, 260);

            packManGame.DrawString("Congradulations", endFont, yellowBrush, 10, 170);
        }


        private void standardArcade_Load(object sender, EventArgs e)
        {
            packMan.Visible = false;
        }
    }
}
