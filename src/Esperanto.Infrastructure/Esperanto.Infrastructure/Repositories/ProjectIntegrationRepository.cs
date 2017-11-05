using Esperanto.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;
using Esperanto.Domain.Entities;
using Esperanto.Infrastructure.Context;
using System.Data.Entity;
using System;
using Esperanto.Domain.Enums.ProjectIntegration;

namespace Esperanto.Infrastructure.Repositories
{
    public class ProjectIntegrationRepository : IProjectIntegrationRepository
    {
        #region Properties

        private StoreDataContext _context { get; set; }

        #endregion


        #region Constructor

        public ProjectIntegrationRepository(StoreDataContext context)
        {
            this._context = context;
        }

        #endregion


        #region Methods

        /// <summary>
        /// Método para criar ProjectIntegration
        /// </summary>
        /// <param name="projectIntegration">ProjectIntegration a ser criado</param>
        public void Create(ProjectIntegration projectIntegration)
        {
            _context.ProjectIntegrations.Add(projectIntegration);
        }


        /// <summary>
        /// Método para remover ProjectIntegration
        /// </summary>
        /// <param name="projectIntegration">ProjectIntegration a ser atualizado</param>
        public void Delete(ProjectIntegration projectIntegration)
        {
            _context.ProjectIntegrations.Remove(projectIntegration);
        }

        /// <summary>
        /// Método para atualizar ProjectIntegration
        /// </summary>
        /// <param name="projectIntegration">ProjectIntegration a ser atualizado</param>
        public void Update(ProjectIntegration projectIntegration)
        {
            _context.Entry(projectIntegration).State = EntityState.Modified;
        }

        /// <summary>
        /// Método para buscar todos os ProjectIntegration
        /// </summary>
        /// <returns>Retorna todos os ProjectIntegration criados</returns>
        public List<ProjectIntegration> Get()
        {
            return _context.ProjectIntegrations
                           .ToList();
        }

        /// <summary>
        /// Método para buscar ProjectIntegrations, informando quantas deseja buscar e quantas deseja pular
        /// </summary>
        /// <param name="skip">Quantidade de ProjectIntegration a ser desconsiderado</param>
        /// <param name="take">Quantidade de ProjectIntegration que deseja obter</param>
        /// <returns>Retorna List de ProjectIntegration</returns>
        public List<ProjectIntegration> Get(int skip, int take)
        {
            return _context.ProjectIntegrations
                           .Skip(skip)
                           .Take(take)
                           .ToList();
        }

        /// <summary>
        /// Método para verificar se a Integração do Projeto deve ser executada
        /// </summary>
        /// <param name="projectIntegration">ProjectIntegration que a integração vai executar</param>
        /// <returns>Retorna true caso a integração deva ser executada</returns>
        public bool CheckExecuteIntegration(ProjectIntegration projectIntegration)
        {
            // Data da próxima migração
            DateTime NextMigration;

            switch (projectIntegration.IntervalType)
            {
                case EProjectIntegrationIntervalType.Day:
                    {
                        NextMigration = projectIntegration.LastMigrationDate.AddDays(projectIntegration.MigrationInterval);

                        if (DateTime.Now.Equals(NextMigration))
                        {
                            return true;
                        }

                        break;
                    }

                case EProjectIntegrationIntervalType.Hour:
                    {
                        NextMigration = projectIntegration.LastMigrationDate.AddHours(projectIntegration.MigrationInterval);
                        if (DateTime.Now.Equals(NextMigration))
                        {
                            return true;
                        }

                        break;
                    }

                case EProjectIntegrationIntervalType.Minutes:
                    {
                        NextMigration = projectIntegration.LastMigrationDate.AddMinutes(projectIntegration.MigrationInterval);
                        if (DateTime.Now.Equals(NextMigration))
                        {
                            return true;
                        }

                        break;
                    }

                default:
                    return false;
            }

            return false;
        }

        /// <summary>
        /// Método para executar a Integração do Projeto
        /// </summary>
        /// <param name="projectIntegration">ProjectIntegration que a integração vai executar</param>
        /// <returns>Retorna true caso a integração tenha sido executada com sucesso</returns>
        public bool ExecuteIntegration(ProjectIntegration projectIntegration)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
