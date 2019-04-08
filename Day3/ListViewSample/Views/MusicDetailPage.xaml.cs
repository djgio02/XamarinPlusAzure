using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListViewSample.Views
{
    public partial class MusicDetailPage : ContentPage
    {
        public MusicDetailPage(string picture, string title, string description)
        {
            InitializeComponent();

            MusicPicture.Source = picture;
            lblTitle.Text       = title;
            lblDescription.Text = description;

        } 
    }
}
