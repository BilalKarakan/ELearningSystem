using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.TestimonialFeatures.Commands.DeleteTestimonial;

public record DeleteTestimonialCommand(string Id) : IRequest<CommonResponse>;
