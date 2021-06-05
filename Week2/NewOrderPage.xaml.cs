using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewOrderPage : ContentPage
    {
        //public NewOrderPage()
        //{
        //    InitializeComponent();
        //}

        //Product products;

        //public NewOrderPage(Product prod)
        //{
        //    InitializeComponent();
        //    products = prod;
        //}

        ObservableCollection<Product> products;
        public NewOrderPage(ObservableCollection<Product> products)
        {
            InitializeComponent();

            this.products = products;

        }
    }
}