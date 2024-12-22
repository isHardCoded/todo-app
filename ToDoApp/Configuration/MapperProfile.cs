using AutoMapper;
using Microsoft.AspNetCore.Identity;
using ToDoApp.Messages.Requests;
using Task = ToDoApp.DataAccess.Task;

namespace ToDoApp.Configuration;

public class MapperProfile : Profile
{
    // https://docs.automapper.org/en/stable/Configuration.html
    public MapperProfile()
    {
        CreateMap<TaskRequest, Task>()
            // .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
            .ReverseMap();
    }
}