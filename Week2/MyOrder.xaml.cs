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

    public partial class MyOrder : ContentPage
    {        
        //Product products;

        //public MyOrder(Product prod)
        //{
        //    InitializeComponent();
        //    products = prod;
        //}

        ObservableCollection<Product> products;
        //ObservableCollection<PurchaseHistory> purchaseHistories;

        public MyOrder(ObservableCollection<Product> product)
        {
            InitializeComponent();

            products = product;

            //purchaseHistories = purchaseHistory;
            
        }


        //Current_Clicked
        //Update_Clicked
        //History_Clicked
        //Add_Clicked

        async private void Current_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CurrentPage(products), true);
        }

        async private void Update_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UpdatePage(products), true);
        }

        async private void History_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HistoryPage(products), true);
        }

        async private void Add_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewOrderPage(products), true);
        }


    }
}