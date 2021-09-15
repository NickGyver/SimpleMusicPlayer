//Version 0.1
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;


namespace SimpleMusicPlayer
{
    public partial class SimpleMediaPlayer : Form
    {
        ////////////borderless window moving////////////////
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        ////////////////////////////////////////////////////
        OpenFileDialog openFileDg = new OpenFileDialog();
        List<string> str = new List<string>();
        string[] paths, files;

        public SimpleMediaPlayer()
        {
            InitializeComponent();

        }
        private void closeProgramButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void SimpleMediaPlayer_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }
        ////////////borderless window moving////////////////
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void appPicture_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        ////////////////////////////////////////////////////
        private void Form1_Load(object sender, EventArgs e)
        {
            WindowsMediaPlayer.uiMode = "none";
            //playList.ValueMember = "Path";
            //playList.DisplayMember = "FileName";
            volumeTrackbar.Value = 25;
            WindowsMediaPlayer.settings.volume = volumeTrackbar.Value;
            volPercent.Text = volumeTrackbar.Value.ToString();
        }
        private void openFileButton_Click(object sender, EventArgs e)
        {          
            openFileDg.Multiselect = true;
            openFileDg.Filter = "All files|*.*|WMV|*.vmw|WAV|*.wav|MP3|*.mp3|MP4|*.mp4|MKV|*.mkv";

            if (openFileDg.ShowDialog() == DialogResult.Cancel)
                return;

            foreach (string s in openFileDg.FileNames)
            {
                playList.Items.Add(Path.GetFullPath(s));
                str.Add(s);
            }

        }
        private void playList_SelectedIndexChanged(object sender, EventArgs e)
        {
            favouritesList.ClearSelected();
         //   txt.Text = playList.Text;           
            addToFavButton.Enabled = true;
        }
        private void favouritesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            playList.ClearSelected();
         //   txt.Text = favouritesList.Text;
        }
        private void playButton_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.URL = @playList.Text;
            WindowsMediaPlayer.URL = @favouritesList.Text;
            WindowsMediaPlayer.Ctlcontrols.play();
            txt.Text = WindowsMediaPlayer.currentMedia.name;
            
        }
        private void pauseButton_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.pause();
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.stop();
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (playList.SelectedIndex<playList.Items.Count-1)
            {
                playList.SelectedIndex = playList.SelectedIndex + 1;
            }
        }
        private void previousButton_Click(object sender, EventArgs e)
        {
            if (playList.SelectedIndex >0)
            {
                playList.SelectedIndex = playList.SelectedIndex - 1;
            }
        }
        private void volumeTrackbar_Scroll(object sender, EventArgs e)
        {
            WindowsMediaPlayer.settings.volume = volumeTrackbar.Value;
            volPercent.Text = volumeTrackbar.Value.ToString();
        }
        
        private void WindowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)//progress
        {
            if (WindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)WindowsMediaPlayer.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (WindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if (WindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                progressBar1.Value = 0;
            }
           
        }

        private void addToFavButton_Click(object sender, EventArgs e)
        {
            addToFavButton.Enabled = false;
            favouritesList.Items.Add(txt.Text);
            saveFavListButton.Enabled = true;
        }

        private void openFavListButton_Click(object sender, EventArgs e)
        {

            openFileDg.Filter = "Text Files|*.txt";
            if (openFileDg.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader read = new StreamReader(openFileDg.FileName))
                {
                    string line;
                    while ((line = read.ReadLine()) != null) 
                    {
                        favouritesList.Items.Add(line);
                    }
                }
            }
        }
        private void deleteFavButton_Click(object sender, EventArgs e)
        {
            if (favouritesList.SelectedItems.Count>0)
            {
                favouritesList.Items.Remove(favouritesList.SelectedItems[0]);
            }
        }
        private void saveFavListButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Save = new StreamWriter(sfd.FileName);
                foreach (var item in favouritesList.Items)
                {
                    Save.WriteLine(item.ToString());
                    this.Refresh();
                }
                MessageBox.Show("Saved to Favourites list!");
                Save.Close();
                favouritesList.Items.Clear();
                saveFavListButton.Enabled = false;
                addToFavButton.Enabled = true;
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            progressLabel.Text = WindowsMediaPlayer.Ctlcontrols.currentPositionString;
            durationLabel.Text = WindowsMediaPlayer.Ctlcontrols.currentItem.durationString.ToString();
            if (WindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Value = (int)WindowsMediaPlayer.Ctlcontrols.currentPosition;
            }
        }
    }
}
