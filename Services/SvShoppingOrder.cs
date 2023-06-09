using DataAccess;
using Entidades;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;

namespace Services
{
    public class SvShoppingOrder : IShoppingOrder
    {
        private readonly MyDbContext _myDbContext;

        public SvShoppingOrder(MyDbContext myDbContext) //Aquí viene el MyDbContext inyectado desde el proyecto DataAccess

        {
            _myDbContext = myDbContext;
        }

        public ShoppingOrder Add(ShoppingOrder shoppingOrder)
        {
            _myDbContext.ShoppingOrders.Add(shoppingOrder);
            _myDbContext.SaveChanges();

            return shoppingOrder;
        }

        public List<ShoppingOrder> ListShoppingOrders()
        {
            return _myDbContext.ShoppingOrders.ToList();
        }

        public void CreateOrder(ShoppingOrder shoppingOrder)
        {
            _myDbContext.ShoppingOrders.Add(shoppingOrder);
            _myDbContext.SaveChanges();
        }

        public void Update(ShoppingOrder shoppingOrder)
        {
            throw new NotImplementedException();
        }
    }
}

