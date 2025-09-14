using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.TestimonialFeatures.Commands.UpdateTestimonial;

public record UpdateTestimonialCommand(string Id, string Name, string Title, string Comment, string ImageUrl, int Star) : IRequest<CommonResponse>;
