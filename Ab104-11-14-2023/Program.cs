using Ab104_11_14_2023.DAL;
using Ab104_11_14_2023.Models;
using Ab104_11_14_2023.Services;


namespace EFstep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext context = new();
            StudentService studentService = new();
            #region customStudent

            // string name = Console.ReadLine();
            //  string surname = Console.ReadLine();
            // int avgPoint = int.Parse(Console.ReadLine());
            //Student customStudent = new()
            //{
            //    Name = name,
            //    Surname = surname,
            //    AvgPoint = avgPoint
            //};
            #endregion

            Student student = new()
            {
                Name = "Tofiq",
                Surname = "Nasibli",
                AvgPoint = 100
            };

            studentService.Create(student);
            //studentService.DeleteById(1);
            //studentService.GetById(1);
            //studentService.GetAll();

        }
    }
}