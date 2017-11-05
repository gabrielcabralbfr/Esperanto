using Esperanto.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;
using Esperanto.Domain.Entities;
using System;
using Esperanto.Infrastructure.Context;
using Esperanto.Domain.Specs;

namespace Esperanto.Infrastructure.Repositories
{
    public class ProjectLogRepository : IProjectLogRepository
    {

        #region Properties

        private StoreDataContext _context { get; set; }

        #endregion


        #region Constructor

        public ProjectLogRepository(StoreDataContext context)
        {
            this._context = context;
        }

        #endregion


        #region Methods

        /// <summary>
        /// Método para criar ProjectLog
        /// </summary>
        /// <param name="projectLog">ProjectLog a ser criado</param>
        public void Create(ProjectLog projectLog)
        {
            _context.ProjectLogs.Add(projectLog);
        }

        /// <summary>
        /// Método para remover ProjectLog
        /// </summary>
        /// <param name="projectLog">ProjectLog a ser atualizado</param>
        public void Delete(ProjectLog projectLog)
        {
            _context.ProjectLogs.Remove(projectLog);
        }

        /// <summary>
        /// Método para buscar todos os ProjectLog
        /// </summary>
        /// <returns>Retorna todos os ProjectLog criados</returns>
        public List<ProjectLog> Get()
        {
            return _context.ProjectLogs
                           .OrderBy(ProjectLogSpecs.OrderByDefault())           
                           .ToList();
        }

        /// <summary>
        /// Método para buscar ProjectLogs, informando quantas deseja buscar e quantas deseja pular
        /// </summary>
        /// <param name="skip">Quantidade de ProjectLog a ser desconsiderado</param>
        /// <param name="take">Quantidade de ProjectLog que deseja obter</param>
        /// <returns>Retorna List de ProjectLog</returns>
        public List<ProjectLog> Get(int skip, int take)
        {
            return _context.ProjectLogs
                           .Skip(skip)
                           .Take(take)
                           .OrderBy(ProjectLogSpecs.OrderByDefault())
                           .ToList();
        }

        /// <summary>
        /// Método para obter os Logs de Projeto por delimitação de período inicial e período final
        /// </summary>
        /// <param name="starDate">Período inicial</param>
        /// <param name="endDate">Período final</param>
        /// <returns>Retorna todos os Logs de Projeto dentro do período especificado</returns>
        public List<ProjectLog> Get(DateTime startDate, DateTime endDate)
        {
            return this._context.ProjectLogs
                               .Where(ProjectLogSpecs.Get(startDate, endDate))
                               .OrderBy(ProjectLogSpecs.OrderByDefault())
                               .ToList();
        }

        List<ProjectLog> IProjectLogRepository.Get(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
