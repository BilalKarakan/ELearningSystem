using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.MessageFeatures.Commands.UpdateMessage;

public class UpdateMessageCommandHandler(IMessageService _messageService) : IRequestHandler<UpdateMessageCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(UpdateMessageCommand request, CancellationToken cancellationToken)
    {
        _messageService.Update(request, cancellationToken);
        return new CommonResponse("Message was updated successfully!");
    }
}
