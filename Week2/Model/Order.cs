using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Week2.Model
{
    class Order
    {

  
        

        public Pizza p; //pizza class
        public PizzaSize ps; //pizza size class
        public string quantity;
        
        public double total; //total price

        public string DateTime;//datetime

        public Order() { }
        //public Order(Pizza p, PizzaSize ps, double total)
        //{
        //    this.p = p;
        //    this.ps = ps;
        //    this.total = total;
        //}
        public Order(Pizza pizza, PizzaSize pizzasize, string dateTime, string quantity)
        {
            p = new Pizza(pizza.name, pizza.price);
            ps = new PizzaSize(pizzasize.name, pizzasize.rate);
            this.DateTime = dateTime;
            this.quantity = quantity;
        }

    }
}
