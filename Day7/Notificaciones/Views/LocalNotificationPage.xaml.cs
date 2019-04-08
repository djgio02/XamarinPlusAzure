using System;
using System.Collections.Generic;
using Plugin.LocalNotifications;
using Xamarin.Forms;

namespace Notificaciones.Views
{
    public partial class LocalNotificationPage : ContentPage
    {
        public LocalNotificationPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            CrossLocalNotifications.Current.Show("hey!", "listen!");
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            CrossLocalNotifications.Current.Show("hey!", "Watch out!", 101, DateTime.Now.AddSeconds(5));

        }

        void Handle_Clicked_2(object sender, System.EventArgs e)
        {
            CrossLocalNotifications.Current.Cancel(101);
        }
    }
}
