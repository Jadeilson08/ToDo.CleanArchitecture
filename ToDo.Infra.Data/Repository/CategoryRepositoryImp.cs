using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities;
using ToDo.Domain.Interface;
using ToDo.Infra.Data.Context;

namespace ToDo.Infra.Data.Repository
{
    public class CategoryRepositoryImp : CategoryRepository
    {
        private readonly ApiDbContext _context;

        public CategoryRepositoryImp(ApiDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAll()
        {
            var categories = _context.Categories;

            return categories;
        }
    }
}
