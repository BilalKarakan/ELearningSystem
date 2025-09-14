using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.ContactFeatures.Commands.UpdateContact;

public record UpdateContactCommand(string Id, string MapUrl, string Address, string Email, string Phone) : IRequest<CommonResponse>;
