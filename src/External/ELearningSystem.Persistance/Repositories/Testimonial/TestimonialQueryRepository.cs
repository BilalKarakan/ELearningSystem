using ELearningSystem.Domain.IRepositories.Testimonial;
using ELearningSystem.Persistance.Context;

namespace ELearningSystem.Persistance.Repositories.Testimonial;

public class TestimonialQueryRepository : GenericQueryRepository<Domain.Entities.Testimonial>, ITestimonialQueryRepository
{
    public TestimonialQueryRepository(ELearningSystemDbContext _context) : base(_context)
    {
        
    }
}
