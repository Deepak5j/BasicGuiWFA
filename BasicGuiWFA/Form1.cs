using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BasicGuiWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //----------------------------1st button MyComputer----------------------------------------------
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = BasicGuiWFA.Properties.Resources.i1;
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = BasicGuiWFA.Properties.Resources.j1;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("::{20d04fe0-3aea-1069-a2d8-08002b30309d}");
                //System.Diagnostics.Process.Start("iexplore.exe", "::{20d04fe0-3aea-1069-a2d8-08002b30309d}");
                //System.Diagnostics.Process.Start("iexplore.exe", "::{450d8fba-ad25-11d0-98a8-0800361b1103}");
            }
            catch (Exception)
            {
                MessageBox.Show("Error! cannot open MyComputer");
            }
        }
        //----------------------------2th button control pannel----------------------------------------------
        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Image = BasicGuiWFA.Properties.Resources.i2;
        }
        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = BasicGuiWFA.Properties.Resources.j2;
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("control.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("Error! cannot open control pannel");
            }
        }
        //----------------------------3th button recycel bin----------------------------------------------
        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.Image = BasicGuiWFA.Properties.Resources.i3;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = BasicGuiWFA.Properties.Resources.j3;
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("::{645FF040-5081-101B-9F08-00AA002F954E}");
            }
            catch (Exception)
            {
                MessageBox.Show("Error! cannot open recycle bin");
            }
        }
        //----------------------------4th button vlc media player----------------------------------------------
        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Image = BasicGuiWFA.Properties.Resources.i4;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = BasicGuiWFA.Properties.Resources.j4;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("C:\\Program Files\\VideoLAN\\VLC\\vlc.exe");
            }
            catch 
            {
                try
                {
                    System.Diagnostics.Process.Start(@"C:\Program Files\VideoLAN\VLC\vlc.exe");
                }
                catch (Exception) 
                {
                    MessageBox.Show("Cannot open vlc media player.\nFile not found!\n");
                }

            }
        }
        //----------------------------5th button windo media player----------------------------------------------
        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Image = BasicGuiWFA.Properties.Resources.i6;
        }
        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = BasicGuiWFA.Properties.Resources.j6;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("wmplayer.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("Error! cannot ope window media player");
            }
        }
        //----------------------------6th button chrome----------------------------------------------
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = BasicGuiWFA.Properties.Resources.i5;
        }
        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = BasicGuiWFA.Properties.Resources.j5;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //WinExec("c:\\windows\\system32\\control.exe", SW_NORMAL);
            try
            {
                System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe");
            }
            catch(Exception)
            {
                System.Diagnostics.Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");
            }
        }
        //----------------------------close button----------------------------------------------
        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.Image = BasicGuiWFA.Properties.Resources.close1;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Image = BasicGuiWFA.Properties.Resources.close;
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //----------------------borderless form movable-------------------------------------
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("General Utility App v1.0\n\nDeveloped by Deepak Gautam\n\ngautamxdeepak@gmail.com");
        }
        //-----------------------------------------------------------------------------------------       
    }
}
