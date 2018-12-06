using System;
using DomainLayer.Base.EntityBase;

namespace DomainLayer.Course
{
    public class Course : EntityBase<Guid>
    {
        public Course(string name)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
        }
        public string Name { get; private set; }
    }
}
