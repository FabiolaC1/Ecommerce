using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Services
{
    public interface IShoppingCart
    {
        public ShoppingCart Add(ShoppingCart shoppingCart);

        public List<ShoppingCart> ListShoppingCarts();

        public void Update(int id, ShoppingCart shoppingCart);
        public void Delete(int id);
    }
}
