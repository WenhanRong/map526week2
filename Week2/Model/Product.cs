using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Week2.Model;

namespace Week2
{
    public class Product : INotifyPropertyChanged
    {
        private string _quantity;

        public event PropertyChangedEventHandler PropertyChanged;
        //private int _quantity;

        //ObservableCollection<Order> orders;

        public List<Pizza> pizzas = new List<Pizza>();
        //public Pizza pizzas = new Pizza();
        public List<PizzaSize> sizes = new List<PizzaSize>();
        //public PizzaSize sizes = new PizzaSize();
        //public List<PizzaOrder> pizzaorder = new List<PizzaOrder>();

        ObservableCollection<Model.Order> ol = new ObservableCollection<Model.Order>();
        public double qty = 0;
        public double total = 0;
        public Pizza p; //pizza class
        public PizzaSize ps; //pizza size class


        public string Quantity
        {
            get { return _quantity; }
            set
            {
                if (_quantity == value)
                {
                    return;
                }
                _quantity = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Quantity)));
                }
            }
        }

        //public void addNewPizza(Pizza p)
        //{
        //    pizzas.Add(p);
        //}

        //public event PropertyChangedEventHandler PropertyChanged;

        //private string _name;
        //private string _price;
        //private string _size;


        //public Order() { }
        //public Order(string n, string p)
        //{
        //    this.name = n;
        //    this.price = p;
        //}



        public void orderCalculator(Pizza pizza , PizzaSize size, string quantity)
        {
            this.qty = Double.Parse(quantity);
            this.total = Double.Parse(pizza.price) * size.rate * Double.Parse(quantity);
            this.ol.Add(new Model.Order(pizza, size, DateTime.Now.ToString(), quantity));
        }

        public void Button_MyOrder(Pizza p)
        {
            pizzas.Add(p);
        }

        //public void Button_Calculate(Pizza p)
        //{
        //    pizzas.Add(p);
        //}

        //orders = new ObservableCollection<Order>
        //    {
        //        new Order("Pants", "50.7", "20"),
        //        new Product("Shoes", "90", "50"),
        //        new Product("Hats", "20.5", "10"),
        //        new Product("Tshirts", "15.6", "20"),
        //        new Product("Gloves", "25.99", "30"),
        //        new Product("Dresses", "65.5", "40"),
        //        new Product("C# Book", "99.99", "100")
        //    };

        public Product(Pizza pizza, PizzaSize pizzasize , string quantity) 
        {
            p = new Pizza(pizza.name, pizza.price);
            ps = new PizzaSize(pizzasize.name, pizzasize.rate);
            this._quantity = quantity;
        }
        public Product()
        {
            pizzas.Add(new Pizza("vegitables", "10"));
            pizzas.Add(new Pizza("meet balls", "20"));
            pizzas.Add(new Pizza("pepperony", "30"));
            pizzas.Add(new Pizza("mushrooms", "40"));
            pizzas.Add(new Pizza("pasta", "40"));
            pizzas.Add(new Pizza("apple", "40"));
            pizzas.Add(new Pizza("lemon", "40"));
            sizes.Add(new PizzaSize("Large", 3));
            sizes.Add(new PizzaSize("Medium", 2));
            sizes.Add(new PizzaSize("Small", 1));
            sizes.Add(new PizzaSize("Party", 4));
        }
    }
}
