using lab1_E.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_E.ViewModel
{
    class CurrencyViewModel
    {
        public ObservableCollection<Currency> ListCurrency { get; set; } = new ObservableCollection<Currency>();

        public CurrencyViewModel()
        {
            this.ListCurrency.Add(new Currency(1, "Доллар", "USD"));
            this.ListCurrency.Add(new Currency(2, "Евро", "EUR"));
        }
    }
}
