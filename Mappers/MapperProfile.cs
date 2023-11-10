using AutoMapper;
using AutoMapperUse.Homework.Dto;
using AutoMapperUse.Homework.Models;

namespace AutoMapperUse.Homework.Mappers;

public class MapperProfile :Profile
{
    public MapperProfile()
    {
        CreateMap<Person,PersonDto>();
        CreateMap<PersonDto, Person>();
    }
}
