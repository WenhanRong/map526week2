using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace Week2.Model
{
    public class PurchaseHistory : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Order> productRecord = new ObservableCollection<Order>();      

        public PurchaseHistory() { 
            // save order list
        }
        public PurchaseHistory(Order order)
        {
            order.closeOrder();
            productRecord.Add(order);
        }
    }
}
