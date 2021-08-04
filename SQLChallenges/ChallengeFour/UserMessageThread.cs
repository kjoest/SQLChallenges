using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.ChallengeFour
{
    public class UserMessageThread
    {
        public int UserId { get; set; }
        public int MessageThreadId { get; set; }
        public List<User> Users { get; set; }
    }
}
