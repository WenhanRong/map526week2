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
    public partial class HistoryPage : ContentPage
    {
        //public HistoryPage()
        //{
        //    InitializeComponent();
        //}

        //Product products;

        //ObservableCollection<PurchaseHistory> purchaseHistories;

        //public HistoryPage(Product prod)
        //{
        //    InitializeComponent();
        //    products = prod;
        //}
        ObservableCollection<Product> products;
        public HistoryPage(ObservableCollection<Product> products)
        {
            InitializeComponent();

            this.products = products;

        }
    }
}