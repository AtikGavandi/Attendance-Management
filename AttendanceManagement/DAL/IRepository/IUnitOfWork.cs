using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();

        IStudentRepository Students { get; }
    }
}
