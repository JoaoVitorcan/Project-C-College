using JoãoBooks.DataAccess.Repository.IRepository;
using JoãoBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace JoãoBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork        //make the method public to acsess the class


    {
        private readonly ApplicationDbContext _db;   //the using statement
        public UnitOfWork(ApplicationDbContext db)  // constructor to use ID and inject in to the repositories
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }
        public ICategoryRepository Category { get; private set; }            //throw new NotImplementedException();

        public ISP_Call SP_Call { get; private set; }     //throw new NotImplementedException();

        public void Dispose()
        {
            _db.Dispose();
        }
        public void Save()   //all changes will be saved when the Save method is called at the "parent" level
        {
            _db.SaveChanges();
        }

    }

  
   

}
