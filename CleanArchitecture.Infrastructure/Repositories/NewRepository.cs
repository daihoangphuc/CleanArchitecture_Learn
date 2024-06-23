using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class NewRepository : INewRepository
    {
        public readonly AppDbContext _context;
        public NewRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<New> GetNewByIdAsync(string id)
        {
            return await _context.News.FindAsync(id);
        }
        public async Task<IEnumerable<New>> GetAllNewsAsync()
        {
            return await _context.News.ToListAsync();
        }

        public async Task AddNewAsync(New news)
        {
            _context.News.Add(news);
            await _context.SaveChangesAsync();
        }
   
    }
}
