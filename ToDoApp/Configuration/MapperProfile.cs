using AutoMapper;
using ToDoApp.DataAccess.Entities;
using ToDoApp.Messages.Requests;

namespace ToDoApp.Configuration;

public class MapperProfile : Profile
{
    // https://docs.automapper.org/en/stable/Configuration.html
    public MapperProfile()
    {
        CreateMap<TaskRequest, TaskEntity>()
            // .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
            .ReverseMap();
    }
}