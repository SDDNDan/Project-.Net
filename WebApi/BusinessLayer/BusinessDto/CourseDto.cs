namespace BusinessLayer.BusinessDto
{
    public class CourseDto
    {
        public CourseDto(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
    }
}
