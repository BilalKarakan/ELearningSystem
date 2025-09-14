using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.MessageFeatures.Queries.GetAllMessage;

public class GetAllMessageQueryHandler(IMessageService _messageService) : IRequestHandler<GetAllMessageQuery, PagedResult<Message>>
{
    public async Task<PagedResult<Message>> Handle(GetAllMessageQuery request, CancellationToken cancellationToken) => await _messageService.GetListAsync(request, cancellationToken);
}
