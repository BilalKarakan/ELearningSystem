using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.ContactFeatures.Commands.DeleteContact;

public record DeleteContactCommand(string Id) : IRequest<CommonResponse>;
