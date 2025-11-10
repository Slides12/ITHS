namespace Observer_Pattern.Classes
{
    public class Stock
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public int oldPrice;

        private List<Investors> investors = new List<Investors>();

        public Stock(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public void ChangePrice(int newPrice)
        {
            oldPrice = Price;
            Price = newPrice;
            Notify();
        }

        public void Attach(Investors investor)
        {
            investors.Add(investor);
        }

        public void Detach(Investors investor)
        {
            investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (var investor in investors)
            {
                investor.Update(this);
            }
        }
    }
}
