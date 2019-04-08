using System;
using System.Collections;
using System.Collections.Generic;
using ListViewSample.Models;
using Xamarin.Forms;

namespace ListViewSample.Views
{
    public partial class MusicsPage : ContentPage
    {
         public MusicsPage()
        {
            InitializeComponent();
        }

        async void Item_Clicked(object sender, System.EventArgs e)
        { 
            await Navigation.PushAsync(new MusicDetailPage((MusicLitsView.SelectedItem as Musics).Picture, (MusicLitsView.SelectedItem as Musics).Name, (MusicLitsView.SelectedItem as Musics).Description));  
        }
    }
}
