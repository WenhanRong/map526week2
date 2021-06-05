using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CurrentPage : ContentPage
    {
        //public CurrentPage()
        //{
        //    InitializeComponent();
        //}

        ObservableCollection<Product> products;
        //ObservableCollection<PurchaseHistory> purchaseHistories;


        public CurrentPage(ObservableCollection<Product> products)
        {
            InitializeComponent();

            this.products = products;

            //purchaseHistories = purchaseHistory;

        }
    }
}