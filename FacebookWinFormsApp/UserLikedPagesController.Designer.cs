
namespace FacebookAppGUI
{
    partial class UserLikedPagesController
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
            this.m_LabelLikePagesExplanation = new System.Windows.Forms.Label();
            this.m_ListBoxLikePages = new System.Windows.Forms.ListBox();
            this.m_PanelLikePages = new System.Windows.Forms.Panel();
            this.m_PictureBoxLikePagesPicture = new System.Windows.Forms.PictureBox();
            this.m_LabelLikePageName = new System.Windows.Forms.Label();
            this.m_LabelLikePageNameTitle = new System.Windows.Forms.Label();
            this.m_LabelLikePagesPictureTitle = new System.Windows.Forms.Label();
            this.m_LabelError = new System.Windows.Forms.Label();
            this.m_PanelLikePages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxLikePagesPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // m_LabelLikePagesExplanation
            // 
            this.m_LabelLikePagesExplanation.AutoSize = true;
            this.m_LabelLikePagesExplanation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelLikePagesExplanation.Location = new System.Drawing.Point(3, 11);
            this.m_LabelLikePagesExplanation.Name = "m_LabelLikePagesExplanation";
            this.m_LabelLikePagesExplanation.Size = new System.Drawing.Size(225, 16);
            this.m_LabelLikePagesExplanation.TabIndex = 10;
            this.m_LabelLikePagesExplanation.Text = "Click on a page to view his details";
            // 
            // m_ListBoxLikePages
            // 
            this.m_ListBoxLikePages.FormattingEnabled = true;
            this.m_ListBoxLikePages.Location = new System.Drawing.Point(6, 30);
            this.m_ListBoxLikePages.Name = "m_ListBoxLikePages";
            this.m_ListBoxLikePages.Size = new System.Drawing.Size(487, 277);
            this.m_ListBoxLikePages.TabIndex = 9;
            this.m_ListBoxLikePages.SelectedIndexChanged += new System.EventHandler(this.m_ListBoxLikePages_SelectedIndexChanged);
            // 
            // m_PanelLikePages
            // 
            this.m_PanelLikePages.Controls.Add(this.m_PictureBoxLikePagesPicture);
            this.m_PanelLikePages.Controls.Add(this.m_LabelLikePageName);
            this.m_PanelLikePages.Controls.Add(this.m_LabelLikePageNameTitle);
            this.m_PanelLikePages.Controls.Add(this.m_LabelLikePagesPictureTitle);
            this.m_PanelLikePages.Location = new System.Drawing.Point(499, 30);
            this.m_PanelLikePages.Name = "m_PanelLikePages";
            this.m_PanelLikePages.Size = new System.Drawing.Size(278, 277);
            this.m_PanelLikePages.TabIndex = 11;
            this.m_PanelLikePages.Visible = false;
            // 
            // m_PictureBoxLikePagesPicture
            // 
            this.m_PictureBoxLikePagesPicture.Location = new System.Drawing.Point(72, 73);
            this.m_PictureBoxLikePagesPicture.Name = "m_PictureBoxLikePagesPicture";
            this.m_PictureBoxLikePagesPicture.Size = new System.Drawing.Size(189, 148);
            this.m_PictureBoxLikePagesPicture.TabIndex = 11;
            this.m_PictureBoxLikePagesPicture.TabStop = false;
            // 
            // m_LabelLikePageName
            // 
            this.m_LabelLikePageName.AutoSize = true;
            this.m_LabelLikePageName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelLikePageName.Location = new System.Drawing.Point(69, 20);
            this.m_LabelLikePageName.Name = "m_LabelLikePageName";
            this.m_LabelLikePageName.Size = new System.Drawing.Size(0, 16);
            this.m_LabelLikePageName.TabIndex = 10;
            // 
            // m_LabelLikePageNameTitle
            // 
            this.m_LabelLikePageNameTitle.AutoSize = true;
            this.m_LabelLikePageNameTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelLikePageNameTitle.Location = new System.Drawing.Point(14, 20);
            this.m_LabelLikePageNameTitle.Name = "m_LabelLikePageNameTitle";
            this.m_LabelLikePageNameTitle.Size = new System.Drawing.Size(49, 16);
            this.m_LabelLikePageNameTitle.TabIndex = 9;
            this.m_LabelLikePageNameTitle.Text = "Name:";
            // 
            // m_LabelLikePagesPictureTitle
            // 
            this.m_LabelLikePagesPictureTitle.AutoSize = true;
            this.m_LabelLikePagesPictureTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelLikePagesPictureTitle.Location = new System.Drawing.Point(14, 64);
            this.m_LabelLikePagesPictureTitle.Name = "m_LabelLikePagesPictureTitle";
            this.m_LabelLikePagesPictureTitle.Size = new System.Drawing.Size(57, 16);
            this.m_LabelLikePagesPictureTitle.TabIndex = 8;
            this.m_LabelLikePagesPictureTitle.Text = "Picture:";
            // 
            // m_LabelError
            // 
            this.m_LabelError.AutoSize = true;
            this.m_LabelError.ForeColor = System.Drawing.Color.Red;
            this.m_LabelError.Location = new System.Drawing.Point(559, 11);
            this.m_LabelError.Name = "m_LabelError";
            this.m_LabelError.Size = new System.Drawing.Size(201, 13);
            this.m_LabelError.TabIndex = 12;
            this.m_LabelError.Text = "Fetch data failed - please try again later...";
            this.m_LabelError.Visible = false;
            // 
            // UserLikedPagesController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.m_LabelError);
            this.Controls.Add(this.m_PanelLikePages);
            this.Controls.Add(this.m_LabelLikePagesExplanation);
            this.Controls.Add(this.m_ListBoxLikePages);
            this.Name = "UserLikedPagesController";
            this.Size = new System.Drawing.Size(789, 361);
            this.m_PanelLikePages.ResumeLayout(false);
            this.m_PanelLikePages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxLikePagesPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_LabelLikePagesExplanation;
        private System.Windows.Forms.ListBox m_ListBoxLikePages;
        private System.Windows.Forms.Panel m_PanelLikePages;
        private System.Windows.Forms.PictureBox m_PictureBoxLikePagesPicture;
        private System.Windows.Forms.Label m_LabelLikePageName;
        private System.Windows.Forms.Label m_LabelLikePageNameTitle;
        private System.Windows.Forms.Label m_LabelLikePagesPictureTitle;
        private System.Windows.Forms.Label m_LabelError;
    }
}
