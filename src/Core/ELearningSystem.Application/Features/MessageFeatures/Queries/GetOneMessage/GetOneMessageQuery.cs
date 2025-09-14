using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.MessageFeatures.Queries.GetOneMessage;

public record GetOneMessageQuery(string Id) : IRequest<Message>;
