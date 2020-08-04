using DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DBEntities db;
        public UnitOfWork(DBEntities context)
        {
            db = context;
            //Customers = new CustomerRepository(context);
        }

        //public ICustomerRepository Customers { get;}

        private IStudentRepository _Students;
        public IStudentRepository Students
        {
            get
            {
                if (this._Students == null)
                {
                    this._Students = new StudentRepository(db);
                }
                return this._Students;
            }
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
