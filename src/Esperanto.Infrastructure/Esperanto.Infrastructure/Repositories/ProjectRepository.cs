using Esperanto.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using Esperanto.Domain.Entities;
using Esperanto.Infrastructure.Context;
using System.Data.Entity;
using Esperanto.Domain.Specs;

namespace Esperanto.Infrastructure.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        #region Properties

        private StoreDataContext _context { get; set; }

        #endregion


        #region Constructor

        public ProjectRepository(StoreDataContext context)
        {
            this._context = context;
        }

        #endregion


        #region Methods

        /// <summary>
        /// Método para criar um Projeto
        /// </summary>
        /// <param name="project">Projeto a ser criado</param>
        public void Create(Project project)
        {
            this._context.Projects.Add(project);
        }

        /// <summary>
        /// Método para atualizar um projeto
        /// </summary>
        /// <param name="project">Projeto a ser atualizado</param>
        public void Update(Project project)
        {
            this._context.Entry(project).State = EntityState.Modified;
        }

        /// <summary>
        /// Método para remover um projeto
        /// </summary>
        /// <param name="project">Projeto a ser removido</param>
        public void Delete(Project project)
        {
            this._context.Projects.Remove(project);
        }

        /// <summary>
        /// Método para obter todos os Projetos
        /// </summary>
        /// <returns>Retorna todos os Projetos existentes</returns>
        public List<Project> Get()
        {
            return _context.Projects
                           .OrderBy(ProjectSpecs.OrderByDefault())
                           .ToList();
        }

        /// <summary>
        /// Método para buscar Projects, informando quantas deseja buscar e quantas deseja pular
        /// </summary>
        /// <param name="skip">Quantidade de Projects a ser desconsiderado</param>
        /// <param name="take">Quantidade de Projects que deseja obter</param>
        /// <returns></returns>
        public List<Project> Get(int skip, int take)
        {
            return _context.Projects
                           .Skip(skip)
                           .Take(take)
                           .OrderBy(ProjectSpecs.OrderByDefault())
                           .ToList();
        }

        /// <summary>
        /// Método para buscar todos os projetos ativos
        /// </summary>
        /// <returns>Retorna uma Lista com os Projects ativos</returns>
        public List<Project> GetActive()
        {
            return _context.Projects
                           .Where(ProjectSpecs.GetActives())
                           .OrderBy(ProjectSpecs.OrderByDefault())
                           .ToList();
        }

        /// <summary>
        /// Método para buscar todos os projetos inativos
        /// </summary>
        /// <returns>Retorna uma Lista com os Projects inativos</returns>
        public List<Project> GetInactive()
        {
            return _context.Projects
                          .Where(ProjectSpecs.GetInactives())
                          .OrderBy(ProjectSpecs.OrderByDefault())
                          .ToList();
        }

        /// <summary>
        /// Método para buscar Projects com o e-mail informado
        /// </summary>
        /// <param name="email">E-mail a ser buscado</param>
        /// <returns>Retorna uma lista de Project com o campo ErrorEmail informado</returns>
        public List<Project> GetByErrorEmail(string email)
        {
            return _context.Projects
                           .Where(ProjectSpecs.GetByErrorEmail(email))
                           .ToList();
        }

        /// <summary>
        /// Método para buscar Project por ID
        /// </summary>
        /// <param name="projectId">ID do Projects a ser buscado</param>
        /// <returns>Retorna o Project com o ID informado</returns>
        public Project GetById(Guid projectId)
        {
            return _context.Projects
                           .FirstOrDefault(ProjectSpecs.GetById(projectId));
                           
        }

        /// <summary>
        /// Método para buscar Projects de algum determinado LicenseId
        /// </summary>
        /// <param name="licenseId">Código da Licença a ser buscado</param>
        /// <returns>Retorna uma lista de Projects que possuem o LicenseID informado</returns>
        public List<Project> GetByLicenseId(Guid licenseId)
        {
            return _context.Projects
                           .Where(ProjectSpecs.GetByLicenseId(licenseId))
                           .ToList();
        }

        /// <summary>
        /// Método para buscar Projects de algum determinado permissionId
        /// </summary>
        /// <param name="permissionId">Código da Base Cadastral a ser buscado</param>
        /// <returns>Retorna uma lista de Projects que possuem o permissionId informado</returns>
        public List<Project> GetByPermissionId(Guid permissionId)
        {
            return _context.Projects
                           .Where(ProjectSpecs.GetByPermissionId(permissionId))
                           .ToList();
        }

        /// <summary>
        /// Método para buscar todos os projetos com SendType = FTP
        /// </summary>
        /// <returns>Retorna uma lista de Project com SendType = FTP</returns>
        public List<Project> GetFTPSendType()
        {
            return _context.Projects
                           .Where(ProjectSpecs.GetFTPSendType())
                           .ToList();
        }

        /// <summary>
        /// Método para buscar todos os projetos com SendType = API
        /// </summary>
        /// <returns>Retorna uma lista de Project com SendType = API</returns>
        public List<Project> GetAPISendType()
        {
            return _context.Projects
                           .Where(ProjectSpecs.GetAPISendType())
                           .ToList();
        }

        /// <summary>
        /// Método para buscar todos os projetos com SendType = MANUAL
        /// </summary>
        /// <returns>Retorna uma lista de Project com SendType = MANUAL</returns>
        public List<Project> GetManualSendType()
        {
            return _context.Projects
                           .Where(ProjectSpecs.GetManualSendType())
                           .ToList();
        }

        #endregion
    }
}
