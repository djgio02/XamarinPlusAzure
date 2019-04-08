using System;
using System.Collections.Generic;
using Plugin.Toast;
using Xamarin.Forms;

namespace Notificaciones.Views
{
    public partial class ToastPage : ContentPage
    {
        public ToastPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            CrossToastPopUp.Current.ShowToastMessage("What a great Toast!");
        }
    }
}
