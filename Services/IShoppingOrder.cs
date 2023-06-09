using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Services
{
    public interface IShoppingOrder
    {
        public ShoppingOrder  Add(ShoppingOrder shoppingOrder);

        public void CreateOrder(ShoppingOrder shoppingOrder);

        public List<ShoppingOrder> ListShoppingOrders();

        public void Update(ShoppingOrder shoppingOrder);

    }
}
