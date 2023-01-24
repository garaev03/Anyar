using Business.Services.Interfaces;
using Entities.Concrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Implementations
{
    public class TeamMemberService : ITeamMemberService
    {
        public Task<List<TeamMember>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TeamMember> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task CreateAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync()
        {
            throw new NotImplementedException();
        }

    }
}
