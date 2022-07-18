using AutoMapper;
using posexampleapi.Data.Entities;
using posexampleapi.Models;

namespace posexampleapi;

public class MappingsProfile : Profile
{

    public MappingsProfile()
    {
        CreateMap<ProductsDTO, ProductsEntity>();
        CreateMap<ProductsEntity, ProductsDTO>();
    }

}