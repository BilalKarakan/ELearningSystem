using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.AboutFeatures.Commands.CreateAbout;

public record CreateAboutCommand(string Title, string Description, string ImageUrl, string Item1, string Item2, string Item3, string Item4) : IRequest<CommonResponse>;

