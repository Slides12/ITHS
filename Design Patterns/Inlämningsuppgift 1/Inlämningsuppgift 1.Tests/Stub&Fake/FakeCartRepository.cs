using Inlämningsuppgift_1.Entities;
using Inlämningsuppgift_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_1.Tests.Stub_Fake
{
    public class FakeCartRepository : ICartRepository
    {
        public int? ClearedUser { get; private set; }

        public void AddCartItem(int userId, CartItem item)
        {
            throw new NotImplementedException();
        }

        public void ClearCart(int userId) => ClearedUser = userId;

        public void Create(int userId)
        {
            throw new NotImplementedException();
        }

        public void DeleteProductInCart(int userId, CartItem product)
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, List<CartItem>> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<CartItem> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCartItem(int userId, CartItem item)
        {
            throw new NotImplementedException();
        }
    }

}
