using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Services
{
    public interface IUser
    {
        public User Add(User user);

        public List<User> ListUsers();

        public void Update(User user);
        //public void Delete(int id);
    }
}
