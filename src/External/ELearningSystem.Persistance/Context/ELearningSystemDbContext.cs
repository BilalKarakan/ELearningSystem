using ELearningSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ELearningSystem.Persistance.Context;

public class ELearningSystemDbContext(DbContextOptions<ELearningSystemDbContext> options) : DbContext(options)
{
    public DbSet<About> Abouts => Set<About>();
    public DbSet<Banner> Banners => Set<Banner>();
    public DbSet<Blog> Blogs => Set<Blog>();
    public DbSet<BlogCategory> BlogCategories => Set<BlogCategory>();
    public DbSet<Contact> Contacts => Set<Contact>();
    public DbSet<Course> Courses => Set<Course>();
    public DbSet<CourseCategory> CourseCategories => Set<CourseCategory>();
    public DbSet<Message> Messages => Set<Message>();
    public DbSet<SocialMedia> SocialMedias => Set<SocialMedia>();
    public DbSet<Subscriber> Subscribers => Set<Subscriber>();
    public DbSet<Testimonial> Testimonials => Set<Testimonial>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ELearningSystem.Persistance.AssemblyReference).Assembly);
        base.OnModelCreating(modelBuilder);
    }

    public override int SaveChanges()
    {
        ChangeTracker.Entries<BaseEntity>().Where(e => e.State == EntityState.Modified).ToList().ForEach(entity =>
        {
            _ = entity.State switch
            {
                EntityState.Modified => entity.Entity.UpdatedDate = DateTime.Now
            };
            entity.Property(x => x.CreatedDate).IsModified = false;
        });

        return base.SaveChanges();
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        ChangeTracker.Entries<BaseEntity>().Where(e => e.State == EntityState.Added).ToList().ForEach(entity =>
        {
            _ = entity.State switch
            {
                EntityState.Added => entity.Entity.CreatedDate = DateTime.Now
            };
        });

        return await base.SaveChangesAsync(cancellationToken);
    }
}
