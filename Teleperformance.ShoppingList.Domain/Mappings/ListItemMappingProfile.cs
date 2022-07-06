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
    public class ListItemMappingProfile : Profile
    {
        public ListItemMappingProfile()
        {
            CreateMap<ListItem, ListItemDto>();
            CreateMap<ListItemCreationDto, ListItem>();

            CreateMap<ListItemUpdateDto, ListItem>().ReverseMap();

        }
    }
}
