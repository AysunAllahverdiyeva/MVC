using AutoMapper;
using ProjectBusinessLogic.Dtos;
using ProjectEntity.Concrete.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBusinessLogic.Mappers
{
    public class MapProfile: Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductViewDto>()
                .ForMember(x => x.Category, y => y.MapFrom(x => x.Category.CategoryName));
               
        }
    }
}
