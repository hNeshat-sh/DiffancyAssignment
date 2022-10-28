using AutoMapper;
using DiffancyAssignment.Dto;

namespace DiffancyAssignment.Mapper
{
    public class Config : Profile
    {
        public Config()
        {
            CreateMap<InputDto, OutputDto>();
        }

    }
}