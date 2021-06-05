using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Week2.Model
{
    class PurchaseHistory : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Product _product;
        private string _quantity;
        private string _amount;
        private string _dateTime;

        public Product Product
        {
            get { return _product; }
            set
            {

                if (_product == value)
                {
                    return;
                }
                _product = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Product)));
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
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Quantity)));
                }
            }
        }

        public string Amount
        {
            get { return _amount; }
            set
            {

                if (_amount == value)
                {
                    return;
                }
                _amount = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Amount)));
                }
            }
        }

        public string DateTime
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
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(DateTime)));
                }
            }
        }


        //public Product Product { get; set; }
        //public string Quantity { get; set; }
        //public string Amount { get; set; }
        //public string DateTime { get; set; }

        public PurchaseHistory() { }
        public PurchaseHistory(Product name, string quantity, string amount, string dateTime)
        {
            this.Product = name;
            this.Quantity = quantity;
            this.Amount = amount;
            this.DateTime = dateTime;
        }
    }
}
