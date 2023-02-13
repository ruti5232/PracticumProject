using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticumProject.Repositories.Entities
{
    //to check public
    public abstract class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string IdentityNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

    }
}
