using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entidades;

namespace Services
{
    public class SvCategory : ICategory
    {
        private readonly MyDbContext _myDbContext;

        // Esta es la forma de inyectar nuestro MyDbContext para que el servicio SvUser puede utilizarlo en sus metodos
        // Cuando se inyecta cualquier servicio, interfaz o clase se hace en el constructor de esta manera (Siempre)
        // El contenedor de dependencias sabe que tiene que pasar el servicio por el parámetro del constructor y así poder utilizarlo
        public SvCategory(MyDbContext myDbContext) //Aquí viene el MyDbContext inyectado desde el proyecto DataAccess

        {
            _myDbContext = myDbContext;
        }

        public Category Add(Category category)
        {
            _myDbContext.Categories.Add(category);
            _myDbContext.SaveChanges();

            return category;
        }

        public List<Category> ListCategories()
        {
            return _myDbContext.Categories.ToList();
        }

        public void Update(Category category)
        {

            Console.WriteLine("Update");
        }

        public void Delete(int id)
        {
            Category categoryFound = _myDbContext.Categories.Where(category => category.Id == id).FirstOrDefault();

            _myDbContext.Categories.Remove(categoryFound);
            _myDbContext.SaveChanges();
        }
    }
}
