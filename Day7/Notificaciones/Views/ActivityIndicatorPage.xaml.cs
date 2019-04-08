using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Notificaciones.Views
{
    public partial class ActivityIndicatorPage : ContentPage
    {
        public ActivityIndicatorPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            activityIndicator.IsRunning = !activityIndicator.IsRunning;
        }
    }
}
