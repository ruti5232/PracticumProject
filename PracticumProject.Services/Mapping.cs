using AutoMapper;
using PracticumProject.Common.DTOs;
using PracticumProject.Repositories.Entities;
using PracticumProject.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticumProject.Services
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<UserDTO,User>().ForMember(dest=>dest.LastName,opt=>opt.MapFrom(src=>src.UserLastName)).ReverseMap();
            CreateMap<ChildDTO, Child>().ReverseMap();
        }
    }
}
