using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptek_Management.Database.Models
{
    public class Owner : User
    {
        public Owner(string name, string surname, string fin)
            : base(name, surname, fin)
        {

        }
    }
}
