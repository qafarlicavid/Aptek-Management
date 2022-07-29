using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptek_Management.Database.Models
{
    public class Druggists :User
    {
        public string Experience { get; set; }
        public string Education { get; set; }
        public Druggists(string name, string surname, string fin, string experience, string education)
            : base(name, surname, fin)
        {
            Education = education;
            Experience = experience;

        }
    }
}
