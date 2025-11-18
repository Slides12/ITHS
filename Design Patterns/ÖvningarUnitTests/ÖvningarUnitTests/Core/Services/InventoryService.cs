namespace ÖvningarUnitTests.Core.Services
{
    public class InventoryServcie
    {
        private readonly Dictionary<string, int> _items = new();

        public void AddStock(string item, int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be positive");

            if (!_items.ContainsKey(item))
                _items[item] = 0;

            _items[item] += quantity;
        }

        public void RemoveStock(string item, int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be positive");

            if (!_items.ContainsKey(item) || _items[item] < quantity)
                throw new InvalidOperationException("Not enough stock");

            _items[item] -= quantity;
        }

        public int GetStock(string item)
        {
            return _items.TryGetValue(item, out var qty) ? qty : 0;
        }
    }
}
