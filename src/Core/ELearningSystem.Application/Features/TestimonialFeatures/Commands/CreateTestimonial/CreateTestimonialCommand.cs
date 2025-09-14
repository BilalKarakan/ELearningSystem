using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.TestimonialFeatures.Commands.CreateTestimonial;

public record CreateTestimonialCommand(string Name, string Title, string Comment, string ImageUrl) : IRequest<CommonResponse>;
