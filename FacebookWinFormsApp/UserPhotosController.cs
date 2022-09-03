﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppGUI
{
    public partial class UserPhotosController : UserControl, ITab
    {
        public AppManager Manager { get;}
        private readonly List<string> r_UserPhotoListOnSelectedPhotoAlbom;
        private int m_CurrentPhotoShowOnPhotosTab;

        public UserPhotosController()
        {
            InitializeComponent();
            Manager = AppManager.Instance;
            r_UserPhotoListOnSelectedPhotoAlbom = new List<string>();
        }

        public void FetchData()
        {
            try
            {
                m_ListBoxPhotos.Invoke(new Action(() => m_ListBoxPhotos.Items.Clear()));
                m_LabelError.Invoke(new Action(() => m_LabelError.Visible = false));
                foreach (Album album in Manager.UserPhotoAlbums)
                {
                    m_ListBoxPhotos.Invoke(new Action(() => m_ListBoxPhotos.Items.Add(album)));
                }

                if (m_ListBoxPhotos.Items.Count == 0)
                {
                    m_ListBoxPhotos.Invoke(new Action(() => m_ListBoxPhotos.Items.Add("You doesn't have photo alboms to show")));
                }
            }
            catch (Exception exception)
            {
                m_LabelError.Invoke(new Action(() => m_LabelError.Visible = true));
            }
            
        }

        private void m_ListBoxPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedPhotoAlbum();
        }

        private void displaySelectedPhotoAlbum()
        {
            Album selectedPhotoAlbum;

            r_UserPhotoListOnSelectedPhotoAlbom.Clear();
            m_LabelError.Visible = false;
            if (m_ListBoxPhotos.SelectedItems.Count == 1)
            {
                selectedPhotoAlbum = m_ListBoxPhotos.SelectedItem as Album;
                try
                {
                    if (selectedPhotoAlbum.Photos.Count > 0)
                    {
                        foreach (Photo photo in selectedPhotoAlbum.Photos)
                        {
                            r_UserPhotoListOnSelectedPhotoAlbom.Add(photo.PictureThumbURL);
                        }

                        m_ButtonPrevPhoto.Enabled = true;
                        m_ButtonNextPhoto.Enabled = true;
                        m_CurrentPhotoShowOnPhotosTab = 0;
                        m_PictureBoxPhoto.LoadAsync(r_UserPhotoListOnSelectedPhotoAlbom[m_CurrentPhotoShowOnPhotosTab]);
                    }
                    else
                    {
                        m_PictureBoxPhoto.Image = m_PictureBoxPhoto.ErrorImage;
                        m_ButtonPrevPhoto.Enabled = false;
                        m_ButtonNextPhoto.Enabled = false;
                    }
                }
                catch (Exception exception)
                {
                    m_LabelError.Visible = true;
                }
            }
        }

        private void m_ButtonNextPhoto_Click_1(object sender, EventArgs e)
        {
            if (m_CurrentPhotoShowOnPhotosTab + 1 < r_UserPhotoListOnSelectedPhotoAlbom.Count)
            {
                m_CurrentPhotoShowOnPhotosTab++;
                m_PictureBoxPhoto.LoadAsync(r_UserPhotoListOnSelectedPhotoAlbom[m_CurrentPhotoShowOnPhotosTab]);
            }
        }

        private void m_ButtonPrevPhoto_Click_1(object sender, EventArgs e)
        {
            if (m_CurrentPhotoShowOnPhotosTab > 0)
            {
                m_CurrentPhotoShowOnPhotosTab--;
                m_PictureBoxPhoto.LoadAsync(r_UserPhotoListOnSelectedPhotoAlbom[m_CurrentPhotoShowOnPhotosTab]);
            }
        }
    }
}
