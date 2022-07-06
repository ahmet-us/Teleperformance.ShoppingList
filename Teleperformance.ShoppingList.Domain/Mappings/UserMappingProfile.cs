using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teleperformance.ShoppingList.Domain.DTOs;
using Teleperformance.ShoppingList.Domain.Models;

namespace Teleperformance.ShoppingList.Domain.Mappings
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserCreationDto, User>();
            CreateMap<UserUpdateDto, User>().ReverseMap();
        }
    }
}
