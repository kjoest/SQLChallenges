using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.ChallengeThree
{
    public class Listing
    {
        public Guid ListingId { get; set; }
        public DateTime DateListed { get; set; }
        public bool IsRental { get; set; }
        public House House { get; set; }
        public Guid HouseId { get; set; }
    }
}
