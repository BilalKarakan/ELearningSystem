using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.ContactFeatures.Commands.CreateContact;

public record CreateContactCommand(string MapUrl, string Address, string Email, string Phone) : IRequest<CommonResponse>;
