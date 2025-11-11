using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralPatternÖV3_5.Classes
{
    public class InvestorEvent
    {
        public string Name { get; }
        public InvestorEvent(string name) => Name = name;
        public void Subscribe(StockEvent stock)
        {
            stock.PriceChanged += OnPriceChanged;
        }
        private void OnPriceChanged(StockEvent stock)
        {
            Console.WriteLine($"{Name} notifierad via event: {stock.Symbol} = {stock.Price}");
        }
    }
}
