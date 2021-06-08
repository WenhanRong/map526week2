using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Week2.Model;
using System.Collections.ObjectModel;
using Xamarin.Forms.Xaml;

namespace Week2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        Pizza selectedTopping = null;
        PizzaSize selectedSize = null;

        Product product;
        Order order;
        //PurchaseHistory purchaseHistory;

        ObservableCollection<Product> products;
        //ObservableCollection<PurchaseHistory> purchaseHistory;

        Pizza p;
        PizzaSize pz;
        //Product product = new Product();
        //Order order = new Order();
        PurchaseHistory purchases = new PurchaseHistory();

        //create the pizza topping name and price array
        ObservableCollection<Pizza> toppingName = new ObservableCollection<Pizza>
        {
            new Pizza("vegitables", "10"),
            new Pizza("meet balls", "20"),
            new Pizza("pepperony", "30"),
            new Pizza("mushrooms", "40"),
            new Pizza("pasta", "50"),
            new Pizza("apple", "60"),
            new Pizza("lemon", "70"),
        };

        //create the pizza size name and rate array
        ObservableCollection<PizzaSize> sizeName = new ObservableCollection<PizzaSize>
        {
            new PizzaSize("Large", 3),
            new PizzaSize("Medium", 2),
            new PizzaSize("Small", 1),
            new PizzaSize("Party", 4),
        };


        public MainPage(Order o, PurchaseHistory ph)
        {
            InitializeComponent();
            order = o;

            pizzaListTopping.ItemsSource = product.pizzas;
            pizzaListSize.ItemsSource = product.sizes;

            products = new ObservableCollection<Product>();
            //purchaseHistories = new ObservableCollection<PurchaseHistory>();
        }

        async private void Button_MyOrder(System.Object sender, System.EventArgs e)
        {
            //DisplayAlert("Thank You", "Pizza Prepared", "OK");
            //await Navigation.PushAsync(new MyOrder(order, purchaseHistory),  true);
            await Navigation.PushAsync(new MyOrder(order), true);

        }

        void pizzaListTopping_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            //var message = "Pizza Name is " + (e.SelectedItem as Pizza).name + " And the Price is " + (e.SelectedItem as Pizza).price;
            //DisplayAlert("Pizza Information", message, "OK");
            valueTopping.Text = (e.SelectedItem as Pizza).name;
            p = e.SelectedItem as Pizza;
        }

        //void pizzaListTopping_ItemSelected2(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        //{
        //    var message = "Pizza Size is " + (e.SelectedItem as Pizza).size;
        //    DisplayAlert("Pizza Size", message, "OK");
        //}

        void pizzaListSize_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            //var message = "Pizza Size is " + (e.SelectedItem as PizzaSize).name + " .Rate is " + (e.SelectedItem as PizzaSize).rate;
            //DisplayAlert("Pizza Size", message, "OK");
            valueSize.Text = (e.SelectedItem as PizzaSize).name;
            
        }

        private void Button_Clicked(object sender, EventArgs e) //Click Number 0~9 button
        {
            valueQuantity.Text = valueQuantity.Text == "0" ? ((Button)sender).Text : valueQuantity.Text + ((Button)sender).Text;
        }

        private void Button_Rest(object sender, EventArgs e) //Click RSET button
        {
            //valueQuantity.Text = "0";
            //valueTopping.Text = "0";
            //valueSize.Text = "0";
            //pizzaListTopping.SelectedItem = null;
            //pizzaListSize.SelectedItem = null;
            rest();

        }

        //private void Button_Calculate(object sender,  EventArgs e) //Click BUY button
        private void Button_Buy(object sender, System.EventArgs e) //Click BUY button
        {
            //products.Add(new Product((pizzaListTopping.SelectedItem) as Pizza, pizzaListSize.SelectedItem as PizzaSize, valueQuantity.Text));
            //add product into order
            order.addProduct(new Product((pizzaListTopping.SelectedItem) as Pizza, pizzaListSize.SelectedItem as PizzaSize, valueQuantity.Text));
            product.orderCalculator((pizzaListTopping.SelectedItem) as Pizza, pizzaListSize.SelectedItem as PizzaSize, valueQuantity.Text);
            var message = "Your order has now " + valueQuantity.Text + " pizzas, and the total is " + product.total + " CND. " ;
            DisplayAlert("Success!!", message, "OK");
             
            valueQuantity.Text = "0";
            valueTopping.Text = "0";
            valueSize.Text = "0";
            selectedTopping = null;
            selectedSize = null;

        }

        private void rest() 
        {
            valueQuantity.Text = "0";
            valueTopping.Text = "0";
            valueSize.Text = "0";
            selectedTopping = null;
            selectedSize = null;
            listToppings.ItemsSource = null;
            listSizes.ItemsSource = null;

            listToppings.ItemsSource = toppings;
            listSizes.ItemsSource = sizes;
        }
    }
}
