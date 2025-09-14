using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.ContactFeatures.Queries.GetOneContact;

public record GetOneContactQuery(string Id) : IRequest<Contact>;
