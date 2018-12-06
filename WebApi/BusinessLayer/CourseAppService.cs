using AutoMapper;
using BusinessLayer.Base;
using BusinessLayer.BusinessContract;
using BusinessLayer.BusinessDto;
using BusinessLayer.DataMappers.ToDomain;
using DomainLayer.Base;
using DomainLayer.Course;

namespace BusinessLayer
{
    public class CourseAppService : AppServiceBase, ICourseAppService
    {
        private readonly ICourseRepository courseRepository;

        public CourseAppService(IUnitOfWork unitOfWork, ICourseRepository courseRepository) : base(unitOfWork)
        {
            this.courseRepository = courseRepository;
        }

        public void Add(CourseDto courseDto)
        {
            this.courseRepository.Add(courseDto.ToDomain());
            this.UnitOfWork.Commit();
        }
    }
}
