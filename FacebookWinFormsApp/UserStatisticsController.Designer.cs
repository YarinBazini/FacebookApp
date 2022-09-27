
namespace FacebookAppGUI
{
    partial class UserStatisticsController
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.m_PanelStatistics = new System.Windows.Forms.Panel();
            this.m_RadioButtonLikes = new System.Windows.Forms.RadioButton();
            this.m_RadioButtonPosts = new System.Windows.Forms.RadioButton();
            this.m_LabelError = new System.Windows.Forms.Label();
            this.m_LabelSelectesUserPost = new System.Windows.Forms.Label();
            this.m_LabelWait = new System.Windows.Forms.Label();
            this.m_PanelYearSummery = new System.Windows.Forms.Panel();
            this.m_RadioButtonTopCommentPost = new System.Windows.Forms.RadioButton();
            this.m_RadioButtonWorstCommentsPost = new System.Windows.Forms.RadioButton();
            this.m_LabelYear = new System.Windows.Forms.Label();
            this.m_RadioButtonWorstLikesPost = new System.Windows.Forms.RadioButton();
            this.m_LabelNumOfLikes = new System.Windows.Forms.Label();
            this.m_RadioButtonTopLikedPost = new System.Windows.Forms.RadioButton();
            this.m_LabelNumOfComments = new System.Windows.Forms.Label();
            this.m_ChartYearsToPost = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.m_LabelStatisticsGraph = new System.Windows.Forms.Label();
            this.m_LabelExplanationStatistics = new System.Windows.Forms.Label();
            this.m_ComboBoxYears = new System.Windows.Forms.ComboBox();
            this.m_ButtonShow = new System.Windows.Forms.Button();
            this.m_LabelGraphCalculate = new System.Windows.Forms.Label();
            this.m_RadioButtonComments = new System.Windows.Forms.RadioButton();
            this.m_PanelStatistics.SuspendLayout();
            this.m_PanelYearSummery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_ChartYearsToPost)).BeginInit();
            this.SuspendLayout();
            // 
            // m_PanelStatistics
            // 
            this.m_PanelStatistics.Controls.Add(this.m_RadioButtonComments);
            this.m_PanelStatistics.Controls.Add(this.m_LabelGraphCalculate);
            this.m_PanelStatistics.Controls.Add(this.m_RadioButtonLikes);
            this.m_PanelStatistics.Controls.Add(this.m_RadioButtonPosts);
            this.m_PanelStatistics.Controls.Add(this.m_LabelError);
            this.m_PanelStatistics.Controls.Add(this.m_LabelSelectesUserPost);
            this.m_PanelStatistics.Controls.Add(this.m_LabelWait);
            this.m_PanelStatistics.Controls.Add(this.m_PanelYearSummery);
            this.m_PanelStatistics.Controls.Add(this.m_ChartYearsToPost);
            this.m_PanelStatistics.Controls.Add(this.m_LabelStatisticsGraph);
            this.m_PanelStatistics.Controls.Add(this.m_LabelExplanationStatistics);
            this.m_PanelStatistics.Controls.Add(this.m_ComboBoxYears);
            this.m_PanelStatistics.Location = new System.Drawing.Point(6, 20);
            this.m_PanelStatistics.Name = "m_PanelStatistics";
            this.m_PanelStatistics.Size = new System.Drawing.Size(703, 295);
            this.m_PanelStatistics.TabIndex = 13;
            this.m_PanelStatistics.Visible = false;
            // 
            // m_RadioButtonLikes
            // 
            this.m_RadioButtonLikes.AutoSize = true;
            this.m_RadioButtonLikes.Location = new System.Drawing.Point(79, 73);
            this.m_RadioButtonLikes.Name = "m_RadioButtonLikes";
            this.m_RadioButtonLikes.Size = new System.Drawing.Size(65, 17);
            this.m_RadioButtonLikes.TabIndex = 22;
            this.m_RadioButtonLikes.TabStop = true;
            this.m_RadioButtonLikes.Text = "By Likes";
            this.m_RadioButtonLikes.UseVisualStyleBackColor = true;
            this.m_RadioButtonLikes.CheckedChanged += new System.EventHandler(this.m_RadioButtonGraph_CheckedChanged);
            // 
            // m_RadioButtonPosts
            // 
            this.m_RadioButtonPosts.AutoSize = true;
            this.m_RadioButtonPosts.Location = new System.Drawing.Point(7, 73);
            this.m_RadioButtonPosts.Name = "m_RadioButtonPosts";
            this.m_RadioButtonPosts.Size = new System.Drawing.Size(66, 17);
            this.m_RadioButtonPosts.TabIndex = 21;
            this.m_RadioButtonPosts.TabStop = true;
            this.m_RadioButtonPosts.Text = "By Posts";
            this.m_RadioButtonPosts.UseVisualStyleBackColor = true;
            this.m_RadioButtonPosts.CheckedChanged += new System.EventHandler(this.m_RadioButtonGraph_CheckedChanged);
            // 
            // m_LabelError
            // 
            this.m_LabelError.AutoSize = true;
            this.m_LabelError.ForeColor = System.Drawing.Color.Red;
            this.m_LabelError.Location = new System.Drawing.Point(325, 14);
            this.m_LabelError.Name = "m_LabelError";
            this.m_LabelError.Size = new System.Drawing.Size(132, 13);
            this.m_LabelError.TabIndex = 20;
            this.m_LabelError.Text = "Error - pleas try again later.";
            this.m_LabelError.Visible = false;
            // 
            // m_LabelSelectesUserPost
            // 
            this.m_LabelSelectesUserPost.Location = new System.Drawing.Point(530, 137);
            this.m_LabelSelectesUserPost.Name = "m_LabelSelectesUserPost";
            this.m_LabelSelectesUserPost.Size = new System.Drawing.Size(159, 125);
            this.m_LabelSelectesUserPost.TabIndex = 19;
            // 
            // m_LabelWait
            // 
            this.m_LabelWait.AutoSize = true;
            this.m_LabelWait.BackColor = System.Drawing.Color.Red;
            this.m_LabelWait.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelWait.ForeColor = System.Drawing.Color.White;
            this.m_LabelWait.Location = new System.Drawing.Point(533, 96);
            this.m_LabelWait.Name = "m_LabelWait";
            this.m_LabelWait.Size = new System.Drawing.Size(107, 19);
            this.m_LabelWait.TabIndex = 18;
            this.m_LabelWait.Text = "Calculating...";
            this.m_LabelWait.Visible = false;
            // 
            // m_PanelYearSummery
            // 
            this.m_PanelYearSummery.Controls.Add(this.m_RadioButtonTopCommentPost);
            this.m_PanelYearSummery.Controls.Add(this.m_RadioButtonWorstCommentsPost);
            this.m_PanelYearSummery.Controls.Add(this.m_LabelYear);
            this.m_PanelYearSummery.Controls.Add(this.m_RadioButtonWorstLikesPost);
            this.m_PanelYearSummery.Controls.Add(this.m_LabelNumOfLikes);
            this.m_PanelYearSummery.Controls.Add(this.m_RadioButtonTopLikedPost);
            this.m_PanelYearSummery.Controls.Add(this.m_LabelNumOfComments);
            this.m_PanelYearSummery.Location = new System.Drawing.Point(316, 56);
            this.m_PanelYearSummery.Name = "m_PanelYearSummery";
            this.m_PanelYearSummery.Size = new System.Drawing.Size(200, 206);
            this.m_PanelYearSummery.TabIndex = 17;
            this.m_PanelYearSummery.Visible = false;
            // 
            // m_RadioButtonTopCommentPost
            // 
            this.m_RadioButtonTopCommentPost.AutoSize = true;
            this.m_RadioButtonTopCommentPost.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_RadioButtonTopCommentPost.Location = new System.Drawing.Point(21, 94);
            this.m_RadioButtonTopCommentPost.Name = "m_RadioButtonTopCommentPost";
            this.m_RadioButtonTopCommentPost.Size = new System.Drawing.Size(144, 20);
            this.m_RadioButtonTopCommentPost.TabIndex = 8;
            this.m_RadioButtonTopCommentPost.TabStop = true;
            this.m_RadioButtonTopCommentPost.Text = "Top Comments Post";
            this.m_RadioButtonTopCommentPost.UseVisualStyleBackColor = true;
            this.m_RadioButtonTopCommentPost.CheckedChanged += new System.EventHandler(this.m_RadioButton_CheckedChanged);
            // 
            // m_RadioButtonWorstCommentsPost
            // 
            this.m_RadioButtonWorstCommentsPost.AutoSize = true;
            this.m_RadioButtonWorstCommentsPost.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_RadioButtonWorstCommentsPost.Location = new System.Drawing.Point(21, 163);
            this.m_RadioButtonWorstCommentsPost.Name = "m_RadioButtonWorstCommentsPost";
            this.m_RadioButtonWorstCommentsPost.Size = new System.Drawing.Size(159, 20);
            this.m_RadioButtonWorstCommentsPost.TabIndex = 11;
            this.m_RadioButtonWorstCommentsPost.TabStop = true;
            this.m_RadioButtonWorstCommentsPost.Text = "Worst Comments Post";
            this.m_RadioButtonWorstCommentsPost.UseVisualStyleBackColor = true;
            this.m_RadioButtonWorstCommentsPost.CheckedChanged += new System.EventHandler(this.m_RadioButton_CheckedChanged);
            // 
            // m_LabelYear
            // 
            this.m_LabelYear.AutoSize = true;
            this.m_LabelYear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelYear.Location = new System.Drawing.Point(18, 14);
            this.m_LabelYear.Name = "m_LabelYear";
            this.m_LabelYear.Size = new System.Drawing.Size(38, 16);
            this.m_LabelYear.TabIndex = 5;
            this.m_LabelYear.Text = "Year:";
            // 
            // m_RadioButtonWorstLikesPost
            // 
            this.m_RadioButtonWorstLikesPost.AutoSize = true;
            this.m_RadioButtonWorstLikesPost.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_RadioButtonWorstLikesPost.Location = new System.Drawing.Point(21, 140);
            this.m_RadioButtonWorstLikesPost.Name = "m_RadioButtonWorstLikesPost";
            this.m_RadioButtonWorstLikesPost.Size = new System.Drawing.Size(127, 20);
            this.m_RadioButtonWorstLikesPost.TabIndex = 10;
            this.m_RadioButtonWorstLikesPost.TabStop = true;
            this.m_RadioButtonWorstLikesPost.Text = "Worst Likes Post";
            this.m_RadioButtonWorstLikesPost.UseVisualStyleBackColor = true;
            this.m_RadioButtonWorstLikesPost.CheckedChanged += new System.EventHandler(this.m_RadioButton_CheckedChanged);
            // 
            // m_LabelNumOfLikes
            // 
            this.m_LabelNumOfLikes.AutoSize = true;
            this.m_LabelNumOfLikes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelNumOfLikes.Location = new System.Drawing.Point(18, 40);
            this.m_LabelNumOfLikes.Name = "m_LabelNumOfLikes";
            this.m_LabelNumOfLikes.Size = new System.Drawing.Size(70, 16);
            this.m_LabelNumOfLikes.TabIndex = 6;
            this.m_LabelNumOfLikes.Text = "Total likes:";
            // 
            // m_RadioButtonTopLikedPost
            // 
            this.m_RadioButtonTopLikedPost.AutoSize = true;
            this.m_RadioButtonTopLikedPost.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_RadioButtonTopLikedPost.Location = new System.Drawing.Point(21, 117);
            this.m_RadioButtonTopLikedPost.Name = "m_RadioButtonTopLikedPost";
            this.m_RadioButtonTopLikedPost.Size = new System.Drawing.Size(112, 20);
            this.m_RadioButtonTopLikedPost.TabIndex = 9;
            this.m_RadioButtonTopLikedPost.TabStop = true;
            this.m_RadioButtonTopLikedPost.Text = "Top Likes Post";
            this.m_RadioButtonTopLikedPost.UseVisualStyleBackColor = true;
            this.m_RadioButtonTopLikedPost.CheckedChanged += new System.EventHandler(this.m_RadioButton_CheckedChanged);
            // 
            // m_LabelNumOfComments
            // 
            this.m_LabelNumOfComments.AutoSize = true;
            this.m_LabelNumOfComments.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelNumOfComments.Location = new System.Drawing.Point(18, 68);
            this.m_LabelNumOfComments.Name = "m_LabelNumOfComments";
            this.m_LabelNumOfComments.Size = new System.Drawing.Size(104, 16);
            this.m_LabelNumOfComments.TabIndex = 7;
            this.m_LabelNumOfComments.Text = "Total comments:";
            // 
            // m_ChartYearsToPost
            // 
            chartArea2.Name = "ChartArea1";
            this.m_ChartYearsToPost.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.m_ChartYearsToPost.Legends.Add(legend2);
            this.m_ChartYearsToPost.Location = new System.Drawing.Point(3, 96);
            this.m_ChartYearsToPost.Name = "m_ChartYearsToPost";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Posts Amaunt";
            this.m_ChartYearsToPost.Series.Add(series2);
            this.m_ChartYearsToPost.Size = new System.Drawing.Size(273, 166);
            this.m_ChartYearsToPost.TabIndex = 13;
            this.m_ChartYearsToPost.Text = "chart1";
            // 
            // m_LabelStatisticsGraph
            // 
            this.m_LabelStatisticsGraph.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelStatisticsGraph.Location = new System.Drawing.Point(4, 32);
            this.m_LabelStatisticsGraph.Name = "m_LabelStatisticsGraph";
            this.m_LabelStatisticsGraph.Size = new System.Drawing.Size(280, 46);
            this.m_LabelStatisticsGraph.TabIndex = 14;
            this.m_LabelStatisticsGraph.Text = "The amount of posts you\'ve created over the years on Facebook";
            // 
            // m_LabelExplanationStatistics
            // 
            this.m_LabelExplanationStatistics.AutoSize = true;
            this.m_LabelExplanationStatistics.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelExplanationStatistics.Location = new System.Drawing.Point(313, 32);
            this.m_LabelExplanationStatistics.Name = "m_LabelExplanationStatistics";
            this.m_LabelExplanationStatistics.Size = new System.Drawing.Size(244, 18);
            this.m_LabelExplanationStatistics.TabIndex = 15;
            this.m_LabelExplanationStatistics.Text = "Select a year to see your statistics";
            // 
            // m_ComboBoxYears
            // 
            this.m_ComboBoxYears.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_ComboBoxYears.FormattingEnabled = true;
            this.m_ComboBoxYears.Location = new System.Drawing.Point(576, 33);
            this.m_ComboBoxYears.Name = "m_ComboBoxYears";
            this.m_ComboBoxYears.Size = new System.Drawing.Size(116, 24);
            this.m_ComboBoxYears.TabIndex = 16;
            this.m_ComboBoxYears.SelectedIndexChanged += new System.EventHandler(this.m_ComboBoxYears_SelectedIndexChanged);
            // 
            // m_ButtonShow
            // 
            this.m_ButtonShow.BackColor = System.Drawing.Color.RoyalBlue;
            this.m_ButtonShow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_ButtonShow.ForeColor = System.Drawing.Color.White;
            this.m_ButtonShow.Location = new System.Drawing.Point(539, 20);
            this.m_ButtonShow.Name = "m_ButtonShow";
            this.m_ButtonShow.Size = new System.Drawing.Size(142, 46);
            this.m_ButtonShow.TabIndex = 14;
            this.m_ButtonShow.Text = "Show Statistics";
            this.m_ButtonShow.UseVisualStyleBackColor = false;
            this.m_ButtonShow.Click += new System.EventHandler(this.m_ButtonShow_Click);
            // 
            // m_LabelGraphCalculate
            // 
            this.m_LabelGraphCalculate.AutoSize = true;
            this.m_LabelGraphCalculate.ForeColor = System.Drawing.Color.Red;
            this.m_LabelGraphCalculate.Location = new System.Drawing.Point(250, 77);
            this.m_LabelGraphCalculate.Name = "m_LabelGraphCalculate";
            this.m_LabelGraphCalculate.Size = new System.Drawing.Size(60, 13);
            this.m_LabelGraphCalculate.TabIndex = 23;
            this.m_LabelGraphCalculate.Text = "Calculate...";
            this.m_LabelGraphCalculate.Visible = false;
            // 
            // m_RadioButtonComments
            // 
            this.m_RadioButtonComments.AutoSize = true;
            this.m_RadioButtonComments.Location = new System.Drawing.Point(150, 73);
            this.m_RadioButtonComments.Name = "m_RadioButtonComments";
            this.m_RadioButtonComments.Size = new System.Drawing.Size(89, 17);
            this.m_RadioButtonComments.TabIndex = 24;
            this.m_RadioButtonComments.TabStop = true;
            this.m_RadioButtonComments.Text = "By Comments";
            this.m_RadioButtonComments.UseVisualStyleBackColor = true;
            this.m_RadioButtonComments.CheckedChanged += new System.EventHandler(this.m_RadioButtonGraph_CheckedChanged);
            // 
            // UserStatisticsController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.m_ButtonShow);
            this.Controls.Add(this.m_PanelStatistics);
            this.Name = "UserStatisticsController";
            this.Size = new System.Drawing.Size(709, 420);
            this.m_PanelStatistics.ResumeLayout(false);
            this.m_PanelStatistics.PerformLayout();
            this.m_PanelYearSummery.ResumeLayout(false);
            this.m_PanelYearSummery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_ChartYearsToPost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel m_PanelStatistics;
        private System.Windows.Forms.Panel m_PanelYearSummery;
        private System.Windows.Forms.RadioButton m_RadioButtonTopCommentPost;
        private System.Windows.Forms.RadioButton m_RadioButtonWorstCommentsPost;
        private System.Windows.Forms.Label m_LabelYear;
        private System.Windows.Forms.RadioButton m_RadioButtonWorstLikesPost;
        private System.Windows.Forms.Label m_LabelNumOfLikes;
        private System.Windows.Forms.RadioButton m_RadioButtonTopLikedPost;
        private System.Windows.Forms.Label m_LabelNumOfComments;
        private System.Windows.Forms.DataVisualization.Charting.Chart m_ChartYearsToPost;
        private System.Windows.Forms.Label m_LabelStatisticsGraph;
        private System.Windows.Forms.Label m_LabelExplanationStatistics;
        private System.Windows.Forms.ComboBox m_ComboBoxYears;
        private System.Windows.Forms.Button m_ButtonShow;
        private System.Windows.Forms.Label m_LabelWait;
        private System.Windows.Forms.Label m_LabelSelectesUserPost;
        private System.Windows.Forms.Label m_LabelError;
        private System.Windows.Forms.RadioButton m_RadioButtonPosts;
        private System.Windows.Forms.RadioButton m_RadioButtonLikes;
        private System.Windows.Forms.Label m_LabelGraphCalculate;
        private System.Windows.Forms.RadioButton m_RadioButtonComments;
    }
}
