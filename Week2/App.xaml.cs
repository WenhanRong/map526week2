using System;
using Week2.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week2
{
    public partial class App : Application
    {
        Order order;
        PurchaseHistory purchaseHistory;
        public App()
        {
            InitializeComponent();
            order = new Order();
            purchaseHistory = new PurchaseHistory();
            MainPage = new NavigationPage(new MainPage(order, purchaseHistory));
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
