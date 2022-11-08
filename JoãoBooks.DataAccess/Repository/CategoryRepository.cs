using JoãoBooks.DataAccess.Repository.IRepository;
using JoãoBookStore.DataAccess.Data;
using JoãoBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;





namespace JoãoBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            //throw new NotImplementedException();
            //use .NEt LINQ to retrieve that the first or default category object,
            //then pass the id as a generic entity which matches the category ID

            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if(objFromDb !=null) //save changes if not null
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }

        }
    }

}