using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entidades;

namespace Services
{
    public class SvUser : IUser
    {

        private readonly MyDbContext _myDbContext;

        // Esta es la forma de inyectar nuestro MyDbContext para que el servicio SvUser puede utilizarlo en sus metodos
        // Cuando se inyecta cualquier servicio, interfaz o clase se hace en el constructor de esta manera (Siempre)
        // El contenedor de dependencias sabe que tiene que pasar el servicio por el parámetro del constructor y así poder utilizarlo
        public SvUser(MyDbContext myDbContext) //Aquí viene el MyDbContext inyectado desde el proyecto DataAccess

        {
            _myDbContext = myDbContext;
        }

        public User Add(User user)
        {
            _myDbContext.Users.Add(user);
            _myDbContext.SaveChanges();

            return user;
        }

        public List<User> ListUsers()
        {
            return _myDbContext.Users.ToList();
        }

        public void Update(User user)
        {

            Console.WriteLine("Update");
        }

        //public void Delete(int id)
        //{
        //    User userFound = _myDbContext.Users.Where(user => user.Id == id).FirstOrDefault();

        //    _myDbContext.Users.Remove(userFound);
        //    _myDbContext.SaveChanges();
        //}
    }
}

