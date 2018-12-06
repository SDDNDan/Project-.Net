using BusinessLayer.BusinessDto;
using DomainLayer.Course;

namespace BusinessLayer.DataMappers.ToDomain
{
    internal static class DataMapper
    {
        internal static Course ToDomain(this CourseDto courseDto)
        {
            return new Course(courseDto.Name);
        }
            
    }
}
