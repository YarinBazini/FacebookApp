
namespace FacebookAppGUI
{
    partial class UserPhotosController
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
            this.m_LabelPhotosExplanation = new System.Windows.Forms.Label();
            this.m_ButtonPrevPhoto = new System.Windows.Forms.Button();
            this.m_PictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.m_ButtonNextPhoto = new System.Windows.Forms.Button();
            this.m_ListBoxPhotos = new System.Windows.Forms.ListBox();
            this.m_LabelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // m_LabelPhotosExplanation
            // 
            this.m_LabelPhotosExplanation.AutoSize = true;
            this.m_LabelPhotosExplanation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelPhotosExplanation.Location = new System.Drawing.Point(3, 9);
            this.m_LabelPhotosExplanation.Name = "m_LabelPhotosExplanation";
            this.m_LabelPhotosExplanation.Size = new System.Drawing.Size(233, 16);
            this.m_LabelPhotosExplanation.TabIndex = 9;
            this.m_LabelPhotosExplanation.Text = "Click on a albom to view his photos";
            // 
            // m_ButtonPrevPhoto
            // 
            this.m_ButtonPrevPhoto.BackColor = System.Drawing.Color.RoyalBlue;
            this.m_ButtonPrevPhoto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_ButtonPrevPhoto.ForeColor = System.Drawing.Color.White;
            this.m_ButtonPrevPhoto.Location = new System.Drawing.Point(94, 240);
            this.m_ButtonPrevPhoto.Name = "m_ButtonPrevPhoto";
            this.m_ButtonPrevPhoto.Size = new System.Drawing.Size(94, 41);
            this.m_ButtonPrevPhoto.TabIndex = 8;
            this.m_ButtonPrevPhoto.Text = "< Back";
            this.m_ButtonPrevPhoto.UseVisualStyleBackColor = false;
            this.m_ButtonPrevPhoto.Click += new System.EventHandler(this.m_ButtonPrevPhoto_Click_1);
            // 
            // m_PictureBoxPhoto
            // 
            this.m_PictureBoxPhoto.Location = new System.Drawing.Point(194, 172);
            this.m_PictureBoxPhoto.Name = "m_PictureBoxPhoto";
            this.m_PictureBoxPhoto.Size = new System.Drawing.Size(228, 181);
            this.m_PictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxPhoto.TabIndex = 7;
            this.m_PictureBoxPhoto.TabStop = false;
            // 
            // m_ButtonNextPhoto
            // 
            this.m_ButtonNextPhoto.BackColor = System.Drawing.Color.RoyalBlue;
            this.m_ButtonNextPhoto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_ButtonNextPhoto.ForeColor = System.Drawing.Color.White;
            this.m_ButtonNextPhoto.Location = new System.Drawing.Point(428, 240);
            this.m_ButtonNextPhoto.Name = "m_ButtonNextPhoto";
            this.m_ButtonNextPhoto.Size = new System.Drawing.Size(94, 41);
            this.m_ButtonNextPhoto.TabIndex = 6;
            this.m_ButtonNextPhoto.Text = "Next >";
            this.m_ButtonNextPhoto.UseVisualStyleBackColor = false;
            this.m_ButtonNextPhoto.Click += new System.EventHandler(this.m_ButtonNextPhoto_Click_1);
            // 
            // m_ListBoxPhotos
            // 
            this.m_ListBoxPhotos.FormattingEnabled = true;
            this.m_ListBoxPhotos.Location = new System.Drawing.Point(6, 28);
            this.m_ListBoxPhotos.Name = "m_ListBoxPhotos";
            this.m_ListBoxPhotos.Size = new System.Drawing.Size(703, 134);
            this.m_ListBoxPhotos.TabIndex = 5;
            this.m_ListBoxPhotos.SelectedIndexChanged += new System.EventHandler(this.m_ListBoxPhotos_SelectedIndexChanged);
            // 
            // m_LabelError
            // 
            this.m_LabelError.AutoSize = true;
            this.m_LabelError.ForeColor = System.Drawing.Color.Red;
            this.m_LabelError.Location = new System.Drawing.Point(571, 11);
            this.m_LabelError.Name = "m_LabelError";
            this.m_LabelError.Size = new System.Drawing.Size(138, 13);
            this.m_LabelError.TabIndex = 10;
            this.m_LabelError.Text = "Error - please try again later.";
            this.m_LabelError.Visible = false;
            // 
            // UserPhotosController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.m_LabelError);
            this.Controls.Add(this.m_LabelPhotosExplanation);
            this.Controls.Add(this.m_ButtonPrevPhoto);
            this.Controls.Add(this.m_PictureBoxPhoto);
            this.Controls.Add(this.m_ButtonNextPhoto);
            this.Controls.Add(this.m_ListBoxPhotos);
            this.Name = "UserPhotosController";
            this.Size = new System.Drawing.Size(771, 367);
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_LabelPhotosExplanation;
        private System.Windows.Forms.Button m_ButtonPrevPhoto;
        private System.Windows.Forms.PictureBox m_PictureBoxPhoto;
        private System.Windows.Forms.Button m_ButtonNextPhoto;
        private System.Windows.Forms.ListBox m_ListBoxPhotos;
        private System.Windows.Forms.Label m_LabelError;
    }
}
