using PracticumProject.Common;

namespace PracticumProject.WebAPI.Models
{
    public class UserPostModel:Person
    {
        public string LastName { get; set; }

        public int GenderId { get; set; }

        //health maintenance organization,HMO
        public int HMOId { get; set; }
        public List<ChildPostModel> Children { get; set; }

    }
}
