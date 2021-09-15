
namespace SimpleMusicPlayer
{
    partial class SimpleMediaPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleMediaPlayer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.appPicture = new System.Windows.Forms.PictureBox();
            this.closeProgramButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileButton = new System.Windows.Forms.Button();
            this.openFavListButton = new System.Windows.Forms.Button();
            this.WindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.progressLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.volumePicture = new System.Windows.Forms.PictureBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pauseButton = new System.Windows.Forms.Button();
            this.volPercent = new System.Windows.Forms.Label();
            this.volumeTrackbar = new System.Windows.Forms.TrackBar();
            this.nextButton = new System.Windows.Forms.Button();
            this.playList = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.favouritesList = new System.Windows.Forms.ListBox();
            this.addToFavButton = new System.Windows.Forms.Button();
            this.deleteFavButton = new System.Windows.Forms.Button();
            this.saveFavListButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.favoritePlaylistGB = new System.Windows.Forms.GroupBox();
            this.recentPlaylistGB = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackbar)).BeginInit();
            this.panel3.SuspendLayout();
            this.favoritePlaylistGB.SuspendLayout();
            this.recentPlaylistGB.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.appPicture);
            this.panel1.Controls.Add(this.closeProgramButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 31);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // appPicture
            // 
            this.appPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.appPicture.Image = ((System.Drawing.Image)(resources.GetObject("appPicture.Image")));
            this.appPicture.Location = new System.Drawing.Point(0, 0);
            this.appPicture.Name = "appPicture";
            this.appPicture.Size = new System.Drawing.Size(34, 31);
            this.appPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appPicture.TabIndex = 12;
            this.appPicture.TabStop = false;
            this.appPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.appPicture_MouseDown);
            // 
            // closeProgramButton
            // 
            this.closeProgramButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeProgramButton.FlatAppearance.BorderSize = 0;
            this.closeProgramButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeProgramButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeProgramButton.ForeColor = System.Drawing.SystemColors.Control;
            this.closeProgramButton.Location = new System.Drawing.Point(852, 0);
            this.closeProgramButton.Name = "closeProgramButton";
            this.closeProgramButton.Size = new System.Drawing.Size(50, 31);
            this.closeProgramButton.TabIndex = 6;
            this.closeProgramButton.Text = "X";
            this.closeProgramButton.UseVisualStyleBackColor = true;
            this.closeProgramButton.Click += new System.EventHandler(this.closeProgramButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(40, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "SimpleMediaPlayer v0.1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // openFileButton
            // 
            this.openFileButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.openFileButton.FlatAppearance.BorderSize = 0;
            this.openFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFileButton.Image = ((System.Drawing.Image)(resources.GetObject("openFileButton.Image")));
            this.openFileButton.Location = new System.Drawing.Point(0, 0);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(34, 30);
            this.openFileButton.TabIndex = 1;
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // openFavListButton
            // 
            this.openFavListButton.FlatAppearance.BorderSize = 0;
            this.openFavListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFavListButton.Image = ((System.Drawing.Image)(resources.GetObject("openFavListButton.Image")));
            this.openFavListButton.Location = new System.Drawing.Point(57, 0);
            this.openFavListButton.Name = "openFavListButton";
            this.openFavListButton.Size = new System.Drawing.Size(34, 37);
            this.openFavListButton.TabIndex = 6;
            this.openFavListButton.UseVisualStyleBackColor = true;
            this.openFavListButton.Click += new System.EventHandler(this.openFavListButton_Click);
            // 
            // WindowsMediaPlayer
            // 
            this.WindowsMediaPlayer.Enabled = true;
            this.WindowsMediaPlayer.Location = new System.Drawing.Point(0, 31);
            this.WindowsMediaPlayer.Name = "WindowsMediaPlayer";
            this.WindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer.OcxState")));
            this.WindowsMediaPlayer.Size = new System.Drawing.Size(690, 400);
            this.WindowsMediaPlayer.TabIndex = 7;
            this.WindowsMediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.WindowsMediaPlayer_PlayStateChange);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // playButton
            // 
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
            this.playButton.Location = new System.Drawing.Point(246, 16);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(34, 37);
            this.playButton.TabIndex = 9;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.Location = new System.Drawing.Point(183, 16);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(34, 37);
            this.stopButton.TabIndex = 10;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.volumePicture);
            this.panel2.Controls.Add(this.previousButton);
            this.panel2.Controls.Add(this.playButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pauseButton);
            this.panel2.Controls.Add(this.volPercent);
            this.panel2.Controls.Add(this.stopButton);
            this.panel2.Controls.Add(this.volumeTrackbar);
            this.panel2.Controls.Add(this.nextButton);
            this.panel2.Location = new System.Drawing.Point(0, 465);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 59);
            this.panel2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(583, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "/";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.durationLabel.Location = new System.Drawing.Point(598, 441);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(58, 18);
            this.durationLabel.TabIndex = 20;
            this.durationLabel.Text = "00:00";
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progressLabel.Location = new System.Drawing.Point(529, 441);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(58, 18);
            this.progressLabel.TabIndex = 19;
            this.progressLabel.Text = "00:00";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(688, 10);
            this.progressBar1.TabIndex = 18;
            // 
            // volumePicture
            // 
            this.volumePicture.Image = ((System.Drawing.Image)(resources.GetObject("volumePicture.Image")));
            this.volumePicture.Location = new System.Drawing.Point(515, 24);
            this.volumePicture.Name = "volumePicture";
            this.volumePicture.Size = new System.Drawing.Size(21, 24);
            this.volumePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.volumePicture.TabIndex = 17;
            this.volumePicture.TabStop = false;
            // 
            // previousButton
            // 
            this.previousButton.FlatAppearance.BorderSize = 0;
            this.previousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousButton.Image = ((System.Drawing.Image)(resources.GetObject("previousButton.Image")));
            this.previousButton.Location = new System.Drawing.Point(106, 16);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(34, 37);
            this.previousButton.TabIndex = 16;
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "%";
            // 
            // pauseButton
            // 
            this.pauseButton.FlatAppearance.BorderSize = 0;
            this.pauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseButton.Image = ((System.Drawing.Image)(resources.GetObject("pauseButton.Image")));
            this.pauseButton.Location = new System.Drawing.Point(305, 16);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(34, 37);
            this.pauseButton.TabIndex = 14;
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // volPercent
            // 
            this.volPercent.AutoSize = true;
            this.volPercent.Location = new System.Drawing.Point(651, 25);
            this.volPercent.Name = "volPercent";
            this.volPercent.Size = new System.Drawing.Size(18, 19);
            this.volPercent.TabIndex = 12;
            this.volPercent.Text = "0";
            // 
            // volumeTrackbar
            // 
            this.volumeTrackbar.Cursor = System.Windows.Forms.Cursors.Default;
            this.volumeTrackbar.Location = new System.Drawing.Point(535, 24);
            this.volumeTrackbar.Maximum = 100;
            this.volumeTrackbar.Name = "volumeTrackbar";
            this.volumeTrackbar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.volumeTrackbar.Size = new System.Drawing.Size(110, 45);
            this.volumeTrackbar.TabIndex = 11;
            this.volumeTrackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeTrackbar.Scroll += new System.EventHandler(this.volumeTrackbar_Scroll);
            // 
            // nextButton
            // 
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Image = ((System.Drawing.Image)(resources.GetObject("nextButton.Image")));
            this.nextButton.Location = new System.Drawing.Point(375, 17);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(34, 37);
            this.nextButton.TabIndex = 15;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // playList
            // 
            this.playList.BackColor = System.Drawing.SystemColors.GrayText;
            this.playList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.playList.FormattingEnabled = true;
            this.playList.HorizontalScrollbar = true;
            this.playList.ItemHeight = 19;
            this.playList.Location = new System.Drawing.Point(3, 54);
            this.playList.Name = "playList";
            this.playList.Size = new System.Drawing.Size(200, 192);
            this.playList.TabIndex = 8;
            this.playList.SelectedIndexChanged += new System.EventHandler(this.playList_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // favouritesList
            // 
            this.favouritesList.BackColor = System.Drawing.SystemColors.GrayText;
            this.favouritesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.favouritesList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.favouritesList.FormattingEnabled = true;
            this.favouritesList.HorizontalScrollbar = true;
            this.favouritesList.ItemHeight = 19;
            this.favouritesList.Location = new System.Drawing.Point(3, 64);
            this.favouritesList.Name = "favouritesList";
            this.favouritesList.Size = new System.Drawing.Size(200, 173);
            this.favouritesList.TabIndex = 12;
            this.favouritesList.SelectedIndexChanged += new System.EventHandler(this.favouritesList_SelectedIndexChanged);
            // 
            // addToFavButton
            // 
            this.addToFavButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addToFavButton.FlatAppearance.BorderSize = 0;
            this.addToFavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToFavButton.Image = ((System.Drawing.Image)(resources.GetObject("addToFavButton.Image")));
            this.addToFavButton.Location = new System.Drawing.Point(0, 0);
            this.addToFavButton.Name = "addToFavButton";
            this.addToFavButton.Size = new System.Drawing.Size(34, 39);
            this.addToFavButton.TabIndex = 13;
            this.addToFavButton.UseVisualStyleBackColor = true;
            this.addToFavButton.Click += new System.EventHandler(this.addToFavButton_Click);
            // 
            // deleteFavButton
            // 
            this.deleteFavButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteFavButton.FlatAppearance.BorderSize = 0;
            this.deleteFavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteFavButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteFavButton.Image")));
            this.deleteFavButton.Location = new System.Drawing.Point(164, 0);
            this.deleteFavButton.Name = "deleteFavButton";
            this.deleteFavButton.Size = new System.Drawing.Size(34, 39);
            this.deleteFavButton.TabIndex = 14;
            this.deleteFavButton.UseVisualStyleBackColor = true;
            this.deleteFavButton.Click += new System.EventHandler(this.deleteFavButton_Click);
            // 
            // saveFavListButton
            // 
            this.saveFavListButton.FlatAppearance.BorderSize = 0;
            this.saveFavListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveFavListButton.Image = ((System.Drawing.Image)(resources.GetObject("saveFavListButton.Image")));
            this.saveFavListButton.Location = new System.Drawing.Point(111, 0);
            this.saveFavListButton.Name = "saveFavListButton";
            this.saveFavListButton.Size = new System.Drawing.Size(34, 37);
            this.saveFavListButton.TabIndex = 15;
            this.saveFavListButton.UseVisualStyleBackColor = true;
            this.saveFavListButton.Click += new System.EventHandler(this.saveFavListButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.addToFavButton);
            this.panel3.Controls.Add(this.deleteFavButton);
            this.panel3.Controls.Add(this.saveFavListButton);
            this.panel3.Controls.Add(this.openFavListButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 41);
            this.panel3.TabIndex = 16;
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt.ForeColor = System.Drawing.Color.White;
            this.txt.Location = new System.Drawing.Point(44, 434);
            this.txt.Name = "txt";
            this.txt.ReadOnly = true;
            this.txt.Size = new System.Drawing.Size(450, 30);
            this.txt.TabIndex = 17;
            this.txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minimizeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.minimizeButton.Location = new System.Drawing.Point(802, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(50, 31);
            this.minimizeButton.TabIndex = 13;
            this.minimizeButton.Text = "_";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // favoritePlaylistGB
            // 
            this.favoritePlaylistGB.Controls.Add(this.favouritesList);
            this.favoritePlaylistGB.Controls.Add(this.panel3);
            this.favoritePlaylistGB.Location = new System.Drawing.Point(693, 285);
            this.favoritePlaylistGB.Name = "favoritePlaylistGB";
            this.favoritePlaylistGB.Size = new System.Drawing.Size(206, 240);
            this.favoritePlaylistGB.TabIndex = 18;
            this.favoritePlaylistGB.TabStop = false;
            this.favoritePlaylistGB.Text = "Favourites";
            // 
            // recentPlaylistGB
            // 
            this.recentPlaylistGB.Controls.Add(this.panel4);
            this.recentPlaylistGB.Controls.Add(this.playList);
            this.recentPlaylistGB.Location = new System.Drawing.Point(693, 33);
            this.recentPlaylistGB.Name = "recentPlaylistGB";
            this.recentPlaylistGB.Size = new System.Drawing.Size(206, 249);
            this.recentPlaylistGB.TabIndex = 19;
            this.recentPlaylistGB.TabStop = false;
            this.recentPlaylistGB.Text = "Recent playlist";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.openFileButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 32);
            this.panel4.TabIndex = 20;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SimpleMediaPlayer";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // SimpleMediaPlayer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(902, 527);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.recentPlaylistGB);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.favoritePlaylistGB);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.WindowsMediaPlayer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimpleMediaPlayer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.SimpleMediaPlayer_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackbar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.favoritePlaylistGB.ResumeLayout(false);
            this.recentPlaylistGB.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button closeProgramButton;
        private System.Windows.Forms.Button openFavListButton;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label volPercent;
        private System.Windows.Forms.PictureBox volumePicture;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox playList;
        private System.Windows.Forms.PictureBox appPicture;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar volumeTrackbar;
        private System.Windows.Forms.ListBox favouritesList;
        private System.Windows.Forms.Button addToFavButton;
        private System.Windows.Forms.Button deleteFavButton;
        private System.Windows.Forms.Button saveFavListButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.GroupBox favoritePlaylistGB;
        private System.Windows.Forms.GroupBox recentPlaylistGB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

