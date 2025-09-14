using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.MessageFeatures.Commands.DeleteMessage;

public class DeleteMessageCommandHandler(IMessageService _messageService) : IRequestHandler<DeleteMessageCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(DeleteMessageCommand request, CancellationToken cancellationToken)
    {
        _messageService.Delete(request, cancellationToken);
        return new CommonResponse("Message was removed successfully.");
    }
}
