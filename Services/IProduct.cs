using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Services
{
    public interface IProduct
    {
        public Product Add(Product product);

        public List<Product> GetAll();
        public Product GetById(int id);
        
        public void Update(int id, Product product);
        public void Delete(int id);
    }
}
