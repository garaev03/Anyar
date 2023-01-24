using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrets
{
    public class TeamMember
    {
        public int Id {get;set;}    
        public string Name { get; set; }
        public string Position { get; set; }
        public string Description { get; set; } 
        public string Image { get; set; }
        public bool IsDeleted { get; set; } 
         
        public List<TeamMemberSocialMedia> SocialMedias { get; set; }
        public TeamMember()
        {
            SocialMedias = new();
        }
    }
}
