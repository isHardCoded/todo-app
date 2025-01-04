using AutoMapper;
using ToDoApp.DataAccess.Entities;
using ToDoApp.Messages.Requests;
using ToDoApp.Models;

namespace ToDoApp.Configuration;

public class MapperProfile : Profile
{
    // https://docs.automapper.org/en/stable/Configuration.html
    public MapperProfile()
    {
        CreateMap<TaskRequest, TaskModel>()
            // .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
            .ReverseMap();
        CreateMap<TaskModel, TaskEntity>().ReverseMap();
    }
}