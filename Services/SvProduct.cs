using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entidades;

namespace Services
{
    public class SvProduct : IProduct
    {
        private readonly MyDbContext _myDbContext;
        public SvProduct(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        public Product Add(Product product)
        {
            _myDbContext.Products.Add(product);
            _myDbContext.SaveChanges();

            return product;
        }

        public List<Product> GetAll()
        {
            return _myDbContext.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _myDbContext.Products.Where(Product => Product.Id == id).First();
        }

        public void Delete(int id)
        {
            Product ProductFound = _myDbContext.Products.Where(Product => Product.Id == id).First();
            _myDbContext.Products.Remove(ProductFound);
            _myDbContext.SaveChanges();
        }

        public void Update(int id, Product product)
        {
            Product ProductFound = _myDbContext.Products.Where(Product => Product.Id == id).First();
            ProductFound.Name = product.Name;

            _myDbContext.Products.Update(ProductFound);
            _myDbContext.SaveChanges();

        }
    }
}
