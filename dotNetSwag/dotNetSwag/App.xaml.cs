using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dotNetSwag
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var page = new NavigationPage(new dotSwagitempage());
            page.BarTextColor = Color.White;
            page.BarBackgroundColor = Color.Green;

            MainPage = page;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
