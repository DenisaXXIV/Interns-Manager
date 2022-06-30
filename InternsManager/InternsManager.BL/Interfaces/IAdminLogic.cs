using InternsManager.TL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternsManager.BL.Interfaces
{
    public interface IAdminLogic
    {
        Task AddAdmin(AdminDTO adminDTO);
        Task<int> VerifyPassword(string text);
        Task<int> VerifyUsername(string username);
        Task<List<AdminDTO>> GetAll();
        Task<AdminDTO> GetById(int id);
        Task<AdminDTO> GetByUsername(string username);
        Task<bool> RemoveAdmin(AdminDTO adminDTO);
        Task<bool> UpdateAdmin(int id, AdminDTO adminDTO);
    }
}
