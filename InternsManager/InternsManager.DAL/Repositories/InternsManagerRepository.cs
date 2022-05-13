using InternsManager.DAL.Entities;
using InternsManager.DAL.Migrations;
using InternsManager.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternsManager.DAL.Repositories
{
    public class InternsManagerRepository : IRepository
    {
        private readonly ApplicationDbContext _context;

        public InternsManagerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Intern> Add(Intern intern)
        {
            if (intern != null)
            {
                _context.Set<Intern>().Add(intern);
                await _context.SaveChangesAsync();
                return intern;
            }
            throw new DbUpdateException();
        }

        public async Task<Intern> Delete(int id)
        {
            Intern intern = await _context.Set<Intern>().FindAsync(id);
            if (intern == null)
            {
                return null;
            }
            try
            {
                _context.Set<Intern>().Remove(intern);
                await _context.SaveChangesAsync();
                return intern;
            }
            catch (DbUpdateException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Intern> FindById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException(nameof(id));
            }
            var result = await _context.Set<Intern>().FindAsync(id);
            if (result != null)
            {
                return result;
            }
            throw new DbUpdateException();
        }

        public async Task<List<Intern>> GetAll()
        {
            return await _context.Set<Intern>().ToListAsync();
        }



        public async Task<Intern> Update(Intern intern)
        {
            if (intern == null)
            {
                throw new ArgumentNullException(nameof(intern));
            }
            try
            {
                _context.Entry(intern).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return intern;
            }
            catch (DbUpdateException)
            {
                throw;
            }
        }
    }
}
