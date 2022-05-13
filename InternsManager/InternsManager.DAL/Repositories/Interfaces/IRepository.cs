using InternsManager.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternsManager.DAL.Repositories.Interfaces
{
    public interface IRepository
    {
        Task<Intern> Add(Intern intern);
        Task<Intern> Delete(int id);
        Task<Intern> FindById(int id);
        Task<List<Intern>> GetAll();
        Task<Intern> Update(Intern intern);
    }
}
