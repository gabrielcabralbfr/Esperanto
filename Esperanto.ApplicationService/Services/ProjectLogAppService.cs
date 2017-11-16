using System;
using System.Collections.Generic;
using Esperanto.Domain.Commands.ProjectLogCommands;
using Esperanto.Domain.Entities;
using Esperanto.Domain.Services;
using Esperanto.Infrastructure.UnitOfWork;
using Esperanto.Domain.Repositories;

namespace Esperanto.ApplicationService.Services
{
    public class ProjectLogAppService : ApplicationService, IProjectLogAppService
    {
        #region Properties
        private IProjectLogRepository _repository;
        #endregion

        #region Constructor
        public ProjectLogAppService(IUnitOfWork unitOfWork, IProjectLogRepository repository) : base(unitOfWork)
        {
            this._repository = repository;
        }
        #endregion


        #region Methods
        public ProjectLog Create(CreateProjectLogCommand command)
        {
            var projectLog = new ProjectLog(command);

            _repository.Create(projectLog);

            projectLog.CreateProjectLog(projectLog);

            if (Commit())
            {
                return projectLog;
            }

            return null;
        }

        public List<ProjectLog> Get()
        {
            return _repository.Get();
        }

        public List<ProjectLog> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }
        #endregion




    }
}
