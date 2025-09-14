using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.SubscriberFeatures.Commands.CreateSubscriber;

public class CreateSubscriberCommandHandler(ISubscriberService _subscriberService) : IRequestHandler<CreateSubscriberCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(CreateSubscriberCommand request, CancellationToken cancellationToken)
    {
        await _subscriberService.CreateAsync(request, cancellationToken);
        return new CommonResponse("Subscriber was created successfully!");
    }
}
