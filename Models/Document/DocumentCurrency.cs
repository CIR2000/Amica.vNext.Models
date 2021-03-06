﻿using Newtonsoft.Json;

namespace Amica.Models.Documents
{
    public class DocumentCurrency : ObservableObject
    {
        private Currency _currency;
        private decimal _exchange_rate;

		public DocumentCurrency()
        {
            _currency = new Currency();
        }

        public Currency Current
        {
            set { SetProperty(ref _currency, value); }
            get { return _currency; }
        }

        public decimal ExchangeRate
        {
            set { SetProperty(ref _exchange_rate, value); }
            get { return _exchange_rate; }
        }
    }
}
