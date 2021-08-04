using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.ChallengeFour
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime JoinedOn { get; set; }
        public MessageThread MessageThread { get; set; }
        public UserMessageThread UserMessageThread { get; set; }
    }
}
