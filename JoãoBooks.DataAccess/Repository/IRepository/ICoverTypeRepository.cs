using JoãoBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JoãoBooks.DataAccess.Repository.IRepository
{
      public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType covertype);
    }
}
