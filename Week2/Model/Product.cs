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
        private double _subAmount;
        public event PropertyChangedEventHandler PropertyChanged;
        //private int _quantity;

        //ObservableCollection<Order> orders;

        public List<Pizza> pizzas = new List<Pizza>();
        public List<PizzaSize> sizes = new List<PizzaSize>();

        //public Pizza pizzas = new Pizza();
        //public PizzaSize sizes = new PizzaSize();
        //public List<PizzaOrder> pizzaorder = new List<PizzaOrder>();

        public ObservableCollection<Model.Order> ol = new ObservableCollection<Model.Order>();
        public double qty { get; set; }
        public double total { get; set; }
        public Pizza p;      //pizza class
        public PizzaSize ps; //pizzasize class
        public string pizzaToppingName { get; set; }
        public string pizzaSizeName { get; set; }

                             
        public double subAmount
        {
            get
            {
                return _subAmount;
                //double price = Convert.ToDouble(p.price);
                //double rate = Convert.ToDouble(ps.rate);
                //double quantity = Convert.ToDouble(Quantity);
                //return price*rate*quantity;           
                ////return Convert.ToDouble(p.price) * Convert.ToDouble(ps.rate) * Convert.ToDouble(Quantity);
            }
            set 
            {
                if (_subAmount == value)
                {
                    return;
                }
                _subAmount = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(subAmount)));
                }
            }
        }

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
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(quantity)));
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
            //this.ol.Add(new Model.Order(pizza, size, DateTime.Now.ToString(), quantity));
        }

        


        public void Button_MyOrder(Pizza p)
        {
            pizzas.Add(p);
        }

 

        public Product(Pizza pizza, PizzaSize pizzasize , string quantity) 
        {
            p = new Pizza(pizza.name, pizza.price);
            ps = new PizzaSize(pizzasize.name, pizzasize.rate);
            this.p = pizza;
            this.ps = pizzasize;
            this.pizzaToppingName = pizza.name;
            this.pizzaSizeName = pizzasize.name;
            this.subAmount = Convert.ToDouble(p.price) * Convert.ToDouble(ps.rate) * Convert.ToDouble(Quantity);
            this.Quantity = quantity;
        }
        //public Product()
        //{
        //    pizzas.Add(new Pizza("vegitables", "10"));
        //    pizzas.Add(new Pizza("meet balls", "20"));
        //    pizzas.Add(new Pizza("pepperony", "30"));
        //    pizzas.Add(new Pizza("mushrooms", "40"));
        //    pizzas.Add(new Pizza("pasta", "40"));
        //    pizzas.Add(new Pizza("apple", "40"));
        //    pizzas.Add(new Pizza("lemon", "40"));
        //    sizes.Add(new PizzaSize("Large", 3));
        //    sizes.Add(new PizzaSize("Medium", 2));
        //    sizes.Add(new PizzaSize("Small", 1));
        //    sizes.Add(new PizzaSize("Party", 4));
        //}
    }
}
