using System.Collections.Generic;
using Esperanto.Domain.Commands.ProjectCommands;
using Esperanto.Domain.Entities;
using Esperanto.Domain.Services;
using Esperanto.Infrastructure.UnitOfWork;
using Esperanto.Domain.Repositories;
using Esperanto.Domain.Enums.Project;

namespace Esperanto.ApplicationService.Services
{
    public class ProjectAppService : ApplicationService, IProjectAppService
    {
        #region Properties

        private IProjectRepository _repository;

        #endregion

        #region Constructor

        public ProjectAppService(IUnitOfWork unitOfWork, IProjectRepository repository) : base(unitOfWork)
        {
            this._repository = repository;
        }

        #endregion

        #region Methods

        public Project Create(CreateProjectCommand command)
        {
            var project = new Project(command);

            project.CreateProject(project);

            _repository.Create(project);

            if (Commit())
            {
                return project;
            }

            return null;
        }

        public void Delete(DeleteProjectCommand command)
        {
            var project = _repository.GetById(command.ProjectId);

            _repository.Delete(project);
        }

        public Project Update(UpdateProjectCommand command)
        {
            var project = _repository.GetById(command.ProjectId);

            project.UpdateProject(project);

            _repository.Update(project);

            if (Commit())
            {
                return project;
            }

            return null;
        }

        public List<Project> Get()
        {
            return _repository.Get();
        }

        public List<Project> Get(int skip, int take)
        {
            return _repository.Get(skip, take);
        }

        public bool Activate(Project project)
        {
            project.Activate();

            project.UpdateProject(project);

            _repository.Update(project);

            if (Commit())
            {
                return true;
            }

            return false;
        }

        public bool Dectivate(Project project)
        {
            project.Dectivate();

            project.UpdateProject(project);

            _repository.Update(project);

            if (Commit())
            {
                return true;
            }

            return false;
        }

        public void ChangeSendType(Project project, ESendType newType)
        {
            project.ChangeSendType(newType);
            _repository.Update(project);

        }

        public void ChangeFileType(Project project, EFileType newType)
        {
            project.ChangeFileType(newType);
            _repository.Update(project);
        }


        #endregion


    }
}
