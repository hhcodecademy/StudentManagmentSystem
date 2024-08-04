using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagmentSystem.DAL.Models;

namespace StudentManagmentSystem.DAL.Repository.Interface
{
    public interface IStudentRepository
    {
        public IEnumerable<Student> GetAll();
        public Student FindById(string id);
        public Student Add(Student student);
        public Student DeleteById(string id);
    }
}
