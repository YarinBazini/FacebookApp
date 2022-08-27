
namespace FacebookAppGUI
{
    partial class PostsGameController
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_ButtonAnswer1 = new System.Windows.Forms.Button();
            this.m_ButtonAnswer2 = new System.Windows.Forms.Button();
            this.m_ButtonAnswer3 = new System.Windows.Forms.Button();
            this.m_ButtonAnswer4 = new System.Windows.Forms.Button();
            this.m_LabelQuestion = new System.Windows.Forms.Label();
            this.m_LabelPost = new System.Windows.Forms.Label();
            this.m_LabelScore = new System.Windows.Forms.Label();
            this.m_LabelBestScore = new System.Windows.Forms.Label();
            this.m_ButtonNewGame = new System.Windows.Forms.Button();
            this.m_LabelLastResult = new System.Windows.Forms.Label();
            this.m_LabelNumberOfQuestion = new System.Windows.Forms.Label();
            this.m_ButtonNextQuestion = new System.Windows.Forms.Button();
            this.m_PanelPostsGame = new System.Windows.Forms.Panel();
            this.m_LabelErrorMessage = new System.Windows.Forms.Label();
            this.m_LabelError = new System.Windows.Forms.Label();
            this.m_PanelPostsGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_ButtonAnswer1
            // 
            this.m_ButtonAnswer1.Location = new System.Drawing.Point(13, 53);
            this.m_ButtonAnswer1.Name = "m_ButtonAnswer1";
            this.m_ButtonAnswer1.Size = new System.Drawing.Size(136, 44);
            this.m_ButtonAnswer1.TabIndex = 0;
            this.m_ButtonAnswer1.UseVisualStyleBackColor = true;
            this.m_ButtonAnswer1.Click += new System.EventHandler(this.m_ButtonAnswer_Click);
            // 
            // m_ButtonAnswer2
            // 
            this.m_ButtonAnswer2.Location = new System.Drawing.Point(13, 103);
            this.m_ButtonAnswer2.Name = "m_ButtonAnswer2";
            this.m_ButtonAnswer2.Size = new System.Drawing.Size(136, 44);
            this.m_ButtonAnswer2.TabIndex = 1;
            this.m_ButtonAnswer2.UseVisualStyleBackColor = true;
            this.m_ButtonAnswer2.Click += new System.EventHandler(this.m_ButtonAnswer_Click);
            // 
            // m_ButtonAnswer3
            // 
            this.m_ButtonAnswer3.Location = new System.Drawing.Point(13, 153);
            this.m_ButtonAnswer3.Name = "m_ButtonAnswer3";
            this.m_ButtonAnswer3.Size = new System.Drawing.Size(136, 44);
            this.m_ButtonAnswer3.TabIndex = 2;
            this.m_ButtonAnswer3.UseVisualStyleBackColor = true;
            this.m_ButtonAnswer3.Click += new System.EventHandler(this.m_ButtonAnswer_Click);
            // 
            // m_ButtonAnswer4
            // 
            this.m_ButtonAnswer4.Location = new System.Drawing.Point(13, 203);
            this.m_ButtonAnswer4.Name = "m_ButtonAnswer4";
            this.m_ButtonAnswer4.Size = new System.Drawing.Size(136, 44);
            this.m_ButtonAnswer4.TabIndex = 3;
            this.m_ButtonAnswer4.UseVisualStyleBackColor = true;
            this.m_ButtonAnswer4.Click += new System.EventHandler(this.m_ButtonAnswer_Click);
            // 
            // m_LabelQuestion
            // 
            this.m_LabelQuestion.AutoSize = true;
            this.m_LabelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelQuestion.Location = new System.Drawing.Point(10, 13);
            this.m_LabelQuestion.Name = "m_LabelQuestion";
            this.m_LabelQuestion.Size = new System.Drawing.Size(296, 24);
            this.m_LabelQuestion.TabIndex = 4;
            this.m_LabelQuestion.Text = "When was the post published?";
            // 
            // m_LabelPost
            // 
            this.m_LabelPost.AutoSize = true;
            this.m_LabelPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelPost.Location = new System.Drawing.Point(8, 11);
            this.m_LabelPost.Name = "m_LabelPost";
            this.m_LabelPost.Size = new System.Drawing.Size(40, 20);
            this.m_LabelPost.TabIndex = 5;
            this.m_LabelPost.Text = "post";
            // 
            // m_LabelScore
            // 
            this.m_LabelScore.AutoSize = true;
            this.m_LabelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelScore.Location = new System.Drawing.Point(393, 260);
            this.m_LabelScore.Name = "m_LabelScore";
            this.m_LabelScore.Size = new System.Drawing.Size(66, 20);
            this.m_LabelScore.TabIndex = 6;
            this.m_LabelScore.Text = "Score: ";
            // 
            // m_LabelBestScore
            // 
            this.m_LabelBestScore.AutoSize = true;
            this.m_LabelBestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.m_LabelBestScore.Location = new System.Drawing.Point(584, 300);
            this.m_LabelBestScore.Name = "m_LabelBestScore";
            this.m_LabelBestScore.Size = new System.Drawing.Size(103, 20);
            this.m_LabelBestScore.TabIndex = 7;
            this.m_LabelBestScore.Text = "Best Score:";
            // 
            // m_ButtonNewGame
            // 
            this.m_ButtonNewGame.BackColor = System.Drawing.Color.RoyalBlue;
            this.m_ButtonNewGame.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_ButtonNewGame.ForeColor = System.Drawing.Color.White;
            this.m_ButtonNewGame.Location = new System.Drawing.Point(588, 57);
            this.m_ButtonNewGame.Name = "m_ButtonNewGame";
            this.m_ButtonNewGame.Size = new System.Drawing.Size(112, 77);
            this.m_ButtonNewGame.TabIndex = 8;
            this.m_ButtonNewGame.Text = "Start New Game";
            this.m_ButtonNewGame.UseVisualStyleBackColor = false;
            this.m_ButtonNewGame.Click += new System.EventHandler(this.m_ButtonNewGame_Click);
            // 
            // m_LabelLastResult
            // 
            this.m_LabelLastResult.AutoSize = true;
            this.m_LabelLastResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelLastResult.Location = new System.Drawing.Point(193, 74);
            this.m_LabelLastResult.Name = "m_LabelLastResult";
            this.m_LabelLastResult.Size = new System.Drawing.Size(51, 20);
            this.m_LabelLastResult.TabIndex = 9;
            this.m_LabelLastResult.Text = "label1";
            this.m_LabelLastResult.Visible = false;
            // 
            // m_LabelNumberOfQuestion
            // 
            this.m_LabelNumberOfQuestion.AutoSize = true;
            this.m_LabelNumberOfQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelNumberOfQuestion.Location = new System.Drawing.Point(9, 260);
            this.m_LabelNumberOfQuestion.Name = "m_LabelNumberOfQuestion";
            this.m_LabelNumberOfQuestion.Size = new System.Drawing.Size(51, 20);
            this.m_LabelNumberOfQuestion.TabIndex = 10;
            this.m_LabelNumberOfQuestion.Text = "label2";
            // 
            // m_ButtonNextQuestion
            // 
            this.m_ButtonNextQuestion.BackColor = System.Drawing.Color.RoyalBlue;
            this.m_ButtonNextQuestion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_ButtonNextQuestion.ForeColor = System.Drawing.Color.White;
            this.m_ButtonNextQuestion.Location = new System.Drawing.Point(197, 130);
            this.m_ButtonNextQuestion.Name = "m_ButtonNextQuestion";
            this.m_ButtonNextQuestion.Size = new System.Drawing.Size(136, 39);
            this.m_ButtonNextQuestion.TabIndex = 11;
            this.m_ButtonNextQuestion.Text = "Next Question";
            this.m_ButtonNextQuestion.UseVisualStyleBackColor = false;
            this.m_ButtonNextQuestion.Visible = false;
            this.m_ButtonNextQuestion.Click += new System.EventHandler(this.m_ButtonNextQuestion_Click);
            // 
            // m_PanelPostsGame
            // 
            this.m_PanelPostsGame.Controls.Add(this.m_LabelPost);
            this.m_PanelPostsGame.Controls.Add(this.m_ButtonNextQuestion);
            this.m_PanelPostsGame.Controls.Add(this.m_ButtonAnswer4);
            this.m_PanelPostsGame.Controls.Add(this.m_LabelScore);
            this.m_PanelPostsGame.Controls.Add(this.m_LabelLastResult);
            this.m_PanelPostsGame.Controls.Add(this.m_LabelNumberOfQuestion);
            this.m_PanelPostsGame.Controls.Add(this.m_ButtonAnswer1);
            this.m_PanelPostsGame.Controls.Add(this.m_ButtonAnswer2);
            this.m_PanelPostsGame.Controls.Add(this.m_ButtonAnswer3);
            this.m_PanelPostsGame.Location = new System.Drawing.Point(13, 40);
            this.m_PanelPostsGame.Name = "m_PanelPostsGame";
            this.m_PanelPostsGame.Size = new System.Drawing.Size(545, 295);
            this.m_PanelPostsGame.TabIndex = 12;
            this.m_PanelPostsGame.Visible = false;
            // 
            // m_LabelErrorMessage
            // 
            this.m_LabelErrorMessage.AutoSize = true;
            this.m_LabelErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.m_LabelErrorMessage.Location = new System.Drawing.Point(312, 13);
            this.m_LabelErrorMessage.Name = "m_LabelErrorMessage";
            this.m_LabelErrorMessage.Size = new System.Drawing.Size(397, 24);
            this.m_LabelErrorMessage.TabIndex = 13;
            this.m_LabelErrorMessage.Text = "You must have posts in order to play the game";
            this.m_LabelErrorMessage.Visible = false;
            // 
            // m_LabelError
            // 
            this.m_LabelError.AutoSize = true;
            this.m_LabelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelError.ForeColor = System.Drawing.Color.Red;
            this.m_LabelError.Location = new System.Drawing.Point(564, 193);
            this.m_LabelError.Name = "m_LabelError";
            this.m_LabelError.Size = new System.Drawing.Size(181, 16);
            this.m_LabelError.TabIndex = 14;
            this.m_LabelError.Text = "Error - please try again later...";
            this.m_LabelError.Visible = false;
            // 
            // PostsGameController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.m_LabelError);
            this.Controls.Add(this.m_LabelErrorMessage);
            this.Controls.Add(this.m_PanelPostsGame);
            this.Controls.Add(this.m_ButtonNewGame);
            this.Controls.Add(this.m_LabelBestScore);
            this.Controls.Add(this.m_LabelQuestion);
            this.Name = "PostsGameController";
            this.Size = new System.Drawing.Size(748, 350);
            this.m_PanelPostsGame.ResumeLayout(false);
            this.m_PanelPostsGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_ButtonAnswer1;
        private System.Windows.Forms.Button m_ButtonAnswer2;
        private System.Windows.Forms.Button m_ButtonAnswer3;
        private System.Windows.Forms.Button m_ButtonAnswer4;
        private System.Windows.Forms.Label m_LabelQuestion;
        private System.Windows.Forms.Label m_LabelPost;
        private System.Windows.Forms.Label m_LabelScore;
        private System.Windows.Forms.Label m_LabelBestScore;
        private System.Windows.Forms.Button m_ButtonNewGame;
        private System.Windows.Forms.Label m_LabelLastResult;
        private System.Windows.Forms.Label m_LabelNumberOfQuestion;
        private System.Windows.Forms.Button m_ButtonNextQuestion;
        private System.Windows.Forms.Panel m_PanelPostsGame;
        private System.Windows.Forms.Label m_LabelErrorMessage;
        private System.Windows.Forms.Label m_LabelError;
    }
}
