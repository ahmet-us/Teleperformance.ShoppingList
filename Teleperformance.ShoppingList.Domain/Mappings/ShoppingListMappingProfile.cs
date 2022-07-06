using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teleperformance.ShoppingList.Domain.DTOs;


namespace Teleperformance.ShoppingList.Domain.Mappings
{
    public class ShoppingListMappingProfile : Profile
    {
        public ShoppingListMappingProfile()
        {
            CreateMap<Models.ShoppingList, ShoppingListDto>();
            CreateMap<ShoppingListCreationDto, Models.ShoppingList>();
            CreateMap<ShoppingListUpdateDto, Models.ShoppingList>().ReverseMap();
        }
    }
}
