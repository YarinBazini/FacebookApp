
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label m_PictureBoxLikePagesPictureHeader;
            System.Windows.Forms.Label m_LabelLikePageNameHeader;
            this.m_LabelLikePagesExplanation = new System.Windows.Forms.Label();
            this.m_ListBoxLikePages = new System.Windows.Forms.ListBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_PanelLikePages = new System.Windows.Forms.Panel();
            this.m_PictureBoxLikePagesPicture = new System.Windows.Forms.PictureBox();
            this.m_LabelLikePageName = new System.Windows.Forms.Label();
            this.m_LabelError = new System.Windows.Forms.Label();
            m_PictureBoxLikePagesPictureHeader = new System.Windows.Forms.Label();
            m_LabelLikePageNameHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            this.m_PanelLikePages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxLikePagesPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // m_PictureBoxLikePagesPictureHeader
            // 
            m_PictureBoxLikePagesPictureHeader.AutoSize = true;
            m_PictureBoxLikePagesPictureHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            m_PictureBoxLikePagesPictureHeader.Location = new System.Drawing.Point(14, 78);
            m_PictureBoxLikePagesPictureHeader.Name = "m_PictureBoxLikePagesPictureHeader";
            m_PictureBoxLikePagesPictureHeader.Size = new System.Drawing.Size(61, 18);
            m_PictureBoxLikePagesPictureHeader.TabIndex = 0;
            m_PictureBoxLikePagesPictureHeader.Text = "Picture:";
            // 
            // m_LabelLikePageNameHeader
            // 
            m_LabelLikePageNameHeader.AutoSize = true;
            m_LabelLikePageNameHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            m_LabelLikePageNameHeader.Location = new System.Drawing.Point(14, 32);
            m_LabelLikePageNameHeader.Name = "m_LabelLikePageNameHeader";
            m_LabelLikePageNameHeader.Size = new System.Drawing.Size(54, 18);
            m_LabelLikePageNameHeader.TabIndex = 2;
            m_LabelLikePageNameHeader.Text = "Name:";
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
            this.m_ListBoxLikePages.DataSource = this.pageBindingSource;
            this.m_ListBoxLikePages.DisplayMember = "Name";
            this.m_ListBoxLikePages.FormattingEnabled = true;
            this.m_ListBoxLikePages.Location = new System.Drawing.Point(6, 30);
            this.m_ListBoxLikePages.Name = "m_ListBoxLikePages";
            this.m_ListBoxLikePages.Size = new System.Drawing.Size(487, 277);
            this.m_ListBoxLikePages.TabIndex = 9;
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // m_PanelLikePages
            // 
            this.m_PanelLikePages.Controls.Add(m_PictureBoxLikePagesPictureHeader);
            this.m_PanelLikePages.Controls.Add(this.m_PictureBoxLikePagesPicture);
            this.m_PanelLikePages.Controls.Add(m_LabelLikePageNameHeader);
            this.m_PanelLikePages.Controls.Add(this.m_LabelLikePageName);
            this.m_PanelLikePages.Location = new System.Drawing.Point(499, 30);
            this.m_PanelLikePages.Name = "m_PanelLikePages";
            this.m_PanelLikePages.Size = new System.Drawing.Size(283, 277);
            this.m_PanelLikePages.TabIndex = 11;
            // 
            // m_PictureBoxLikePagesPicture
            // 
            this.m_PictureBoxLikePagesPicture.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
            this.m_PictureBoxLikePagesPicture.Location = new System.Drawing.Point(95, 78);
            this.m_PictureBoxLikePagesPicture.Name = "m_PictureBoxLikePagesPicture";
            this.m_PictureBoxLikePagesPicture.Size = new System.Drawing.Size(111, 100);
            this.m_PictureBoxLikePagesPicture.TabIndex = 1;
            this.m_PictureBoxLikePagesPicture.TabStop = false;
            // 
            // m_LabelLikePageName
            // 
            this.m_LabelLikePageName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Name", true));
            this.m_LabelLikePageName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelLikePageName.Location = new System.Drawing.Point(95, 32);
            this.m_LabelLikePageName.Name = "m_LabelLikePageName";
            this.m_LabelLikePageName.Size = new System.Drawing.Size(100, 23);
            this.m_LabelLikePageName.TabIndex = 3;
            this.m_LabelLikePageName.Text = "label1";
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
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
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
        private System.Windows.Forms.Label m_LabelError;
        private System.Windows.Forms.PictureBox m_PictureBoxLikePagesPicture;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.Label m_LabelLikePageName;
    }
}
