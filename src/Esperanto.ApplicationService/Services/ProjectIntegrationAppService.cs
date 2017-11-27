using System.Collections.Generic;
using Esperanto.Domain.Commands.ProjectIntegrationCommands;
using Esperanto.Domain.Entities;
using Esperanto.Domain.Services;
using Esperanto.Infrastructure.UnitOfWork;
using Esperanto.Domain.Repositories;

namespace Esperanto.ApplicationService.Services
{
    public class ProjectIntegrationAppService : ApplicationService, IProjectIntegrationAppService
    {

        private IProjectIntegrationRepository _repository;


        public ProjectIntegrationAppService(IUnitOfWork unitOfWork, IProjectIntegrationRepository repository) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public ProjectIntegration Create(CreateProjectIntegrationCommand command)
        {
            var projectIntegration = new ProjectIntegration(command);

            projectIntegration.CreateProjectIntegration(projectIntegration);

            _repository.Create(projectIntegration);

            if (Commit())
            {
                return projectIntegration;
            }

            return null;
        }

        public List<ProjectIntegration> Get()
        {
            return _repository.Get();
        }

        public List<ProjectIntegration> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }
    }
}
