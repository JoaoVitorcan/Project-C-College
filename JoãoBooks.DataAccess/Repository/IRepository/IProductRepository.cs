using JoãoBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace JoãoBooks.DataAccess.Repository.IRepository
{
     public interface IProductRepository
    {
        void Update(Product product);
    }
}
