using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gacha
{
    public partial class Gacha : Form
    {
        Random r;
        int ran;
        string card1_r, card2_r, card3_r, card4_r, card5_r, card6_r, card7_r, card8_r, card9_r, card10_r;
        bool c1, c2, c3, c4, c5, c6, c7, c8, c9, c10;

        public Gacha()
        {
            InitializeComponent();
            this.CenterToScreen();
            card1.SizeMode = PictureBoxSizeMode.StretchImage;
            card2.SizeMode = PictureBoxSizeMode.StretchImage;
            card3.SizeMode = PictureBoxSizeMode.StretchImage;
            card4.SizeMode = PictureBoxSizeMode.StretchImage;
            card5.SizeMode = PictureBoxSizeMode.StretchImage;
            card6.SizeMode = PictureBoxSizeMode.StretchImage;
            card7.SizeMode = PictureBoxSizeMode.StretchImage;
            card8.SizeMode = PictureBoxSizeMode.StretchImage;
            card9.SizeMode = PictureBoxSizeMode.StretchImage;
            card10.SizeMode = PictureBoxSizeMode.StretchImage;
            r = new Random();
            Card_R();
        }

        private void Gacha_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Card_R()
        {
            int num = 1;
            while (num < 11)
            {
                ran = r.Next(1, 101);
                if (num == 1)
                {
                    if (1 <= ran && ran <= 90)
                    {
                        card1.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card1_r = "R";
                    }
                    else if (91 <= ran && ran <= 99)
                    {
                        card1.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card1_r = "U";
                    }
                    else
                    {
                        card1.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card1_r = "E";
                    }
                }
                
                if (num == 2)
                {
                    if (1 <= ran && ran <= 90)
                    {
                        card2.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card2_r = "R";
                    }
                    else if (91 <= ran && ran <= 99)
                    {
                        card2.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card2_r = "U";
                    }
                    else
                    {
                        card2.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card2_r = "E";
                    }
                }
                
                if (num == 3)
                {
                    if (1 <= ran && ran <= 90)
                    {
                        card3.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card3_r = "R";
                    }
                    else if (91 <= ran && ran <= 99)
                    {
                        card3.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card3_r = "U";
                    }
                    else
                    {
                        card3.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card3_r = "E";
                    }
                }

                if (num == 4)
                {
                    if (1 <= ran && ran <= 90)
                    {
                        card4.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card4_r = "R";
                    }
                    else if (91 <= ran && ran <= 99)
                    {
                        card4.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card4_r = "U";
                    }
                    else
                    {
                        card4.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card4_r = "E";
                    }
                }

                if (num == 5)
                {
                    if (1 <= ran && ran <= 90)
                    {
                        card5.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card5_r = "R";
                    }
                    else if (91 <= ran && ran <= 99)
                    {
                        card5.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card5_r = "U";
                    }
                    else
                    {
                        card5.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card5_r = "E";
                    }
                }

                if (num == 6)
                {
                    if (1 <= ran && ran <= 90)
                    {
                        card6.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card6_r = "R";
                    }
                    else if (91 <= ran && ran <= 99)
                    {
                        card6.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card6_r = "U";
                    }
                    else
                    {
                        card6.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card6_r = "E";
                    }
                }

                if (num == 7)
                {
                    if (1 <= ran && ran <= 90)
                    {
                        card7.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card7_r = "R";
                    }
                    else if (91 <= ran && ran <= 99)
                    {
                        card7.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card7_r = "U";
                    }
                    else
                    {
                        card7.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card7_r = "E";
                    }
                }

                if (num == 8)
                {
                    if (1 <= ran && ran <= 90)
                    {
                        card8.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card8_r = "R";
                    }
                    else if (91 <= ran && ran <= 99)
                    {
                        card8.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card8_r = "U";
                    }
                    else
                    {
                        card8.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card8_r = "E";
                    }
                }

                if (num == 9)
                {
                    if (1 <= ran && ran <= 90)
                    {
                        card9.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card9_r = "R";
                    }
                    else if (91 <= ran && ran <= 99)
                    {
                        card9.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card9_r = "U";
                    }
                    else
                    {
                        card9.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card9_r = "E";
                    }
                }

                if (num == 10)
                {
                    if (1 <= ran && ran <= 90)
                    {
                        card10.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card10_r = "R";
                    }
                    else if (91 <= ran && ran <= 99)
                    {
                        card10.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card10_r = "U";
                    }
                    else
                    {
                        card10.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\뒷면.PNG");
                        card10_r = "E";
                    }
                }
                num++;
            }
        }

        private void card1_Click(object sender, EventArgs e)
        {
            card1.Enabled = false;
            c1 = true;
            if (card1_r == "R")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "레어음.mp3";
                R_play.controls.play();

                ran = r.Next(1, 6);
                if (ran == 1) card1.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_메이스.png");
                else if (ran == 2) card1.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_미쉘.png");
                else if (ran == 3) card1.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_시엘.png");
                else if (ran == 4) card1.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_워잭.png");
                else if (ran == 5) card1.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_황궁.png");
            }

            else if (card1_r == "U")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "유니크음.mp3";
                R_play.controls.play();

                ran = r.Next(1, 6);
                if (ran == 1) card1.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_누골.png");
                else if (ran == 2) card1.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_비노슈.png");
                else if (ran == 3) card1.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_사룡.png");
                else if (ran == 4) card1.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_지그.png");
                else if (ran == 5) card1.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_피터.png");
            }

            else if (card1_r == "E")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "에픽음.mp3";
                R_play.controls.play();

                card1.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\에픽_광룡.PNG");
            }
        }

        private void card2_Click(object sender, EventArgs e)
        {
            card2.Enabled = false;
            c2 = true;
            if (card2_r == "R")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "레어음.mp3";
                R_play.controls.play();

                ran = r.Next(1, 6);
                if (ran == 1) card2.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_메이스.png");
                else if (ran == 2) card2.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_미쉘.png");
                else if (ran == 3) card2.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_시엘.png");
                else if (ran == 4) card2.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_워잭.png");
                else if (ran == 5) card2.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_황궁.png");
            }

            else if (card2_r == "U")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "유니크음.mp3";
                R_play.controls.play();

                ran = r.Next(1, 6);
                if (ran == 1) card2.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_누골.png");
                else if (ran == 2) card2.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_비노슈.png");
                else if (ran == 3) card2.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_사룡.png");
                else if (ran == 4) card2.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_지그.png");
                else if (ran == 5) card2.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_피터.png");
            }

            else if (card2_r == "E")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "에픽음.mp3";
                R_play.controls.play();

                card2.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\에픽_광룡.PNG");
            }
        }

        private void card3_Click(object sender, EventArgs e)
        {
            card3.Enabled = false;
            c3 = true;
            if (card3_r == "R")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "레어음.mp3";
                R_play.controls.play();

                ran = r.Next(1, 6);
                if (ran == 1) card3.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_메이스.png");
                else if (ran == 2) card3.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_미쉘.png");
                else if (ran == 3) card3.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_시엘.png");
                else if (ran == 4) card3.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_워잭.png");
                else if (ran == 5) card3.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_황궁.png");
            }

            else if (card3_r == "U")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "유니크음.mp3";
                R_play.controls.play();

                ran = r.Next(1, 6);
                if (ran == 1) card3.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_누골.png");
                else if (ran == 2) card3.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_비노슈.png");
                else if (ran == 3) card3.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_사룡.png");
                else if (ran == 4) card3.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_지그.png");
                else if (ran == 5) card3.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_피터.png");
            }

            else if (card3_r == "E")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "에픽음.mp3";
                R_play.controls.play();

                card3.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\에픽_광룡.PNG");
            }
        }

        private void card4_Click(object sender, EventArgs e)
        {
            card4.Enabled = false;
            c4 = true;
            if (card4_r == "R")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "레어음.mp3";
                R_play.controls.play();

                ran = r.Next(1, 6);
                if (ran == 1) card4.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_메이스.png");
                else if (ran == 2) card4.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_미쉘.png");
                else if (ran == 3) card4.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_시엘.png");
                else if (ran == 4) card4.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_워잭.png");
                else if (ran == 5) card4.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_황궁.png");
            }

            else if (card4_r == "U")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "유니크음.mp3";
                R_play.controls.play();

                ran = r.Next(1, 6);
                if (ran == 1) card4.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_누골.png");
                else if (ran == 2) card4.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_비노슈.png");
                else if (ran == 3) card4.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_사룡.png");
                else if (ran == 4) card4.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_지그.png");
                else if (ran == 5) card4.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_피터.png");
            }

            else if (card4_r == "E")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "에픽음.mp3";
                R_play.controls.play();

                card4.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\에픽_광룡.PNG");
            }
        }

        private void card5_Click(object sender, EventArgs e)
        {
            card5.Enabled = false;
            c5 = true;
            if (card5_r == "R")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "레어음.mp3";
                R_play.controls.play();

                ran = r.Next(1, 6);
                if (ran == 1) card5.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_메이스.png");
                else if (ran == 2) card5.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_미쉘.png");
                else if (ran == 3) card5.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_시엘.png");
                else if (ran == 4) card5.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_워잭.png");
                else if (ran == 5) card5.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_황궁.png");
            }

            else if (card5_r == "U")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "유니크음.mp3";
                R_play.controls.play();

                ran = r.Next(1, 6);
                if (ran == 1) card5.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_누골.png");
                else if (ran == 2) card5.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_비노슈.png");
                else if (ran == 3) card5.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_사룡.png");
                else if (ran == 4) card5.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_지그.png");
                else if (ran == 5) card5.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_피터.png");
            }

            else if (card5_r == "E")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "에픽음.mp3";
                R_play.controls.play();

                card5.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\에픽_광룡.PNG");
            }
        }

        private void card6_Click(object sender, EventArgs e)
        {
            card6.Enabled = false;
            c6 = true;
            if (card6_r == "R")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "레어음.mp3";
                R_play.controls.play();

                ran = r.Next(1, 6);
                if (ran == 1) card6.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_메이스.png");
                else if (ran == 2) card6.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_미쉘.png");
                else if (ran == 3) card6.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_시엘.png");
                else if (ran == 4) card6.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_워잭.png");
                else if (ran == 5) card6.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_황궁.png");
            }

            else if (card6_r == "U")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "유니크음.mp3";
                R_play.controls.play();

                ran = r.Next(1, 6);
                if (ran == 1) card6.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_누골.png");
                else if (ran == 2) card6.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_비노슈.png");
                else if (ran == 3) card6.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_사룡.png");
                else if (ran == 4) card6.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_지그.png");
                else if (ran == 5) card6.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_피터.png");
            }

            else if (card6_r == "E")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "에픽음.mp3";
                R_play.controls.play();

                card6.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\에픽_광룡.PNG");
            }
        }

        private void card7_Click(object sender, EventArgs e)
        {
            card7.Enabled = false;
            c7 = true;
            if (card7_r == "R")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "레어음.mp3";
                R_play.controls.play();

                ran = r.Next(1, 6);
                if (ran == 1) card7.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_메이스.png");
                else if (ran == 2) card7.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_미쉘.png");
                else if (ran == 3) card7.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_시엘.png");
                else if (ran == 4) card7.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_워잭.png");
                else if (ran == 5) card7.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_황궁.png");
            }

            else if (card7_r == "U")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "유니크음.mp3";
                R_play.controls.play();

                ran = r.Next(1, 6);
                if (ran == 1) card7.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_누골.png");
                else if (ran == 2) card7.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_비노슈.png");
                else if (ran == 3) card7.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_사룡.png");
                else if (ran == 4) card7.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_지그.png");
                else if (ran == 5) card7.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_피터.png");
            }

            else if (card7_r == "E")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "에픽음.mp3";
                R_play.controls.play();

                card7.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\에픽_광룡.PNG");
            }
        }

        private void card8_Click(object sender, EventArgs e)
        {
            card8.Enabled = false;
            c8 = true;
            if (card8_r == "R")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "레어음.mp3";
                R_play.controls.play();

                ran = r.Next(1, 6);
                if (ran == 1) card8.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_메이스.png");
                else if (ran == 2) card8.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_미쉘.png");
                else if (ran == 3) card8.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_시엘.png");
                else if (ran == 4) card8.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_워잭.png");
                else if (ran == 5) card8.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_황궁.png");
            }

            else if (card8_r == "U")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "유니크음.mp3";
                R_play.controls.play();

                ran = r.Next(1, 6);
                if (ran == 1) card8.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_누골.png");
                else if (ran == 2) card8.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_비노슈.png");
                else if (ran == 3) card8.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_사룡.png");
                else if (ran == 4) card8.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_지그.png");
                else if (ran == 5) card8.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_피터.png");
            }

            else if (card8_r == "E")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "에픽음.mp3";
                R_play.controls.play();

                card8.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\에픽_광룡.PNG");
            }
        }

        private void card9_Click(object sender, EventArgs e)
        {
            card9.Enabled = false;
            c9 = true;
            if (card9_r == "R")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "레어음.mp3";
                R_play.controls.play();

                ran = r.Next(1, 6);
                if (ran == 1) card9.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_메이스.png");
                else if (ran == 2) card9.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_미쉘.png");
                else if (ran == 3) card9.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_시엘.png");
                else if (ran == 4) card9.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_워잭.png");
                else if (ran == 5) card9.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_황궁.png");
            }

            else if (card9_r == "U")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "유니크음.mp3";
                R_play.controls.play();

                ran = r.Next(1, 6);
                if (ran == 1) card9.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_누골.png");
                else if (ran == 2) card9.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_비노슈.png");
                else if (ran == 3) card9.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_사룡.png");
                else if (ran == 4) card9.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_지그.png");
                else if (ran == 5) card9.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_피터.png");
            }

            else if (card9_r == "E")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "에픽음.mp3";
                R_play.controls.play();

                card9.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\에픽_광룡.PNG");
            }
        }

        private void card10_Click(object sender, EventArgs e)
        {
            card10.Enabled = false;
            c10 = true;
            if (card10_r == "R")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "레어음.mp3";
                R_play.controls.play();

                ran = r.Next(1, 6);
                if (ran == 1) card10.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_메이스.png");
                else if (ran == 2) card10.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_미쉘.png");
                else if (ran == 3) card10.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_시엘.png");
                else if (ran == 4) card10.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_워잭.png");
                else if (ran == 5) card10.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\레어_황궁.png");
            }

            else if (card10_r == "U")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "유니크음.mp3";
                R_play.controls.play();

                ran = r.Next(1, 6);
                if (ran == 1) card10.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_누골.png");
                else if (ran == 2) card10.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_비노슈.png");
                else if (ran == 3) card10.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_사룡.png");
                else if (ran == 4) card10.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_지그.png");
                else if (ran == 5) card10.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\유니크_피터.png");
            }

            else if (card10_r == "E")
            {
                WMPLib.WindowsMediaPlayer R_play = new WMPLib.WindowsMediaPlayer();
                R_play.URL = "에픽음.mp3";
                R_play.controls.play();

                card10.Load(@"C:\Users\Zeek\source\repos\Gacha\bin\Debug\에픽_광룡.PNG");
            }
        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            btn_All.Enabled = false;
            if (c1 == false) card1_Click(sender, e);
            if (c2 == false) card2_Click(sender, e);
            if (c3 == false) card3_Click(sender, e);
            if (c4 == false) card4_Click(sender, e);
            if (c5 == false) card5_Click(sender, e);
            if (c6 == false) card6_Click(sender, e);
            if (c7 == false) card7_Click(sender, e);
            if (c8 == false) card8_Click(sender, e);
            if (c9 == false) card9_Click(sender, e);
            if (c10 == false) card10_Click(sender, e);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            if (c1 == true && c2 == true && c3 == true && c4 == true && c5 == true && c6 == true && c7 == true && c8 == true && c9 == true && c10 == true)
            {
                Card_R();
                btn_All.Enabled = true;
                card1.Enabled = true;
                card2.Enabled = true;
                card3.Enabled = true;
                card4.Enabled = true;
                card5.Enabled = true;
                card6.Enabled = true;
                card7.Enabled = true;
                card8.Enabled = true;
                card9.Enabled = true;
                card10.Enabled = true;
                c1 = false;
                c2 = false;
                c3 = false;
                c4 = false;
                c5 = false;
                c6 = false;
                c7 = false;
                c8 = false;
                c9 = false;
                c10 = false;
            }
            else MessageBox.Show("모든 카드를 오픈해주세요.");
        }
    }
}
