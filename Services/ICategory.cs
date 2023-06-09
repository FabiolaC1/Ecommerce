using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Services
{
    public interface ICategory
    {
        public Category Add(Category category);

        public List<Category> ListCategories();

        public void Update(Category category);
        public void Delete(int id);
    }
}
