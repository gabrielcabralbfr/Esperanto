using System.Collections.Generic;
using Esperanto.Domain.Commands.ProjectCommands;
using Esperanto.Domain.Entities;
using Esperanto.Domain.Services;
using Esperanto.Infrastructure.UnitOfWork;
using Esperanto.Domain.Repositories;

namespace Esperanto.ApplicationService.Services
{
    public class ProjectAppService : ApplicationService, IProjectAppService
    {
        #region Properties

        private IProjectRepository _repository;

        #endregion

        public ProjectAppService(IUnitOfWork unitOfWork, IProjectRepository repository) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public Project Create(CreateProjectCommand command)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(DeleteProjectCommand command)
        {
            throw new System.NotImplementedException();
        }

        public Project Update(UpdateProjectCommand command)
        {
            throw new System.NotImplementedException();
        }

        public List<Project> Get()
        {
            throw new System.NotImplementedException();
        }

        public List<Project> Get(int skip, int take)
        {
            throw new System.NotImplementedException();
        }


    }
}
