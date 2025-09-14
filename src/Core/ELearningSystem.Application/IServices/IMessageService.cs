using ELearningSystem.Application.Features.MessageFeatures.Commands.CreateMessage;
using ELearningSystem.Application.Features.MessageFeatures.Commands.DeleteMessage;
using ELearningSystem.Application.Features.MessageFeatures.Commands.UpdateMessage;
using ELearningSystem.Application.Features.MessageFeatures.Queries.GetAllMessage;
using ELearningSystem.Application.Features.MessageFeatures.Queries.GetOneMessage;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;

namespace ELearningSystem.Application.IServices;

public interface IMessageService
{
    Task CerateAsync(CreateMessageCommand request, CancellationToken cancellationToken);
    void Delete(DeleteMessageCommand request, CancellationToken cancellationToken);
    void Update(UpdateMessageCommand request, CancellationToken cancellationToken);
    Task<Message> GetByIdAsync(GetOneMessageQuery request, CancellationToken cancellationToken);
    Task<PagedResult<Message>> GetListAsync(GetAllMessageQuery request, CancellationToken cancellationToken);
}
