using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Services
{
    public interface IOrderItem
    {
        public OrderItem Add(OrderItem orderItem);
        public List<OrderItem> ListOrderItems();
        //public void Delete(int id); //no hay getbyid
        public void Update(OrderItem orderItem);
    }
}

