using Autofac;
using DataAccessLayer.Base;
using DataAccessLayer.Base.DataContext;
using DataAccessLayer.Repository;
using DomainLayer.Base;
using DomainLayer.Course;

namespace InfrastructureLayer.Autofac
{
    public class DataAccessDependencyModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<DataContext>().As<IDataContext>().InstancePerLifetimeScope();

            builder.RegisterType<CourseRepository>().As<ICourseRepository>().InstancePerLifetimeScope();
        }
    }
}
