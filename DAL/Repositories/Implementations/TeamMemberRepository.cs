using Core.Repositories.Implementations;
using DAL.Repositories.Interfaces;
using Entities.Concrets;

namespace DAL.Repositories.Implementations
{
    public class TeamMemberRepository : TEntityRepository<TeamMember, AppDbContext>, ITeamMemberRepository
    {
        public TeamMemberRepository(AppDbContext context) : base(context) { }
    }
}
