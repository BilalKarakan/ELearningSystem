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
}
