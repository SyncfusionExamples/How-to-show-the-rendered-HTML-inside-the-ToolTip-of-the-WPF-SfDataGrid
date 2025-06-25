using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDataGrid
{
    public class OrderInfoCollection
    {
        private ObservableCollection<OrderInfo> _orders;
        public ObservableCollection<OrderInfo> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }
        public OrderInfoCollection()
        {
            _orders = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }
        private void GenerateOrders()
        {
            _orders.Add(new OrderInfo("Maria Anders", "Germany", "<html><head><style>body {font-family: Arial, sans-serif;font-size: 14px;}h1 {color: #0066cc;}</style></head><body><h1>This is a heading</h1><p>This is a paragraph.</p><p>Maria Anders, Germany, ALFKI, Berlin.</p></body></html>"));

            _orders.Add(new OrderInfo("Ana Trujilo", "Mexico", "<html><head><style>body {font-family: Arial, sans-serif;font-size: 14px;}h1 {color: #0066cc;}</style></head><body><h1>This is a heading</h1><p>This is a paragraph.</p><p>Ana Trujilo, Mexico, ANATR, Mexico D.F..</p></body></html>"));

            _orders.Add(new OrderInfo("Antonio Moreno", "Mexico", "<html><head><style>body {font-family: Arial, sans-serif;font-size: 14px;}h1 {color: #0066cc;}</style></head><body><h1>This is a heading</h1><p>This is a paragraph.</p><p>Antonio Moreno, Mexico, ANTON, Mexico D.F..</p></body></html>"));

            _orders.Add(new OrderInfo("Thomas Hardy", "UK", "<html><head><style>body {font-family: Arial, sans-serif;font-size: 14px;}h1 {color: #0066cc;}</style></head><body><h1>This is a heading</h1><p>This is a paragraph.</p><p>Thomas Hardy, UK, AROUT, London.</p></body></html>"));

            _orders.Add(new OrderInfo("Christina Berglund", "Sweden", "<html><head><style>body {font-family: Arial, sans-serif;font-size: 14px;}h1 {color: #0066cc;}</style></head><body><h1>This is a heading</h1><p>This is a paragraph.</p><p>Christina Berglund, Sweden, BERGS, Lula.</p></body></html>"));

            _orders.Add(new OrderInfo("Hanna Moos", "Germany", "<html><head><style>body {font-family: Arial, sans-serif;font-size: 14px;}h1 {color: #0066cc;}</style></head><body><h1>This is a heading</h1><p>This is a paragraph.</p><p>Hanna Moos, Germany, BLAUS, Mannheim.</p></body></html>"));

            _orders.Add(new OrderInfo("Frederique Citeaux", "France", "<html><head><style>body {font-family: Arial, sans-serif;font-size: 14px;}h1 {color: #0066cc;}</style></head><body><h1>This is a heading</h1><p>This is a paragraph.</p><p>Frederique Citeaux, France,BLONP, Strasbourg.</p></body></html>"));
        }
    }
}
