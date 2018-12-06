
using AutoMapper;
using BusinessLayer.BusinessDto;
using DomainLayer.Course;

namespace InfrastructureLayer.DataMapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Course, CourseDto>();
        }
    }
}
