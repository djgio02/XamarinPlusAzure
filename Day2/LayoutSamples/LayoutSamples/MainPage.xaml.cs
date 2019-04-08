using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutSamples
{
    public partial class MainPage : ContentPage
    { 
       
        public MainPage()
        {
            InitializeComponent();
        }

        async void GridLayout_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new GridLayoutSample());
        }

        async void StackLayout_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new StackLayoutSample());
        }

        async void FlexLayout_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new FlexLayoutSample());
        }

        async void AbsoluteLayout_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AbsoluteLayoutSample());
        }


    }
}
