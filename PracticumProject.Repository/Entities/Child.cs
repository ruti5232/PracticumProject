using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticumProject.Repositories.Entities
{

    public class Child : Person
    {
        private static int IdForAll;

        public Child()
        {
            this.Id = Child.IdForAll++;
        }
        static Child()
        {
            IdForAll = 0;
        }

    }
}
