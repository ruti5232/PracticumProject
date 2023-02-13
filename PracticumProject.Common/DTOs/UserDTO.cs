using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticumProject.Common.DTOs
{
    public class UserDTO:Person
    {
        public string UserLastName { get; set; }

        public int GenderId { get; set; }

        //health maintenance organization,HMO
        public int HMOId { get; set; }
        public List<ChildDTO> Children { get; set; }
    }
}
