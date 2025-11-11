using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralPatternÖV3_5.Classes
{
    public class StockEvent
    {
        public string Symbol { get; }
        private double _price;
        public StockEvent(string symbol, double price)
        {
            Symbol = symbol;
            _price = price;
        }
        public event Action<StockEvent>? PriceChanged;
        public double Price
        {
            get => _price;
            set
            {
                if (_price != value)
                {
                    _price = value;
                    PriceChanged?.Invoke(this);
                }
            }
        }
    }
}
