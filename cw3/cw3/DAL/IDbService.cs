using System.Collections;
using System.Collections.Generic;
using cw3.Models;

namespace cw3.DAL
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}