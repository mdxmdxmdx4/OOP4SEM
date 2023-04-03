using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        private IRepository<Student> _students;
        private IRepository<Class> _classes;

        public UnitOfWork(DbContext context)
        {
            _context = context;
        }

        public IRepository<Student> Students
        {
            get { return _students ??= new Repository<Student>(_context); }
        }

        public IRepository<Class> Classes
        {
            get { return _classes ??= new Repository<Class>(_context); }
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
