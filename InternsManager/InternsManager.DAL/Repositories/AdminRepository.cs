using InternsManager.DAL.Entities;
using InternsManager.DAL.Migrations;
using InternsManager.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bCrypt = BCrypt.Net.BCrypt;

namespace InternsManager.DAL.Repositories
{
    public class AdminRepository : IRepository<Admin>
    {
        private readonly ApplicationDbContext _context;

        public AdminRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Admin> Add(Admin entity)
        {
            if (entity != null)
            {
                _context.Set<Admin>().Add(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            throw new DbUpdateException();
        }

        public async Task<Admin> AddAdmin(Admin entity)
        {
            if (entity != null)
            {
                entity.Password = bCrypt.HashPassword(entity.Password).ToString();
                _context.Set<Admin>().Add(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            throw new DbUpdateException();
        }


        public async Task<Admin> Delete(int id)
        {
            Admin entity = await _context.Set<Admin>().FindAsync(id);
            if (entity == null)
            {
                return null;
            }
            try
            {
                _context.Set<Admin>().Remove(entity);
                await _context.SaveChangesAsync();
                return entity;
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

        public async Task<Admin> FindById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException(nameof(id));
            }
            var result = await _context.Set<Admin>().FindAsync(id);
            if (result != null)
            {
                return result;
            }
            throw new DbUpdateException();
        }

        public async Task<List<Admin>> GetAll()
        {
            return await _context.Set<Admin>().ToListAsync();
        }



        public async Task<Admin> Update(Admin entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (DbUpdateException)
            {
                throw;
            }
        }
    }
}
