
namespace FacebookAppGUI
{
    partial class UserPostsController
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
            this.m_LabelComments = new System.Windows.Forms.Label();
            this.m_ListBoxPostComments = new System.Windows.Forms.ListBox();
            this.m_LabelPostExplanation = new System.Windows.Forms.Label();
            this.m_ListBoxPosts = new System.Windows.Forms.ListBox();
            this.m_LabelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_LabelComments
            // 
            this.m_LabelComments.AutoSize = true;
            this.m_LabelComments.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LabelComments.Location = new System.Drawing.Point(13, 213);
            this.m_LabelComments.Name = "m_LabelComments";
            this.m_LabelComments.Size = new System.Drawing.Size(79, 16);
            this.m_LabelComments.TabIndex = 11;
            this.m_LabelComments.Text = "Comments:";
            // 
            // m_ListBoxPostComments
            // 
            this.m_ListBoxPostComments.FormattingEnabled = true;
            this.m_ListBoxPostComments.Location = new System.Drawing.Point(16, 241);
            this.m_ListBoxPostComments.Name = "m_ListBoxPostComments";
            this.m_ListBoxPostComments.Size = new System.Drawing.Size(794, 121);
            this.m_ListBoxPostComments.TabIndex = 10;
            // 
            // m_LabelPostExplanation
            // 
            this.m_LabelPostExplanation.AutoSize = true;
            this.m_LabelPostExplanation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelPostExplanation.Location = new System.Drawing.Point(13, 9);
            this.m_LabelPostExplanation.Name = "m_LabelPostExplanation";
            this.m_LabelPostExplanation.Size = new System.Drawing.Size(242, 16);
            this.m_LabelPostExplanation.TabIndex = 9;
            this.m_LabelPostExplanation.Text = "Click on a post to view his comments";
            // 
            // m_ListBoxPosts
            // 
            this.m_ListBoxPosts.FormattingEnabled = true;
            this.m_ListBoxPosts.Location = new System.Drawing.Point(16, 28);
            this.m_ListBoxPosts.Name = "m_ListBoxPosts";
            this.m_ListBoxPosts.Size = new System.Drawing.Size(794, 173);
            this.m_ListBoxPosts.TabIndex = 8;
            this.m_ListBoxPosts.SelectedIndexChanged += new System.EventHandler(this.m_ListBoxPosts_SelectedIndexChanged);
            // 
            // m_LabelError
            // 
            this.m_LabelError.AutoSize = true;
            this.m_LabelError.ForeColor = System.Drawing.Color.Red;
            this.m_LabelError.Location = new System.Drawing.Point(588, 9);
            this.m_LabelError.Name = "m_LabelError";
            this.m_LabelError.Size = new System.Drawing.Size(144, 13);
            this.m_LabelError.TabIndex = 12;
            this.m_LabelError.Text = "Error - please try again later...";
            this.m_LabelError.Visible = false;
            // 
            // UserPostsController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.m_LabelError);
            this.Controls.Add(this.m_LabelComments);
            this.Controls.Add(this.m_ListBoxPostComments);
            this.Controls.Add(this.m_LabelPostExplanation);
            this.Controls.Add(this.m_ListBoxPosts);
            this.Name = "UserPostsController";
            this.Size = new System.Drawing.Size(832, 375);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_LabelComments;
        private System.Windows.Forms.ListBox m_ListBoxPostComments;
        private System.Windows.Forms.Label m_LabelPostExplanation;
        private System.Windows.Forms.ListBox m_ListBoxPosts;
        private System.Windows.Forms.Label m_LabelError;
    }
}
