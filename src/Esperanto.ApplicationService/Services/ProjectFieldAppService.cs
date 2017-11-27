using System;
using System.Collections.Generic;
using Esperanto.Domain.Commands.ProjectFieldCommands;
using Esperanto.Domain.Entities;
using Esperanto.Domain.Services;
using Esperanto.Infrastructure.UnitOfWork;
using Esperanto.Domain.Repositories;

namespace Esperanto.ApplicationService.Services
{
    public class ProjectFieldAppService : ApplicationService, IProjectFieldAppService
    {
        private IProjectFieldRepository _repository;

        public ProjectFieldAppService(IUnitOfWork unitOfWork, IProjectFieldRepository repository) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public ProjectField Create(CreateProjectFieldCommand command)
        {
            var projectField = new ProjectField(command);

            projectField.CreateProjectField(projectField);

            _repository.Create(projectField);

            if (Commit())
            {
                return projectField;
            }

            return null;
        }

        public List<ProjectField> Get()
        {
            return _repository.Get();
        }

        public List<ProjectField> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }
    }
}
