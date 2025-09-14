using AutoMapper;
using ELearningSystem.Application.Features.AboutFeatures.Commands.CreateAbout;
using ELearningSystem.Application.Features.AboutFeatures.Commands.DeleteAbout;
using ELearningSystem.Application.Features.AboutFeatures.Commands.UpdateAbout;
using ELearningSystem.Application.Features.BannerFeatures.Commands.CreateBanner;
using ELearningSystem.Application.Features.BannerFeatures.Commands.DeleteBanner;
using ELearningSystem.Application.Features.BannerFeatures.Commands.UpdateBanner;
using ELearningSystem.Application.Features.BlogCategoryFeatures.Commands.CreateBlogCategory;
using ELearningSystem.Application.Features.BlogCategoryFeatures.Commands.DeleteBlogCategory;
using ELearningSystem.Application.Features.BlogCategoryFeatures.Commands.UpdateBlogCategory;
using ELearningSystem.Application.Features.BlogFeatures.Commands.CreateBlog;
using ELearningSystem.Application.Features.BlogFeatures.Commands.DeleteBlog;
using ELearningSystem.Application.Features.BlogFeatures.Commands.UpdateBlog;
using ELearningSystem.Application.Features.ContactFeatures.Commands.CreateContact;
using ELearningSystem.Application.Features.ContactFeatures.Commands.DeleteContact;
using ELearningSystem.Application.Features.ContactFeatures.Commands.UpdateContact;
using ELearningSystem.Application.Features.CourseCategoryFeatures.Commands.CreateCourseCategory;
using ELearningSystem.Application.Features.CourseCategoryFeatures.Commands.DeleteCourseCategory;
using ELearningSystem.Application.Features.CourseCategoryFeatures.Commands.UpdateCourseCategory;
using ELearningSystem.Application.Features.CourseFeatures.Commands.CreateCourse;
using ELearningSystem.Application.Features.CourseFeatures.Commands.DeleteCourse;
using ELearningSystem.Application.Features.CourseFeatures.Commands.UpdateCourse;
using ELearningSystem.Application.Features.MessageFeatures.Commands.CreateMessage;
using ELearningSystem.Application.Features.MessageFeatures.Commands.DeleteMessage;
using ELearningSystem.Application.Features.MessageFeatures.Commands.UpdateMessage;
using ELearningSystem.Application.Features.SocialMediaFeatures.Commands.CreateSocialMedia;
using ELearningSystem.Application.Features.SocialMediaFeatures.Commands.DeleteSocialMedia;
using ELearningSystem.Application.Features.SocialMediaFeatures.Commands.UpdateSocialMedia;
using ELearningSystem.Application.Features.SubscriberFeatures.Commands.CreateSubscriber;
using ELearningSystem.Application.Features.SubscriberFeatures.Commands.DeleteSubscriber;
using ELearningSystem.Application.Features.SubscriberFeatures.Commands.UpdateSubscriber;
using ELearningSystem.Application.Features.TestimonialFeatures.Commands.CreateTestimonial;
using ELearningSystem.Application.Features.TestimonialFeatures.Commands.DeleteTestimonial;
using ELearningSystem.Application.Features.TestimonialFeatures.Commands.UpdateTestimonial;
using ELearningSystem.Domain.Entities;

namespace ELearningSystem.Persistance.Mapping;

public class MapProfile : Profile
{
    public MapProfile()
    {
        #region About
        CreateMap<CreateAboutCommand, About>().ReverseMap();
        CreateMap<UpdateAboutCommand, About>().ReverseMap();
        CreateMap<DeleteAboutCommand, About>().ReverseMap();
        #endregion

        #region Banner
        CreateMap<CreateBannerCommand, Banner>().ReverseMap();
        CreateMap<DeleteBannerCommand, Banner>().ReverseMap();
        CreateMap<UpdateBannerCommand, Banner>().ReverseMap();
        #endregion

        #region Contact
        CreateMap<CreateContactCommand, Contact>().ReverseMap();
        CreateMap<UpdateContactCommand, Contact>().ReverseMap();
        CreateMap<DeleteContactCommand, Contact>().ReverseMap();
        #endregion

        #region Blog
        CreateMap<CreateBlogCommand, Blog>().ReverseMap();
        CreateMap<UpdateBlogCommand, Blog>().ReverseMap();
        CreateMap<DeleteBlogCommand, Blog>().ReverseMap();
        #endregion

        #region BlogCategory
        CreateMap<CreateBlogCategoryCommand, BlogCategory>().ReverseMap();
        CreateMap<UpdateBlogCategoryCommand, BlogCategory>().ReverseMap();
        CreateMap<DeleteBlogCategoryCommand, BlogCategory>().ReverseMap();
        #endregion

        #region CourseCategory
        CreateMap<CreateCourseCategoryCommand, CourseCategory>().ReverseMap();
        CreateMap<UpdateCourseCategoryCommand, CourseCategory>().ReverseMap();
        CreateMap<DeleteCourseCategoryCommand, CourseCategory>().ReverseMap();
        #endregion

        #region Course
        CreateMap<CreateCourseCommand, Course>().ReverseMap();
        CreateMap<UpdateCourseCommand, Course>().ReverseMap();
        CreateMap<DeleteCourseCommand, Course>().ReverseMap();
        #endregion

        #region Message
        CreateMap<CreateMessageCommand, Message>().ReverseMap();
        CreateMap<UpdateMessageCommand, Message>().ReverseMap();
        CreateMap<DeleteMessageCommand, Message>().ReverseMap();
        #endregion

        #region SocialMedia
        CreateMap<CreateSocialMediaCommand, SocialMedia>().ReverseMap();
        CreateMap<UpdateSocialMediaCommand, SocialMedia>().ReverseMap();
        CreateMap<DeleteSocialMediaCommand, SocialMedia>().ReverseMap();
        #endregion

        #region Subscriber
        CreateMap<CreateSubscriberCommand, Subscriber>().ReverseMap();
        CreateMap<UpdateSubscriberCommand, Subscriber>().ReverseMap();
        CreateMap<DeleteSubscriberCommand, Subscriber>().ReverseMap();
        #endregion

        #region SocialMedia
        CreateMap<CreateTestimonialCommand, Testimonial>().ReverseMap();
        CreateMap<UpdateTestimonialCommand, Testimonial>().ReverseMap();
        CreateMap<DeleteTestimonialCommand, Testimonial>().ReverseMap();
        #endregion
    }
}
