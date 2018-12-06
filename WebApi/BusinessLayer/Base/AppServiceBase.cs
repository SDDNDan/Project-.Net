using DomainLayer.Base;

namespace BusinessLayer.Base
{
    public abstract class AppServiceBase
    {
        public readonly IUnitOfWork UnitOfWork;

        protected AppServiceBase(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
    }
}
