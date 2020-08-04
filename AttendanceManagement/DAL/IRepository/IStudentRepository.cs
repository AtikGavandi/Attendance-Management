using DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IStudentRepository : IRepository<Student>
    {
        IEnumerable<Student> GetTop2Student(int StudentID);
    }
}
