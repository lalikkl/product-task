using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class MainViewModell
    {
        public ObservableCollection<Product> ProductList { get; set; }
        public Product SelectProduct { get; set; }
        public MainViewModell()
        {
            ProductList = new ObservableCollection<Product>
            {
                new Product{Name="Asztal",Price=120,Qantity=40},
                new Product{Name="Szék",Price=80,Qantity=20},
                new Product{Name="Billentyűzet",Price=30,Qantity=30},
                new Product{Name="Monitor",Price=280,Qantity=20}
            };
        }
    }
}
