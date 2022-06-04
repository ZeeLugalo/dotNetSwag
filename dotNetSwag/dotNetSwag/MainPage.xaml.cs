using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace dotNetSwag
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            static void dotNetSwagData();
            var dotNetSwag= new dotNetSwag();
            dotNetSwagData();
      
            dotNetSwag.DefautRequestHeaders.Add("Accept , Application/json");

            dotNetSwag.GetstringAsync(dotNetSwag);
             


        }
    }
}
