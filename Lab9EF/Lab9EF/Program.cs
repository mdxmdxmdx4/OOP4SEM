
using Azure;
using System.Collections.Generic;

namespace Lab9EF
{
    public class Program
    {
        public static async Task MainAsync()
        {
            using (var unitOfWork = new UnitOfWork(new Context()))
            {
                // создание и сохранение нового студента
                var newStudent = new Student
                {
                    StudentName = "George",
                    StudentAge = 20,
                    StudentClasses = new List<Class>() {
                    new Class()
                    {
                        ClassLanguage = Language.English,
                        ClassName = "Finance Adjustment",
                        MaxClassSize = 12
                    }
                    }
            
                };

                unitOfWork.Students.AddAsync(newStudent);
                await unitOfWork.SaveChangesAsync();

                // выборка всех студентов
                var students = await unitOfWork.Students.GetAllAsync();

                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
            }
        }
        public static void Main(){
/*
            Class c1 = new Class();
            c1.ClassLanguage = Language.English;
            c1.MaxClassSize = 25;
            c1.ClassName = "Test";
            Class c2 = new Class();
            c2.ClassLanguage = Language.Belorussian;
            c2.MaxClassSize = 15;
            c2.ClassName = "TestX2";
            List<Class> list = new List<Class>();
            list.Add(c1);
            list.Add(c2);
            Operations.Insert("Gaben", list, 21);*/

            /*Operations.UpdateName("Alfredo", "Mike");*/

            /*            Operations.DeleteClass(2);*/

          /*  Operations.SelectAllClasses();
            Console.WriteLine("\n\n");
            Operations.SelectAllStudents();
            Console.WriteLine("\n\n");
            Console.WriteLine("--------");
            Operations.SortStudents("Name");
            Console.WriteLine("--------");
            Operations.SortStudents("Age");
            Console.WriteLine("--------");
            Operations.SortStudents("Id");
            Console.WriteLine("--------");*/


            /*            MainAsync().GetAwaiter().GetResult();*/

/*            Operations.Repos_Select().GetAwaiter().GetResult();

            Operations.Repos_Insert_Students("Josh", 19, new List<Class>(){new Class() { ClassLanguage = Language.Russian,
            ClassName = "Russian Language Learning", MaxClassSize = 28
            } }).GetAwaiter().GetResult();

            Operations.Repos_Select().GetAwaiter().GetResult();*/
        }
    }
}