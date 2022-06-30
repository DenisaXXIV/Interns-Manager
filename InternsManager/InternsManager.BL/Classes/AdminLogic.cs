using AutoMapper;
using InternsManager.BL.Interfaces;
using InternsManager.DAL.Entities;
using InternsManager.DAL.Repositories.Interfaces;
using InternsManager.TL.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bCrypt = BCrypt.Net.BCrypt;

namespace InternsManager.BL.Classes
{
    public class AdminLogic : IAdminLogic
    {
        private readonly IRepository<Admin> _adminRepository;
        private readonly IMapper _mapper;

        public AdminLogic(IRepository<Admin> adminRepository, IMapper mapper)
        {
            _adminRepository = adminRepository;
            _mapper = mapper;
        }

        public async Task AddAdmin(AdminDTO adminDTO)
        {
            if (adminDTO == null)
            {
                throw new ArgumentNullException(nameof(adminDTO));
            }
            try
            {
                adminDTO.Password = bCrypt.HashPassword(adminDTO.Password);
                var entity = _mapper.Map<Admin>(adminDTO);
                await _adminRepository.Add(entity);
            }
            catch (DbUpdateException)
            {
                throw;
            }
        }

        public async Task<List<AdminDTO>> GetAll()
        {
            var results = _mapper.Map<List<AdminDTO>>(await _adminRepository.GetAll());
            return results;
        }

        public async Task<AdminDTO> GetById(int id)
        {
            AdminDTO result;
            try
            {
                var results = _mapper.Map<List<AdminDTO>>(await _adminRepository.GetAll());
                result = results.FirstOrDefault(a => a.IdAdmin == id);
                if (result == null)
                {
                    throw new DbUpdateException();
                }
                return result;
            }
            catch (DbUpdateException)
            {
                throw;
            }
        }

        public async Task<AdminDTO> GetByUsername(string username)
        {
            AdminDTO result;
            try
            {
                var results = _mapper.Map<List<AdminDTO>>(await _adminRepository.GetAll());
                result = results.FirstOrDefault(a => a.Username == username);
                if (result == null)
                {
                    throw new DbUpdateException();
                }
                return result;
            }
            catch (DbUpdateException)
            {
                throw;
            }
        }

        public async Task<bool> RemoveAdmin(AdminDTO adminDTO)
        {
            if (adminDTO == null)
            {
                throw new ArgumentNullException(nameof(adminDTO));
            }
            try
            {
                await _adminRepository.Delete(adminDTO.IdAdmin);
                return true;
            }
            catch (DbUpdateException)
            {
                throw;
            }
        }

        public async Task<bool> UpdateAdmin(int id, AdminDTO newAdminDTO)
        {
            if (newAdminDTO == null)
            {
                throw new ArgumentNullException(nameof(newAdminDTO));
            }

            Admin oldAdmin = await _adminRepository.FindById(id);

            try
            {
                if (!bCrypt.Verify(newAdminDTO.Password, oldAdmin.Password))
                {
                    newAdminDTO.Password = bCrypt.HashPassword(newAdminDTO.Password);
                }
                var entity = _mapper.Map<Admin>(newAdminDTO);
                await _adminRepository.Delete(oldAdmin.IdAdmin);
                await _adminRepository.Add(entity);
                return true;
            }
            catch (DbUpdateException)
            {
                throw;
            }
        }

        async Task<int> IAdminLogic.VerifyPassword(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }
            try
            {
                List<Admin> admins = await _adminRepository.GetAll();
                int id = 0;

                foreach (var admin in admins)
                {
                    if (bCrypt.Verify(text, admin.Password))
                    {
                        id = admin.IdPerson;
                    }
                }

                return id;
            }
            catch (DbUpdateException)
            {
                throw new ArgumentNullException("Database exception"); ;
            }
        }

        async Task<int> IAdminLogic.VerifyUsername(string username)
        {
            if (username == null)
            {
                throw new ArgumentNullException(nameof(username));
            }
            try
            {
                List<Admin> admins = await _adminRepository.GetAll();
                int id = 0;

                foreach (var admin in admins)
                {
                    if (admin.Username.Equals(username))
                    {
                        id = admin.IdPerson;
                    }
                }

                return id;
            }
            catch (DbUpdateException)
            {
                throw new ArgumentNullException("Database exception"); ;
            }
        }
    }
}
