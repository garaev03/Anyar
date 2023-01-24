using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrets
{
    public class TeamMemberSocialMedia
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public int TeamMemberId { get; set; }
        public TeamMember TeamMember { get; set; }
    }
}
