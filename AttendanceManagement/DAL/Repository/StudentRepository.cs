using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{

    public class StudentRepository : Repository<Student>, IStudentRepository
    {     
        public StudentRepository(DBEntities context) : base(context) { }
        public DBEntities DBEntities
        {
            get
            {
                return db as DBEntities;
            }
        }
        public IEnumerable<Student> GetTop2Student(int StudentID)
        {
            try
            {
                return DBEntities.Students.Take(2).ToList();
            }
            catch (Exception EX)
            {
                return null;
            }

        }
 
    }

}



