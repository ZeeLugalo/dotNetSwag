using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dotNetSwag

{
    public partial class dotSwagitempage : ContentPage
    {
        private List<SwagItem> _dotNetSwag;

        public List<SwagItem> DotNetSwag
        {
            get { return _dotNetSwag; }
            set { _dotNetSwag = value; }
        }



        public dotSwagitempage()
        {
            InitializeComponent();



        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var database = SwagDatabase.Instance;


            BindingContext = new SwagItem();

        }

        private void  ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            var database = SwagDatabase.Instance;

            SwagItem item = BindingContext as SwagItem;

            database.SaveSwagItem(item);

        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {

        }

        private void OnCancelClicked(object sender, EventArgs e)
        {

        }
    }
}
