using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Week2.Model
{
    public class Order : INotifyPropertyChanged
    {

        private double _amount;
        private string _dateTime;
        private double _orderQuantity;

        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Product> products = new ObservableCollection<Product>();


        public double amount
        {
            get
            {
                return _amount;
            }
            set
            {
                
                foreach (Product product in products)
                {
                    amount += product.subAmount;
                }
                
                _amount = amount;
            }
        }
        public string dateTime   //datetime
        {
            get { return _dateTime; }
            set
            {
                
                if (_dateTime == value)
                {
                    return;
                }
                _dateTime = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(dateTime)));
                }
            }
        }

        public double orderQuantity {
            get { return _orderQuantity; }
            set
            {

                //if (_orderQuantity == value)
                //{
                //    return;
                //}
                //_orderQuantity = value;
                //if (PropertyChanged != null)
                //{
                //    PropertyChanged(this, new PropertyChangedEventArgs(nameof(orderQuantity)));
                //}


                foreach (Product product in products)
                {
                    orderQuantity += Convert.ToDouble(product.Quantity);
                }

                _orderQuantity = orderQuantity;
            }
        }

        public bool newOrder {
            get; set;
        }

        public Order(ObservableCollection<Product> prods, double amt) {
            //save product list
            this.products = prods;
            this.amount = amt;
            this.dateTime = DateTime.Now.ToString();
            
        }

        public void deleteProduct(Product prod)
        {
            products.Remove(prod);
            this.amount -= prod.subAmount;
            //OnPropertyChanged("amount");
            this.orderQuantity -= Double.Parse(prod.Quantity);
            //OnPropertyChanged("orderQuantity");

        }

        public void addProduct(Product prod)
        {
            products.Add(prod);
            this.amount += prod.subAmount;
            this.orderQuantity += Double.Parse(prod.Quantity);
        }

        public void closeOrder()
        {
            dateTime = DateTime.Now.ToString();
        }

        //public void place()
        //{
        //    dateTime = DateTime.Now.ToString(); //date time

        //}

        //private void OnPropertyChanged(string propertyName) {
        //    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //}

        //public event PropertyChangedEventHandler PropertyChanged;
    }
}
