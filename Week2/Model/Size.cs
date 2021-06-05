using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Week2.Model
{
    public class PizzaSize : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        private int _rate;

        public string name
        {
            get { return _name; }
            set{ 
                //_name = value;
                if (_name == value)
                {
                    return;
                }
                _name = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(name)));
                }
            }
        }

        public int rate
        {
            get { return _rate; }
            set {
                //_rate = value;
                if (_rate == value)
                {
                    return;
                }
                _rate = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(rate)));
                }
            }
        }

        public PizzaSize(string s, int r)
        {
            this._name = s;
            this._rate = r;
            
        }

        //public static implicit operator string(PizzaSize v)
        //{
        //    throw new NotImplementedException();
        //}
    }


    //price:
    //Small = 1;
    //Medium = 2;
    //Large = 3;
    //Party = 4;


}
