using JoãoBooks.DataAccess.Repository.IRepository;
using JoãoBooks.Models;
using JoãoBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JoãoBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        /*
                public object GetAll()
                {
                    throw new NotImplementedException();
                }*/



        public void Update(CoverType covertype)
        {
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == covertype.Id);
            if (objFromDb != null)//Save changes if not null
            {
                objFromDb.Name = covertype.Name;
                //_db.SaveChanges();
                //_unitOfWork.save();
            }
            throw new NotImplementedException();
        }

       // public void Update(CoverTypeRepository covertype)
       // {
            //throw new NotImplementedException();
            //use .NET LINQ to retrieve the first or default category object
            // then pass the id as a generic entity which matters the category ID
           
       // }

        /* public void Update(CoverTypeRepository covertype)
         {
             throw new NotImplementedException();
         }

         /* public void Update(CoverType CoverType)
          {
              throw new NotImplementedException();
          }*/
    }
}
