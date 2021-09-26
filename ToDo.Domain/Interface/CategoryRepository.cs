using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities;

namespace ToDo.Domain.Interface
{
    public interface CategoryRepository
    {
        IEnumerable<Category> GetAll();
    }
}
