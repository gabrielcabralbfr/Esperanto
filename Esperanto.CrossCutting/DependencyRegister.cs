using Esperanto.Domain.Repositories;
using Esperanto.Infrastructure.Context;
using Esperanto.Infrastructure.Repositories;
using Esperanto.Infrastructure.UnitOfWork;
using Esperanto.SharedKernel;
using Esperanto.SharedKernel.Events;
using SimpleInjector;

namespace Esperanto.CrossCutting
{
    public class DependencyRegister
    {
        public static void Register(Container container)
        {
            container.Register<StoreDataContext, StoreDataContext>(Lifestyle.Scoped);
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);

            container.Register<IHandler<DomainNotification>, DomainNotificationHandler>(Lifestyle.Scoped);

            container.Register<ICompanyRepository, CompanyRepository>(Lifestyle.Scoped);
            container.Register<ICompanyLogRepository, CompanyLogRepository>(Lifestyle.Scoped);
            container.Register<IProjectFieldRepository, ProjectFieldRepository>(Lifestyle.Scoped);
            container.Register<IProjectIntegrationRepository, ProjectIntegrationRepository>(Lifestyle.Scoped);
            container.Register<IProjectLogRepository, ProjectLogRepository>(Lifestyle.Scoped);
            container.Register<IProjectRepository, ProjectRepository>(Lifestyle.Scoped);
            container.Register<IUserLogRepository, UserLogRepository>(Lifestyle.Scoped);
            container.Register<IUserRepository, UserRepository>(Lifestyle.Scoped);

            //TODO: Register AppService Layer
        }
    }
}
