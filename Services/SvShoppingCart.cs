using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entidades;

namespace Services
{
    public class SvShoppingCart : IShoppingCart
    {
        private readonly MyDbContext _myDbContext;

        // Esta es la forma de inyectar nuestro MyDbContext para que el servicio SvUser puede utilizarlo en sus metodos
        // Cuando se inyecta cualquier servicio, interfaz o clase se hace en el constructor de esta manera (Siempre)
        // El contenedor de dependencias sabe que tiene que pasar el servicio por el parámetro del constructor y así poder utilizarlo
        public SvShoppingCart(MyDbContext myDbContext) //Aquí viene el MyDbContext inyectado desde el proyecto DataAccess

        {
            _myDbContext = myDbContext;
        }

        public ShoppingCart Add(ShoppingCart shoppingCart)
        {
            _myDbContext.ShoppingCarts.Add(shoppingCart);
            _myDbContext.SaveChanges();

            return shoppingCart;
        }

        public void Update(int id, ShoppingCart shoppingCart)
        {

             _myDbContext.ShoppingCarts.Where(shoppingCart => shoppingCart.Id == id).First();

        }

        public void Delete(int id)
        {
            ShoppingCart shoppingCartFound = _myDbContext.ShoppingCarts.Where(shoppingCart => shoppingCart.Id == id).FirstOrDefault();

            _myDbContext.ShoppingCarts.Remove(shoppingCartFound);
            _myDbContext.SaveChanges();
        }

        public List<ShoppingCart> ListShoppingCarts()
        {
            return _myDbContext.ShoppingCarts.ToList();
        }
    }
}


