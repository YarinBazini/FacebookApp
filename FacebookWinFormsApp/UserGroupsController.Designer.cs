
namespace FacebookAppGUI
{
    partial class UserGroupsController
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
            this.m_LabelGroupsExplanation = new System.Windows.Forms.Label();
            this.m_ListBoxGroups = new System.Windows.Forms.ListBox();
            this.m_PanelGroupDetails = new System.Windows.Forms.Panel();
            this.m_PictureBoxGroupPicture = new System.Windows.Forms.PictureBox();
            this.m_LabelGroupName = new System.Windows.Forms.Label();
            this.m_LabelGroupNameTitle = new System.Windows.Forms.Label();
            this.m_LabelGroupIconTitle = new System.Windows.Forms.Label();
            this.m_LabelGroupDescription = new System.Windows.Forms.Label();
            this.m_LabelGroupDescriptionTitle = new System.Windows.Forms.Label();
            this.m_LabelGroupPrivacy = new System.Windows.Forms.Label();
            this.m_LabelGroupPrivacyTitle = new System.Windows.Forms.Label();
            this.m_LabelError = new System.Windows.Forms.Label();
            this.m_PanelGroupDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxGroupPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // m_LabelGroupsExplanation
            // 
            this.m_LabelGroupsExplanation.AutoSize = true;
            this.m_LabelGroupsExplanation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelGroupsExplanation.Location = new System.Drawing.Point(3, 10);
            this.m_LabelGroupsExplanation.Name = "m_LabelGroupsExplanation";
            this.m_LabelGroupsExplanation.Size = new System.Drawing.Size(230, 16);
            this.m_LabelGroupsExplanation.TabIndex = 7;
            this.m_LabelGroupsExplanation.Text = "Click on a group to view his details";
            // 
            // m_ListBoxGroups
            // 
            this.m_ListBoxGroups.FormattingEnabled = true;
            this.m_ListBoxGroups.Location = new System.Drawing.Point(6, 29);
            this.m_ListBoxGroups.Name = "m_ListBoxGroups";
            this.m_ListBoxGroups.Size = new System.Drawing.Size(422, 264);
            this.m_ListBoxGroups.TabIndex = 6;
            this.m_ListBoxGroups.SelectedIndexChanged += new System.EventHandler(this.m_ListBoxGroups_SelectedIndexChanged);
            // 
            // m_PanelGroupDetails
            // 
            this.m_PanelGroupDetails.Controls.Add(this.m_PictureBoxGroupPicture);
            this.m_PanelGroupDetails.Controls.Add(this.m_LabelGroupName);
            this.m_PanelGroupDetails.Controls.Add(this.m_LabelGroupNameTitle);
            this.m_PanelGroupDetails.Controls.Add(this.m_LabelGroupIconTitle);
            this.m_PanelGroupDetails.Controls.Add(this.m_LabelGroupDescription);
            this.m_PanelGroupDetails.Controls.Add(this.m_LabelGroupDescriptionTitle);
            this.m_PanelGroupDetails.Controls.Add(this.m_LabelGroupPrivacy);
            this.m_PanelGroupDetails.Controls.Add(this.m_LabelGroupPrivacyTitle);
            this.m_PanelGroupDetails.Location = new System.Drawing.Point(434, 29);
            this.m_PanelGroupDetails.Name = "m_PanelGroupDetails";
            this.m_PanelGroupDetails.Size = new System.Drawing.Size(334, 261);
            this.m_PanelGroupDetails.TabIndex = 8;
            this.m_PanelGroupDetails.Visible = false;
            // 
            // m_PictureBoxGroupPicture
            // 
            this.m_PictureBoxGroupPicture.Location = new System.Drawing.Point(108, 75);
            this.m_PictureBoxGroupPicture.Name = "m_PictureBoxGroupPicture";
            this.m_PictureBoxGroupPicture.Size = new System.Drawing.Size(52, 48);
            this.m_PictureBoxGroupPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxGroupPicture.TabIndex = 11;
            this.m_PictureBoxGroupPicture.TabStop = false;
            // 
            // m_LabelGroupName
            // 
            this.m_LabelGroupName.AutoSize = true;
            this.m_LabelGroupName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelGroupName.Location = new System.Drawing.Point(105, 13);
            this.m_LabelGroupName.Name = "m_LabelGroupName";
            this.m_LabelGroupName.Size = new System.Drawing.Size(0, 16);
            this.m_LabelGroupName.TabIndex = 10;
            // 
            // m_LabelGroupNameTitle
            // 
            this.m_LabelGroupNameTitle.AutoSize = true;
            this.m_LabelGroupNameTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelGroupNameTitle.Location = new System.Drawing.Point(12, 13);
            this.m_LabelGroupNameTitle.Name = "m_LabelGroupNameTitle";
            this.m_LabelGroupNameTitle.Size = new System.Drawing.Size(49, 16);
            this.m_LabelGroupNameTitle.TabIndex = 9;
            this.m_LabelGroupNameTitle.Text = "Name:";
            // 
            // m_LabelGroupIconTitle
            // 
            this.m_LabelGroupIconTitle.AutoSize = true;
            this.m_LabelGroupIconTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelGroupIconTitle.Location = new System.Drawing.Point(14, 75);
            this.m_LabelGroupIconTitle.Name = "m_LabelGroupIconTitle";
            this.m_LabelGroupIconTitle.Size = new System.Drawing.Size(57, 16);
            this.m_LabelGroupIconTitle.TabIndex = 8;
            this.m_LabelGroupIconTitle.Text = "Picture:";
            // 
            // m_LabelGroupDescription
            // 
            this.m_LabelGroupDescription.AutoSize = true;
            this.m_LabelGroupDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelGroupDescription.Location = new System.Drawing.Point(107, 147);
            this.m_LabelGroupDescription.Name = "m_LabelGroupDescription";
            this.m_LabelGroupDescription.Size = new System.Drawing.Size(0, 16);
            this.m_LabelGroupDescription.TabIndex = 5;
            // 
            // m_LabelGroupDescriptionTitle
            // 
            this.m_LabelGroupDescriptionTitle.AutoSize = true;
            this.m_LabelGroupDescriptionTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelGroupDescriptionTitle.Location = new System.Drawing.Point(14, 147);
            this.m_LabelGroupDescriptionTitle.Name = "m_LabelGroupDescriptionTitle";
            this.m_LabelGroupDescriptionTitle.Size = new System.Drawing.Size(79, 16);
            this.m_LabelGroupDescriptionTitle.TabIndex = 4;
            this.m_LabelGroupDescriptionTitle.Text = "Description";
            // 
            // m_LabelGroupPrivacy
            // 
            this.m_LabelGroupPrivacy.AutoSize = true;
            this.m_LabelGroupPrivacy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelGroupPrivacy.Location = new System.Drawing.Point(105, 44);
            this.m_LabelGroupPrivacy.Name = "m_LabelGroupPrivacy";
            this.m_LabelGroupPrivacy.Size = new System.Drawing.Size(0, 16);
            this.m_LabelGroupPrivacy.TabIndex = 1;
            // 
            // m_LabelGroupPrivacyTitle
            // 
            this.m_LabelGroupPrivacyTitle.AutoSize = true;
            this.m_LabelGroupPrivacyTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelGroupPrivacyTitle.Location = new System.Drawing.Point(12, 44);
            this.m_LabelGroupPrivacyTitle.Name = "m_LabelGroupPrivacyTitle";
            this.m_LabelGroupPrivacyTitle.Size = new System.Drawing.Size(59, 16);
            this.m_LabelGroupPrivacyTitle.TabIndex = 0;
            this.m_LabelGroupPrivacyTitle.Text = "Privacy:";
            // 
            // m_LabelError
            // 
            this.m_LabelError.AutoSize = true;
            this.m_LabelError.ForeColor = System.Drawing.Color.Red;
            this.m_LabelError.Location = new System.Drawing.Point(589, 10);
            this.m_LabelError.Name = "m_LabelError";
            this.m_LabelError.Size = new System.Drawing.Size(177, 13);
            this.m_LabelError.TabIndex = 9;
            this.m_LabelError.Text = "Fetch failed - please try again later,,,";
            this.m_LabelError.Visible = false;
            // 
            // UserGroupsController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.m_LabelError);
            this.Controls.Add(this.m_PanelGroupDetails);
            this.Controls.Add(this.m_LabelGroupsExplanation);
            this.Controls.Add(this.m_ListBoxGroups);
            this.Name = "UserGroupsController";
            this.Size = new System.Drawing.Size(781, 337);
            this.m_PanelGroupDetails.ResumeLayout(false);
            this.m_PanelGroupDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxGroupPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_LabelGroupsExplanation;
        private System.Windows.Forms.ListBox m_ListBoxGroups;
        private System.Windows.Forms.Panel m_PanelGroupDetails;
        private System.Windows.Forms.PictureBox m_PictureBoxGroupPicture;
        private System.Windows.Forms.Label m_LabelGroupName;
        private System.Windows.Forms.Label m_LabelGroupNameTitle;
        private System.Windows.Forms.Label m_LabelGroupIconTitle;
        private System.Windows.Forms.Label m_LabelGroupDescription;
        private System.Windows.Forms.Label m_LabelGroupDescriptionTitle;
        private System.Windows.Forms.Label m_LabelGroupPrivacy;
        private System.Windows.Forms.Label m_LabelGroupPrivacyTitle;
        private System.Windows.Forms.Label m_LabelError;
    }
}
