using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Week2
{
    public class Pizza : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        private string _price;
        //private int _quantity;


        public string name
        {
            get { return _name; }
            set {
                //_name = value;
                if (_name == value) { 
                    return;
                }
                _name = value;
                if (PropertyChanged != null){
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(name)));
                }
            }
        }

        public string price
        {
            get { return _price; }
            set {
                //_price = value;
                if (_price == value) { 
                    return;
                }
                _price = value;
                if (PropertyChanged != null){
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(price)));
                }
            }
        }

        //public int quantity
        //{
        //    get { return _quantity; }
        //    set
        //    {
        //        //_quantity = value;
        //        if (_quantity == value) { 
        //            return;
        //        }
        //        _quantity = value;
        //        if (PropertyChanged != null){
        //            PropertyChanged(this, new PropertyChangedEventArgs(nameof(quantity)));
        //        }
        //    }
        //}

        public Pizza() { }
        public Pizza(string n, string p)
        { 
            this.name = n;
            this.price = p;
        }

        //public static implicit operator string(Pizza v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
