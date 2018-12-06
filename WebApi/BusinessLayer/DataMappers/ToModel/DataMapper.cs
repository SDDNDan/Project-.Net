using BusinessLayer.BusinessDto;
using DomainLayer.Course;

namespace BusinessLayer.DataMappers.ToModel
{
    internal static class DataMapper
    {
        internal static CourseDto ToModel(this Course course)
        {
            return new CourseDto(course.Name);
        }
    }
}
