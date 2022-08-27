namespace FacebookAppGUI
{
    partial class FormMain
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
            this.m_ButtonLogout = new System.Windows.Forms.Button();
            this.m_ButtonLogin = new System.Windows.Forms.Button();
            this.m_LabelUserName = new System.Windows.Forms.Label();
            this.m_PictureBoxUserProfie = new System.Windows.Forms.PictureBox();
            this.m_PictureBoxUserCover = new System.Windows.Forms.PictureBox();
            this.m_LabelErrorBeforLogin = new System.Windows.Forms.Label();
            this.m_TabLikedPages = new System.Windows.Forms.TabPage();
            this.m_TabGroups = new System.Windows.Forms.TabPage();
            this.m_TabPhotos = new System.Windows.Forms.TabPage();
            this.m_TabAbout = new System.Windows.Forms.TabPage();
            this.m_TabPosts = new System.Windows.Forms.TabPage();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.m_TabsFacebookApp = new System.Windows.Forms.TabControl();
            this.m_TabPagePostsGame = new System.Windows.Forms.TabPage();
            this.m_TabPageStatistics = new System.Windows.Forms.TabPage();
            this.m_LabelLoading = new System.Windows.Forms.Label();
            this.m_LabelCoverPhotoError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxUserProfie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxUserCover)).BeginInit();
            this.m_TabPosts.SuspendLayout();
            this.m_TabsFacebookApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_ButtonLogout
            // 
            this.m_ButtonLogout.BackColor = System.Drawing.Color.RoyalBlue;
            this.m_ButtonLogout.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ButtonLogout.ForeColor = System.Drawing.Color.White;
            this.m_ButtonLogout.Location = new System.Drawing.Point(952, 69);
            this.m_ButtonLogout.Name = "m_ButtonLogout";
            this.m_ButtonLogout.Size = new System.Drawing.Size(137, 48);
            this.m_ButtonLogout.TabIndex = 52;
            this.m_ButtonLogout.Text = "Logout";
            this.m_ButtonLogout.UseVisualStyleBackColor = false;
            this.m_ButtonLogout.Visible = false;
            this.m_ButtonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // m_ButtonLogin
            // 
            this.m_ButtonLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.m_ButtonLogin.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_ButtonLogin.ForeColor = System.Drawing.Color.White;
            this.m_ButtonLogin.Location = new System.Drawing.Point(952, 10);
            this.m_ButtonLogin.Name = "m_ButtonLogin";
            this.m_ButtonLogin.Size = new System.Drawing.Size(137, 53);
            this.m_ButtonLogin.TabIndex = 36;
            this.m_ButtonLogin.Text = "Login";
            this.m_ButtonLogin.UseVisualStyleBackColor = false;
            this.m_ButtonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // m_LabelUserName
            // 
            this.m_LabelUserName.AutoSize = true;
            this.m_LabelUserName.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelUserName.Location = new System.Drawing.Point(164, 172);
            this.m_LabelUserName.Name = "m_LabelUserName";
            this.m_LabelUserName.Size = new System.Drawing.Size(0, 42);
            this.m_LabelUserName.TabIndex = 2;
            // 
            // m_PictureBoxUserProfie
            // 
            this.m_PictureBoxUserProfie.Location = new System.Drawing.Point(4, 137);
            this.m_PictureBoxUserProfie.Name = "m_PictureBoxUserProfie";
            this.m_PictureBoxUserProfie.Size = new System.Drawing.Size(154, 136);
            this.m_PictureBoxUserProfie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxUserProfie.TabIndex = 1;
            this.m_PictureBoxUserProfie.TabStop = false;
            // 
            // m_PictureBoxUserCover
            // 
            this.m_PictureBoxUserCover.Location = new System.Drawing.Point(104, 2);
            this.m_PictureBoxUserCover.Name = "m_PictureBoxUserCover";
            this.m_PictureBoxUserCover.Size = new System.Drawing.Size(753, 167);
            this.m_PictureBoxUserCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxUserCover.TabIndex = 0;
            this.m_PictureBoxUserCover.TabStop = false;
            // 
            // m_LabelErrorBeforLogin
            // 
            this.m_LabelErrorBeforLogin.AutoSize = true;
            this.m_LabelErrorBeforLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelErrorBeforLogin.ForeColor = System.Drawing.Color.Red;
            this.m_LabelErrorBeforLogin.Location = new System.Drawing.Point(13, 12);
            this.m_LabelErrorBeforLogin.Name = "m_LabelErrorBeforLogin";
            this.m_LabelErrorBeforLogin.Size = new System.Drawing.Size(505, 39);
            this.m_LabelErrorBeforLogin.TabIndex = 54;
            this.m_LabelErrorBeforLogin.Text = "Please login first to use this app";
            // 
            // m_TabLikedPages
            // 
            this.m_TabLikedPages.Location = new System.Drawing.Point(4, 27);
            this.m_TabLikedPages.Name = "m_TabLikedPages";
            this.m_TabLikedPages.Padding = new System.Windows.Forms.Padding(3);
            this.m_TabLikedPages.Size = new System.Drawing.Size(1083, 510);
            this.m_TabLikedPages.TabIndex = 4;
            this.m_TabLikedPages.Text = "Liked Pages";
            this.m_TabLikedPages.UseVisualStyleBackColor = true;
            // 
            // m_TabGroups
            // 
            this.m_TabGroups.Location = new System.Drawing.Point(4, 27);
            this.m_TabGroups.Name = "m_TabGroups";
            this.m_TabGroups.Padding = new System.Windows.Forms.Padding(3);
            this.m_TabGroups.Size = new System.Drawing.Size(1083, 510);
            this.m_TabGroups.TabIndex = 3;
            this.m_TabGroups.Text = "Groups";
            this.m_TabGroups.UseVisualStyleBackColor = true;
            // 
            // m_TabPhotos
            // 
            this.m_TabPhotos.Location = new System.Drawing.Point(4, 27);
            this.m_TabPhotos.Name = "m_TabPhotos";
            this.m_TabPhotos.Padding = new System.Windows.Forms.Padding(3);
            this.m_TabPhotos.Size = new System.Drawing.Size(1083, 510);
            this.m_TabPhotos.TabIndex = 2;
            this.m_TabPhotos.Text = "Photos";
            this.m_TabPhotos.UseVisualStyleBackColor = true;
            // 
            // m_TabAbout
            // 
            this.m_TabAbout.Location = new System.Drawing.Point(4, 27);
            this.m_TabAbout.Name = "m_TabAbout";
            this.m_TabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.m_TabAbout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_TabAbout.Size = new System.Drawing.Size(1083, 510);
            this.m_TabAbout.TabIndex = 1;
            this.m_TabAbout.Text = "About";
            this.m_TabAbout.UseVisualStyleBackColor = true;
            // 
            // m_TabPosts
            // 
            this.m_TabPosts.Controls.Add(this.splitter1);
            this.m_TabPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_TabPosts.Location = new System.Drawing.Point(4, 27);
            this.m_TabPosts.Name = "m_TabPosts";
            this.m_TabPosts.Padding = new System.Windows.Forms.Padding(3);
            this.m_TabPosts.Size = new System.Drawing.Size(1083, 510);
            this.m_TabPosts.TabIndex = 0;
            this.m_TabPosts.Text = "Posts";
            this.m_TabPosts.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 504);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // m_TabsFacebookApp
            // 
            this.m_TabsFacebookApp.Controls.Add(this.m_TabPosts);
            this.m_TabsFacebookApp.Controls.Add(this.m_TabAbout);
            this.m_TabsFacebookApp.Controls.Add(this.m_TabPhotos);
            this.m_TabsFacebookApp.Controls.Add(this.m_TabGroups);
            this.m_TabsFacebookApp.Controls.Add(this.m_TabLikedPages);
            this.m_TabsFacebookApp.Controls.Add(this.m_TabPagePostsGame);
            this.m_TabsFacebookApp.Controls.Add(this.m_TabPageStatistics);
            this.m_TabsFacebookApp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_TabsFacebookApp.Location = new System.Drawing.Point(4, 279);
            this.m_TabsFacebookApp.Name = "m_TabsFacebookApp";
            this.m_TabsFacebookApp.SelectedIndex = 0;
            this.m_TabsFacebookApp.Size = new System.Drawing.Size(1091, 541);
            this.m_TabsFacebookApp.TabIndex = 53;
            this.m_TabsFacebookApp.Visible = false;
            // 
            // m_TabPagePostsGame
            // 
            this.m_TabPagePostsGame.Location = new System.Drawing.Point(4, 27);
            this.m_TabPagePostsGame.Name = "m_TabPagePostsGame";
            this.m_TabPagePostsGame.Padding = new System.Windows.Forms.Padding(3);
            this.m_TabPagePostsGame.Size = new System.Drawing.Size(1083, 510);
            this.m_TabPagePostsGame.TabIndex = 5;
            this.m_TabPagePostsGame.Text = "Posts Game";
            this.m_TabPagePostsGame.UseVisualStyleBackColor = true;
            // 
            // m_TabPageStatistics
            // 
            this.m_TabPageStatistics.Location = new System.Drawing.Point(4, 27);
            this.m_TabPageStatistics.Name = "m_TabPageStatistics";
            this.m_TabPageStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.m_TabPageStatistics.Size = new System.Drawing.Size(1083, 510);
            this.m_TabPageStatistics.TabIndex = 6;
            this.m_TabPageStatistics.Text = "Statistics";
            this.m_TabPageStatistics.UseVisualStyleBackColor = true;
            // 
            // m_LabelLoading
            // 
            this.m_LabelLoading.AutoSize = true;
            this.m_LabelLoading.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelLoading.ForeColor = System.Drawing.Color.Blue;
            this.m_LabelLoading.Location = new System.Drawing.Point(465, 232);
            this.m_LabelLoading.Name = "m_LabelLoading";
            this.m_LabelLoading.Size = new System.Drawing.Size(180, 41);
            this.m_LabelLoading.TabIndex = 55;
            this.m_LabelLoading.Text = "Loading...";
            this.m_LabelLoading.Visible = false;
            // 
            // m_LabelCoverPhotoError
            // 
            this.m_LabelCoverPhotoError.AutoSize = true;
            this.m_LabelCoverPhotoError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelCoverPhotoError.Location = new System.Drawing.Point(111, 69);
            this.m_LabelCoverPhotoError.Name = "m_LabelCoverPhotoError";
            this.m_LabelCoverPhotoError.Size = new System.Drawing.Size(345, 19);
            this.m_LabelCoverPhotoError.TabIndex = 56;
            this.m_LabelCoverPhotoError.Text = "We could not find your cover photo. sorry :-(";
            this.m_LabelCoverPhotoError.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 826);
            this.Controls.Add(this.m_LabelCoverPhotoError);
            this.Controls.Add(this.m_LabelLoading);
            this.Controls.Add(this.m_LabelErrorBeforLogin);
            this.Controls.Add(this.m_TabsFacebookApp);
            this.Controls.Add(this.m_PictureBoxUserProfie);
            this.Controls.Add(this.m_PictureBoxUserCover);
            this.Controls.Add(this.m_LabelUserName);
            this.Controls.Add(this.m_ButtonLogout);
            this.Controls.Add(this.m_ButtonLogin);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxUserProfie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxUserCover)).EndInit();
            this.m_TabPosts.ResumeLayout(false);
            this.m_TabsFacebookApp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_ButtonLogout;
        private System.Windows.Forms.Button m_ButtonLogin;
        private System.Windows.Forms.Label m_LabelUserName;
        private System.Windows.Forms.PictureBox m_PictureBoxUserProfie;
        private System.Windows.Forms.PictureBox m_PictureBoxUserCover;
        private System.Windows.Forms.Label m_LabelErrorBeforLogin;
        private System.Windows.Forms.TabPage m_TabLikedPages;
        private System.Windows.Forms.TabPage m_TabGroups;
        private System.Windows.Forms.TabPage m_TabPhotos;
        private System.Windows.Forms.TabPage m_TabAbout;
        private System.Windows.Forms.TabPage m_TabPosts;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabControl m_TabsFacebookApp;
        private System.Windows.Forms.TabPage m_TabPagePostsGame;
        private System.Windows.Forms.TabPage m_TabPageStatistics;
        private System.Windows.Forms.Label m_LabelLoading;
        private System.Windows.Forms.Label m_LabelCoverPhotoError;
    }
}

