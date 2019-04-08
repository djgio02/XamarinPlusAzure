using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace Notificaciones.Views
{
    public partial class AlertsPage : ContentPage
    {
        public AlertsPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await DisplayAlert("Alert", "You have been alerted", "OK");
        }

        async void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            bool answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
            Debug.WriteLine("Answer: " + answer);
        }
    }
}
