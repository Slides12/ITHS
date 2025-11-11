using System.Security.Cryptography.X509Certificates;

namespace Observer_Pattern.Classes
{
    public class Investors: IInvestor
    {
        public string Name { get; set; }

        public Investors(string name)
        {
            Name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine($"{Name}, Price changed for {stock.Name} to {stock.Price} from {stock.oldPrice}!!!");
        }
    }
}
