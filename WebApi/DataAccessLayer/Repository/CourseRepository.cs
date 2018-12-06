using DomainLayer.Course;
using DataAccessLayer.Base.DataContext;

namespace DataAccessLayer.Repository
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepository
    {
        public CourseRepository(IDataContext dataContext) : base(dataContext)
        {
        }
    }
}
