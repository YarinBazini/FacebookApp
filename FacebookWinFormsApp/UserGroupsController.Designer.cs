
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label m_LabelGroupDescriptionHeader;
            System.Windows.Forms.Label m_PictureBoxGroupPictureHeader;
            System.Windows.Forms.Label m_LabelGroupNameHader;
            System.Windows.Forms.Label m_LabelGroupPrivacyHeader;
            System.Windows.Forms.Label updateTimeLabel;
            this.m_LabelGroupsExplanation = new System.Windows.Forms.Label();
            this.m_ListBoxGroups = new System.Windows.Forms.ListBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_LabelError = new System.Windows.Forms.Label();
            this.m_PanelGroupDetails = new System.Windows.Forms.Panel();
            this.updateTimeLabel1 = new System.Windows.Forms.Label();
            this.m_PictureBoxGroupPicture = new System.Windows.Forms.PictureBox();
            this.m_LabelGroupDescription = new System.Windows.Forms.TextBox();
            this.m_LabelGroupName = new System.Windows.Forms.Label();
            this.m_LabelGroupPrivacy = new System.Windows.Forms.Label();
            m_LabelGroupDescriptionHeader = new System.Windows.Forms.Label();
            m_PictureBoxGroupPictureHeader = new System.Windows.Forms.Label();
            m_LabelGroupNameHader = new System.Windows.Forms.Label();
            m_LabelGroupPrivacyHeader = new System.Windows.Forms.Label();
            updateTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.m_PanelGroupDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxGroupPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // m_LabelGroupDescriptionHeader
            // 
            m_LabelGroupDescriptionHeader.AutoSize = true;
            m_LabelGroupDescriptionHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            m_LabelGroupDescriptionHeader.Location = new System.Drawing.Point(18, 155);
            m_LabelGroupDescriptionHeader.Name = "m_LabelGroupDescriptionHeader";
            m_LabelGroupDescriptionHeader.Size = new System.Drawing.Size(77, 16);
            m_LabelGroupDescriptionHeader.TabIndex = 0;
            m_LabelGroupDescriptionHeader.Text = "Description:";
            // 
            // m_PictureBoxGroupPictureHeader
            // 
            m_PictureBoxGroupPictureHeader.AutoSize = true;
            m_PictureBoxGroupPictureHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            m_PictureBoxGroupPictureHeader.Location = new System.Drawing.Point(18, 80);
            m_PictureBoxGroupPictureHeader.Name = "m_PictureBoxGroupPictureHeader";
            m_PictureBoxGroupPictureHeader.Size = new System.Drawing.Size(53, 16);
            m_PictureBoxGroupPictureHeader.TabIndex = 2;
            m_PictureBoxGroupPictureHeader.Text = "Picture:";
            // 
            // m_LabelGroupNameHader
            // 
            m_LabelGroupNameHader.AutoSize = true;
            m_LabelGroupNameHader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            m_LabelGroupNameHader.Location = new System.Drawing.Point(18, 16);
            m_LabelGroupNameHader.Name = "m_LabelGroupNameHader";
            m_LabelGroupNameHader.Size = new System.Drawing.Size(46, 16);
            m_LabelGroupNameHader.TabIndex = 4;
            m_LabelGroupNameHader.Text = "Name:";
            // 
            // m_LabelGroupPrivacyHeader
            // 
            m_LabelGroupPrivacyHeader.AutoSize = true;
            m_LabelGroupPrivacyHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            m_LabelGroupPrivacyHeader.Location = new System.Drawing.Point(18, 48);
            m_LabelGroupPrivacyHeader.Name = "m_LabelGroupPrivacyHeader";
            m_LabelGroupPrivacyHeader.Size = new System.Drawing.Size(54, 16);
            m_LabelGroupPrivacyHeader.TabIndex = 6;
            m_LabelGroupPrivacyHeader.Text = "Privacy:";
            // 
            // updateTimeLabel
            // 
            updateTimeLabel.AutoSize = true;
            updateTimeLabel.Location = new System.Drawing.Point(24, 251);
            updateTimeLabel.Name = "updateTimeLabel";
            updateTimeLabel.Size = new System.Drawing.Size(71, 13);
            updateTimeLabel.TabIndex = 8;
            updateTimeLabel.Text = "Update Time:";
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
            this.m_ListBoxGroups.DataSource = this.groupBindingSource;
            this.m_ListBoxGroups.DisplayMember = "Name";
            this.m_ListBoxGroups.FormattingEnabled = true;
            this.m_ListBoxGroups.Location = new System.Drawing.Point(6, 29);
            this.m_ListBoxGroups.Name = "m_ListBoxGroups";
            this.m_ListBoxGroups.Size = new System.Drawing.Size(397, 264);
            this.m_ListBoxGroups.TabIndex = 6;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
            // 
            // m_LabelError
            // 
            this.m_LabelError.AutoSize = true;
            this.m_LabelError.ForeColor = System.Drawing.Color.Red;
            this.m_LabelError.Location = new System.Drawing.Point(529, 10);
            this.m_LabelError.Name = "m_LabelError";
            this.m_LabelError.Size = new System.Drawing.Size(177, 13);
            this.m_LabelError.TabIndex = 9;
            this.m_LabelError.Text = "Fetch failed - please try again later,,,";
            this.m_LabelError.Visible = false;
            // 
            // m_PanelGroupDetails
            // 
            this.m_PanelGroupDetails.Controls.Add(updateTimeLabel);
            this.m_PanelGroupDetails.Controls.Add(this.updateTimeLabel1);
            this.m_PanelGroupDetails.Controls.Add(this.m_PictureBoxGroupPicture);
            this.m_PanelGroupDetails.Controls.Add(m_LabelGroupDescriptionHeader);
            this.m_PanelGroupDetails.Controls.Add(this.m_LabelGroupDescription);
            this.m_PanelGroupDetails.Controls.Add(m_PictureBoxGroupPictureHeader);
            this.m_PanelGroupDetails.Controls.Add(m_LabelGroupNameHader);
            this.m_PanelGroupDetails.Controls.Add(this.m_LabelGroupName);
            this.m_PanelGroupDetails.Controls.Add(m_LabelGroupPrivacyHeader);
            this.m_PanelGroupDetails.Controls.Add(this.m_LabelGroupPrivacy);
            this.m_PanelGroupDetails.Location = new System.Drawing.Point(409, 29);
            this.m_PanelGroupDetails.Name = "m_PanelGroupDetails";
            this.m_PanelGroupDetails.Size = new System.Drawing.Size(307, 292);
            this.m_PanelGroupDetails.TabIndex = 10;
            // 
            // updateTimeLabel1
            // 
            this.updateTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "UpdateTime", true));
            this.updateTimeLabel1.Location = new System.Drawing.Point(101, 251);
            this.updateTimeLabel1.Name = "updateTimeLabel1";
            this.updateTimeLabel1.Size = new System.Drawing.Size(100, 23);
            this.updateTimeLabel1.TabIndex = 9;
            // 
            // m_PictureBoxGroupPicture
            // 
            this.m_PictureBoxGroupPicture.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.groupBindingSource, "ImageNormal", true));
            this.m_PictureBoxGroupPicture.Location = new System.Drawing.Point(98, 80);
            this.m_PictureBoxGroupPicture.Name = "m_PictureBoxGroupPicture";
            this.m_PictureBoxGroupPicture.Size = new System.Drawing.Size(77, 57);
            this.m_PictureBoxGroupPicture.TabIndex = 8;
            this.m_PictureBoxGroupPicture.TabStop = false;
            // 
            // m_LabelGroupDescription
            // 
            this.m_LabelGroupDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Description", true));
            this.m_LabelGroupDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelGroupDescription.Location = new System.Drawing.Point(101, 152);
            this.m_LabelGroupDescription.Multiline = true;
            this.m_LabelGroupDescription.Name = "m_LabelGroupDescription";
            this.m_LabelGroupDescription.ReadOnly = true;
            this.m_LabelGroupDescription.Size = new System.Drawing.Size(168, 79);
            this.m_LabelGroupDescription.TabIndex = 1;
            // 
            // m_LabelGroupName
            // 
            this.m_LabelGroupName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Name", true));
            this.m_LabelGroupName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelGroupName.Location = new System.Drawing.Point(98, 16);
            this.m_LabelGroupName.Name = "m_LabelGroupName";
            this.m_LabelGroupName.Size = new System.Drawing.Size(100, 23);
            this.m_LabelGroupName.TabIndex = 5;
            // 
            // m_LabelGroupPrivacy
            // 
            this.m_LabelGroupPrivacy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Privacy", true));
            this.m_LabelGroupPrivacy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelGroupPrivacy.Location = new System.Drawing.Point(101, 47);
            this.m_LabelGroupPrivacy.Name = "m_LabelGroupPrivacy";
            this.m_LabelGroupPrivacy.Size = new System.Drawing.Size(100, 23);
            this.m_LabelGroupPrivacy.TabIndex = 7;
            // 
            // UserGroupsController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.m_PanelGroupDetails);
            this.Controls.Add(this.m_LabelError);
            this.Controls.Add(this.m_LabelGroupsExplanation);
            this.Controls.Add(this.m_ListBoxGroups);
            this.Name = "UserGroupsController";
            this.Size = new System.Drawing.Size(781, 337);
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.m_PanelGroupDetails.ResumeLayout(false);
            this.m_PanelGroupDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxGroupPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_LabelGroupsExplanation;
        private System.Windows.Forms.ListBox m_ListBoxGroups;
        private System.Windows.Forms.Label m_LabelError;
        private System.Windows.Forms.Panel m_PanelGroupDetails;
        private System.Windows.Forms.TextBox m_LabelGroupDescription;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.Label m_LabelGroupName;
        private System.Windows.Forms.Label m_LabelGroupPrivacy;
        private System.Windows.Forms.PictureBox m_PictureBoxGroupPicture;
        private System.Windows.Forms.Label updateTimeLabel1;
    }
}
