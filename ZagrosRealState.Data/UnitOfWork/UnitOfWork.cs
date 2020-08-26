using System;
using System.Collections.Generic;
using System.Text;
using ZagrosRealState.Data.Interface;
using ZagrosRealState.Data.Models.DbContext;

namespace ZagrosRealState.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public void save()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
