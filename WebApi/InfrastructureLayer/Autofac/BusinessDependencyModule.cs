using Autofac;
using BusinessLayer;
using BusinessLayer.BusinessContract;

namespace InfrastructureLayer.Autofac
{
    public class BusinessDependecyModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CourseAppService>().As<ICourseAppService>();
        }
    }
}
