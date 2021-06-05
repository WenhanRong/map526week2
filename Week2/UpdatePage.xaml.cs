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
    public partial class UpdatePage : ContentPage
    {
        //public UpdatePage()
        //{
        //    InitializeComponent();
        //}

        //Product products;

        //public UpdatePage(Product prod)
        //{
        //    InitializeComponent();
        //    products = prod;
        //}

        ObservableCollection<Product> products;
        public UpdatePage(ObservableCollection<Product> products)
        {
            InitializeComponent();

            this.products = products;

        }

    }
}