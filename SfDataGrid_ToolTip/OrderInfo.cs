using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFDataGrid
{
  
    public class OrderInfo : INotifyPropertyChanged
    {     
        private string customerId;
        private string customerName;
        private string _htmlCode;


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string HTMLCode
        {
            get { return _htmlCode; }
            set
            {
                if (_htmlCode != value)
                {
                    _htmlCode = value;
                    OnPropertyChanged();
                }
            }
        }

        public string CustomerID
        {
            get => customerId;
            set
            {
                if (customerId != value)
                {
                    customerId = value;
                    OnPropertyChanged();
                }
            }
        }

        public string CustomerName
        {
            get => customerName;
            set
            {
                if (customerName != value)
                {
                    customerName = value;
                    OnPropertyChanged();
                }
            }
        }
        public OrderInfo(string customerName,string customerId, string htmlCode)
        {
            this.CustomerName = customerName;
            this.CustomerID = customerId;
            this.HTMLCode = htmlCode;       
        }
    }

}
