using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entidades;

namespace Services
{
    public class SvOrderItem : IOrderItem
    {
        private readonly MyDbContext _myDbContext;

        // Esta es la forma de inyectar nuestro MyDbContext para que el servicio SvUser puede utilizarlo en sus metodos
        // Cuando se inyecta cualquier servicio, interfaz o clase se hace en el constructor de esta manera (Siempre)
        // El contenedor de dependencias sabe que tiene que pasar el servicio por el parámetro del constructor y así poder utilizarlo
        public SvOrderItem(MyDbContext myDbContext) //Aquí viene el MyDbContext inyectado desde el proyecto DataAccess

        {
            _myDbContext = myDbContext;
        }

        public OrderItem Add(OrderItem orderItem)
        {
            _myDbContext.OrderItems.Add(orderItem);
            _myDbContext.SaveChanges();

            return orderItem;
        }

        public List<OrderItem> ListOrderItems()
        {
            return _myDbContext.OrderItems.ToList();
        }

        //public void Delete(int id)
        //{
        //    OrderItem orderItemFound = _myDbContext.OrderItems.Where(orderItem => orderItem.Id == id).FirstOrDefault();

        //    _myDbContext.OrderItems.Remove(orderItemFound);
        //    _myDbContext.SaveChanges();
        //}

        public void Update(OrderItem orderItem)
        {
            Console.WriteLine("Update");
        }
    }
}
