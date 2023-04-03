using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab9EF
{
    public static class Operations
    {
        public static void Insert(string _studentName, List<Class> _studentClasses, int _age)
        {

            using (Context context = new Context())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.students.Add(new Student()
                        {
                            StudentName = _studentName,
                            StudentClasses = _studentClasses,
                            StudentAge = _age
                        });
                        context.SaveChanges();
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }
        public static void UpdateName(string nameToChange, string NameReplacement)
        {
            try
            {
                using Context context = new Context();

                var myclasses = context
                    .students
                    .Where(x => x.StudentName == nameToChange);

                foreach (var student in myclasses)
                {
                    student.StudentName = nameToChange;
                    break;
                }
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public static void DeleteClass(int ID)
        {
            using (Context context = new Context())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        var entityToDelete = context.classes.Find(ID);
                        if (entityToDelete != null)
                        {
                            context.Remove(entityToDelete);
                            context.SaveChanges();
                            tran.Commit();
                        }
                        else
                        {
                            tran.Rollback();
                        }
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        Console.WriteLine(ex.Message.ToString());
                    }
                }
            }

        }

        public static void SelectAllStudents()
        {
            using (var context = new Context())
            {
                var allStudents = context.students.FromSql(FormattableStringFactory.Create("SELECT * FROM students")).ToList();
                foreach (var el in allStudents)
                {
                    Console.WriteLine(el.ToString());
                }
            }
        }

        public static void SelectAllClasses()
        {
            using (var context = new Context())
            {
                var all_stud = context.classes.Select(x => x);
                foreach (var student in all_stud)
                {
                    Console.WriteLine(student.ToString());
                }
            }
        }
        public static void SortStudents(string kindOfSort)
        {
            using var context = new Context();
            switch (kindOfSort)
            {
                case "Name":
                    {
                        var allStudents = context.students.FromSql(FormattableStringFactory.Create("SELECT * FROM students order by StudentName")).ToList();
                        foreach (var el in allStudents)
                        {
                            Console.WriteLine(el.ToString());
                        }
                        break;
                    }
                case "Id":
                    {
                        var allStudents = context.students.FromSql(FormattableStringFactory.Create("SELECT * FROM students order by StudentId")).ToList();
                        foreach (var el in allStudents)
                        {
                            Console.WriteLine(el.ToString());
                        }
                        break;
                    }
                case "Age":
                    {
                        var allStudents = context.students.FromSql(FormattableStringFactory.Create("SELECT * FROM students order by StudentAge")).ToList();
                        foreach (var el in allStudents)
                        {
                            Console.WriteLine(el.ToString());
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Incorrect parameter\nTry \"Name\", \"Id\" or \"Age\"");
                        break;
                    }
            }
        }

        public static async Task Repos_Select()
        {
            using (var unitOfWork = new UnitOfWork(new Context()))
            {
                var students = await unitOfWork.Students.GetAllAsync();

                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
            }
        }
        public static async Task Repos_Select_Classes()
        {
            using (var unitOfWork = new UnitOfWork(new Context()))
            {
                var classes = await unitOfWork.Classes.GetAllAsync();

                foreach (var _clas in classes)
                {
                    Console.WriteLine(_clas);
                }
            }
        }

        public static async Task Repos_Insert_Students(string _name, int _age, List<Class> _classes)
        {
            using (var unitOfWork = new UnitOfWork(new Context()))
            {
                try
                {
                    var newStudent = new Student
                    {
                        StudentName = _name,
                        StudentAge = 15,
                        StudentClasses = _classes
                    };

                    unitOfWork.Students.AddAsync(newStudent);
                    await unitOfWork.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }
        }
    }
}





/*           var unitOfWork = new UnitOfWork(new Context());

            // Получение всех студентов

            // Получение всех студентов
            var students = await unitOfWork.Students.GetAllAsync();

            // Добавление студента
            var student = new Student { StudentName = "John Doe", StudentAge = 20 };
            await unitOfWork.Students.AddAsync(student);
            await unitOfWork.SaveChangesAsync();

            // Изменение студента
            student.StudentName = "Jane Doe";
            await unitOfWork.Students.UpdateAsync(student);
            await unitOfWork.SaveChangesAsync();

            // Удаление студента
            await unitOfWork.Students.DeleteAsync(student);
            await unitOfWork.SaveChangesAsync();

            // Освобождение ресурсов
            unitOfWork.Dispose();*/