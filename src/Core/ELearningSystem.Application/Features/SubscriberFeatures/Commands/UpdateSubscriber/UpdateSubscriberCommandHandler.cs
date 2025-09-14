using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.SubscriberFeatures.Commands.UpdateSubscriber;

public class UpdateSubscriberCommandHandler(ISubscriberService _subscriberService) : IRequestHandler<UpdateSubscriberCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(UpdateSubscriberCommand request, CancellationToken cancellationToken)
    {
        _subscriberService.Update(request, cancellationToken);
        return new CommonResponse("Subscriber was updated successfully!");
    }
}
