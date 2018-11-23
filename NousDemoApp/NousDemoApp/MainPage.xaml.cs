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

            TrackEvent();
            SimulateException();

            BtnCrash.Clicked += BtnCrash_Clicked;
        }

        private void BtnCrash_Clicked(object sender, EventArgs e)
        {
            int a = 0;
            int k = 5 / a;
        }

        private void TrackEvent()
        {
            Analytics.TrackEvent("App launched");
        }

        private void SimulateException()
        {
            try
            {
                int a = 0;
                int k = 5 / a;
            }
            catch (Exception e)
            {
                Crashes.TrackError(e);
            }
        }
    }
}
