using ELearningSystem.Application.IServices;
using ELearningSystem.Domain.IRepositories;
using ELearningSystem.Domain.IRepositories.About;
using ELearningSystem.Domain.IRepositories.Banner;
using ELearningSystem.Domain.IRepositories.Blog;
using ELearningSystem.Domain.IRepositories.BlogCategory;
using ELearningSystem.Domain.IRepositories.Contact;
using ELearningSystem.Domain.IRepositories.Course;
using ELearningSystem.Domain.IRepositories.CourseCategory;
using ELearningSystem.Domain.IRepositories.Message;
using ELearningSystem.Domain.IRepositories.SocialMedia;
using ELearningSystem.Domain.IRepositories.Subscriber;
using ELearningSystem.Domain.IRepositories.Testimonial;
using ELearningSystem.Persistance.Context;
using ELearningSystem.Persistance.Repositories;
using ELearningSystem.Persistance.Repositories.About;
using ELearningSystem.Persistance.Repositories.Banner;
using ELearningSystem.Persistance.Repositories.Blog;
using ELearningSystem.Persistance.Repositories.BlogCategory;
using ELearningSystem.Persistance.Repositories.Contact;
using ELearningSystem.Persistance.Repositories.Course;
using ELearningSystem.Persistance.Repositories.CourseCategory;
using ELearningSystem.Persistance.Repositories.Message;
using ELearningSystem.Persistance.Repositories.SocialMedia;
using ELearningSystem.Persistance.Repositories.Subscriber;
using ELearningSystem.Persistance.Repositories.Testimonial;
using ELearningSystem.Persistance.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddApplicationPart(typeof(ELearningSystem.Presentantion.AssemblyReference).Assembly);
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ELearningSystemDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), b => b.MigrationsAssembly("ELearningSystem.Persistance"));
});

#region Repositories and Unit of Work Injection

builder.Services.AddScoped(typeof(IGenericCommandRepository<>), typeof(GenericCommandRepository<>));
builder.Services.AddScoped(typeof(IGenericQueryRepository<>), typeof(GenericQueryRepository<>));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IAboutCommandRepository, AboutCommandRepository>();
builder.Services.AddScoped<IAboutQueryRepository, AboutQueryRepository>();

builder.Services.AddScoped<IBannerCommandRepository, BannerCommandRepository>();
builder.Services.AddScoped<IBannerQueryRepository, BannerQueryRepository>();

builder.Services.AddScoped<IBlogCommandRepository, BlogCommandRepository>();
builder.Services.AddScoped<IBlogQueryRepository, BlogQueryRepository>();

builder.Services.AddScoped<IBlogCategoryCommandRepository, BlogCategoryCommandRepository>();
builder.Services.AddScoped<IBlogCategoryQueryRepository, BlogCategoryQueryRepository>();

builder.Services.AddScoped<IContactCommandRepository, ContactCommandRepository>();
builder.Services.AddScoped<IContactQueryRepository, ContactQueryRepository>();

builder.Services.AddScoped<ICourseCommandRepository, CourseCommandRepository>();
builder.Services.AddScoped<ICourseQueryRepository, CourseQueryRepository>();

builder.Services.AddScoped<ICourseCategoryCommandRepository, CourseCategoryCommandRepository>();
builder.Services.AddScoped<ICourseCategoryQueryRepository, CourseCategoryQueryRepository>();

builder.Services.AddScoped<IMessageCommandRepository, MessageCommandRepository>();
builder.Services.AddScoped<IMessageQueryRepository, MessageQueryRepository>();

builder.Services.AddScoped<ISocialMediaCommandRepository, SocialMediaCommandRepository>();
builder.Services.AddScoped<ISocialMediaQueryRepository, SocialMediaQueryRepository>();

builder.Services.AddScoped<ISubscriberCommandRepository, SubscriberCommandRepository>();
builder.Services.AddScoped<ISubscriberQueryRepository, SubscriberQueryRepository>();

builder.Services.AddScoped<ITestimonialCommandRepository, TestimonialCommandRepository>();
builder.Services.AddScoped<ITestimonialQueryRepository, TestimonialQueryRepository>();
#endregion

#region Services Injection
builder.Services.AddScoped<IAboutService, AboutService>();
#endregion

builder.Services.AddAutoMapper(typeof(ELearningSystem.Persistance.AssemblyReference).Assembly);
builder.Services.AddMediatR(cfr => cfr.RegisterServicesFromAssembly(typeof(ELearningSystem.Application.AssemblyReference).Assembly));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
