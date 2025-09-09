using ELearningSystem.Domain.IRepositories;
using ELearningSystem.Domain.IRepositories.Testimonial;
using ELearningSystem.Persistance.Context;

namespace ELearningSystem.Persistance.Repositories.Testimonial;

public class TestimonialCommandRepository : GenericCommandRepository<Domain.Entities.Testimonial>, ITestimonialCommandRepository
{
    public TestimonialCommandRepository(ELearningSystemDbContext context, IUnitOfWork _unitOfWork) : base(context, _unitOfWork)
    {
        
    }
}
