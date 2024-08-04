using Microsoft.EntityFrameworkCore;
using StudentManagmentSystem.DAL.Data;
using StudentManagmentSystem.DAL.Models;
using StudentManagmentSystem.DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagmentSystem.DAL.Repository
{
    public class StudentDbRepository : IStudentRepository
    {
        private readonly CustomDbContext _context;

        public StudentDbRepository(CustomDbContext context)
        {
            _context = context;
        }

        public Student Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public Student DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public Student FindById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students;
        }
    }
}
