using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.ChallengeTwo
{
    public class Vehicle
    {
        public Guid VehicleId { get; set; }
        public string LicensePlate { get; set; }
        public string VIN { get; set; }
        public decimal Miles { get; set; }
        public Technician Technician { get; set; }
    }
}
