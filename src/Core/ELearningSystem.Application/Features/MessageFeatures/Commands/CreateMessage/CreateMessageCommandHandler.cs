using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.MessageFeatures.Commands.CreateMessage;

public class CreateMessageCommandHandler(IMessageService _messageService) : IRequestHandler<CreateMessageCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(CreateMessageCommand request, CancellationToken cancellationToken)
    {
        await _messageService.CerateAsync(request, cancellationToken);
        return new CommonResponse("Message was created successfully!");
    }
}
