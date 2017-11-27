using Esperanto.ApplicationService.Services;
using Esperanto.Domain.Repositories;
using Esperanto.Domain.Services;
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

            container.Register<ICompanyAppService, CompanyAppService>(Lifestyle.Scoped);
            container.Register<ICompanyLogAppService, CompanyLogAppService>(Lifestyle.Scoped);
            container.Register<IProjectFieldAppService, ProjectFieldAppService>(Lifestyle.Scoped);
            container.Register<IProjectIntegrationAppService, ProjectIntegrationAppService>(Lifestyle.Scoped);
            container.Register<IProjectLogAppService, ProjectLogAppService>(Lifestyle.Scoped);
            container.Register<IProjectAppService, ProjectAppService>(Lifestyle.Scoped);
            container.Register<IUserLogAppService, UserLogAppService>(Lifestyle.Scoped);
            container.Register<IUserAppService, UserAppService>(Lifestyle.Scoped);
        }
    }
}
