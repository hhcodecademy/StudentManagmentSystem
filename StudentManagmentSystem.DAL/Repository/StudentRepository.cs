using StudentManagmentSystem.DAL.Models;
using StudentManagmentSystem.DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagmentSystem.DAL.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private List<Student> _students;

        public StudentRepository()
        {
            _students = new List<Student>();
            _students.Add(new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Rustem",
                Surname = "Cebrayilov",
                Email = "r@gmail.com"

            });
            _students.Add(new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Nermin",
                Surname = "Abbaszade",
                Email = "n@gmail.com"

            });
            _students.Add(new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Turan",
                Surname = "Heyderli",
                Email = "t@gmail.com"

            });
        }

        public Student Add(Student student)
        {
            student.Id = Guid.NewGuid();

            if (_students is not null)
            {
                _students.Add(student);
            }
            return student;

        }
        public IEnumerable<Student> GetAll()
        {
            return _students;
        }

        public Student DeleteById(string id)
        {
            var student = _students.Find(x => x.Id == Guid.Parse(id));
            _students.Remove(student);
            return student;
        }

        public Student FindById(string id)
        {
            return _students.Find(x => x.Id == Guid.Parse(id));

        }


       
    }
}
