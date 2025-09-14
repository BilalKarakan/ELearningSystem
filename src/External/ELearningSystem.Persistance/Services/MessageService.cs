using AutoMapper;
using ELearningSystem.Application.Features.MessageFeatures.Commands.CreateMessage;
using ELearningSystem.Application.Features.MessageFeatures.Commands.DeleteMessage;
using ELearningSystem.Application.Features.MessageFeatures.Commands.UpdateMessage;
using ELearningSystem.Application.Features.MessageFeatures.Queries.GetAllMessage;
using ELearningSystem.Application.Features.MessageFeatures.Queries.GetOneMessage;
using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using ELearningSystem.Domain.IRepositories;
using ELearningSystem.Domain.IRepositories.Message;
using Microsoft.EntityFrameworkCore;

namespace ELearningSystem.Persistance.Services;

public class MessageService(IMessageCommandRepository _commandRepository, IMessageQueryRepository _queryRepository, IMapper _mapper) : IMessageService
{
    public async Task CerateAsync(CreateMessageCommand request, CancellationToken cancellationToken) => await _commandRepository.CreateAsync(_mapper.Map<Message>(request), cancellationToken);
    public void Delete(DeleteMessageCommand request, CancellationToken cancellationToken) => _commandRepository.Delete(_mapper.Map<Message>(request), cancellationToken);
    public void Update(UpdateMessageCommand request, CancellationToken cancellationToken) => _commandRepository.Update(_mapper.Map<Message>(request), cancellationToken);
    public async Task<Message> GetByIdAsync(GetOneMessageQuery request, CancellationToken cancellationToken) => await _queryRepository.GetByIdAsync(request.Id, cancellationToken);
    public async Task<PagedResult<Message>> GetListAsync(GetAllMessageQuery request, CancellationToken cancellationToken)
    {
        IQueryable<Message> messages = _queryRepository.GetQueryable();
        if (!string.IsNullOrEmpty(request.Search))
            messages = messages.Where(m => EF.Functions.Like(m.Content, $"%{request.Search}%"));

        int totalCount = await messages.CountAsync();
        List<Message> items = await messages.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToListAsync();
        return new PagedResult<Message>(items, totalCount, request.PageNumber, request.PageSize);
    }
}
