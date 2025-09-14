using ELearningSystem.Application.IServices;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.MessageFeatures.Queries.GetOneMessage;

public class GetOneMessageQueryHandler(IMessageService _messageService) : IRequestHandler<GetOneMessageQuery, Message>
{
    public async Task<Message> Handle(GetOneMessageQuery request, CancellationToken cancellationToken) => await _messageService.GetByIdAsync(request, cancellationToken);
}
