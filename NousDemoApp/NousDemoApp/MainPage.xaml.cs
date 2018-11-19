using System;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;
using Microsoft.AppCenter.Crashes;

namespace NousDemoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Analytics.TrackEvent("Nous Demo Project Launched");
            TrackCrash();
        }

        private void TrackCrash()
        {
            try
            {
                int value = 0;
                int newValue = 5 / value;
            }
            catch (Exception exception)
            {
                Crashes.TrackError(exception);
            }
        }
    }
}
