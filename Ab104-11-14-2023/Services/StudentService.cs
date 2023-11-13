using Ab104_11_14_2023.DAL;
using Ab104_11_14_2023.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab104_11_14_2023.Services
{
    internal class StudentService
    {
        private readonly AppDbContext _context = new();

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }
        public void Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public Student GetById(int id)
        {
            return _context.Students.FirstOrDefault(s => s.Id == id);
        }

        public void DeleteById(int id)
        {
            Student studentDelete = GetById(id);

            if (studentDelete != null)
            {
                _context.Students.Remove(studentDelete);
                _context.SaveChanges();
            }
        }
    }
}
