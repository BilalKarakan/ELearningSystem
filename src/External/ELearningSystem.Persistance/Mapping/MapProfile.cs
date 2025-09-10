using AutoMapper;
using ELearningSystem.Application.Features.AboutFeatures.Commands.CreateAbout;
using ELearningSystem.Application.Features.AboutFeatures.Commands.DeleteAbout;
using ELearningSystem.Application.Features.AboutFeatures.Commands.UpdateAbout;
using ELearningSystem.Domain.Entities;

namespace ELearningSystem.Persistance.Mapping;

public class MapProfile : Profile
{
    public MapProfile()
    {
        #region About
        CreateMap<CreateAboutCommand, About>().ReverseMap();
        CreateMap<UpdateAboutCommand, About>().ReverseMap();
        CreateMap<DeleteAboutCommand, About>().ReverseMap();
        #endregion
    }
}
