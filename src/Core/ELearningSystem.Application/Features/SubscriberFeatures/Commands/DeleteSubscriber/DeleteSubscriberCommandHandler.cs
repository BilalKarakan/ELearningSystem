using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.SubscriberFeatures.Commands.DeleteSubscriber;

public class DeleteSubscriberCommandHandler(ISubscriberService _subscriberService) : IRequestHandler<DeleteSubscriberCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(DeleteSubscriberCommand request, CancellationToken cancellationToken)
    {
        _subscriberService.Delete(request, cancellationToken);
        return new CommonResponse("Subscriber was removed successfully!");
    }
}
