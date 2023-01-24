using DAL.Repositories.Interfaces;
using Entities.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Interfaces
{
    public interface ITeamMemberService
    {
        Task<List<TeamMember>> GetAllAsync();
        Task<TeamMember> GetByIdAsync(int id);
        Task CreateAsync();
        Task DeleteAsync();
    }
}
