using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticumProject.Repositories.Entities
{
    public class User : Person
    {
        //private static int IdForAll;
        public string LastName { get; set; }

        public int GenderId { get; set; }

        //health maintenance organization,HMO
        public int HMOId { get; set; }

        public List<Child> Children { get; set; }

    }
}
