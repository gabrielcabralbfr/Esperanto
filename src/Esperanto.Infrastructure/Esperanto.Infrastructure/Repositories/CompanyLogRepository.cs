using Esperanto.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;
using Esperanto.Domain.Entities;
using System;
using Esperanto.Infrastructure.Context;
using System.Data.Entity;
using Esperanto.Domain.Specs;

namespace Esperanto.Infrastructure.Repositories
{
    public class CompanyLogRepository : ICompanyLogRepository
    {
        #region Properties

        private StoreDataContext _context { get; set; }

        #endregion


        #region Constructor

        public CompanyLogRepository(StoreDataContext context)
        {
            this._context = context;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Método para criar CompanyLog
        /// </summary>
        /// <param name="companyLog">Log a ser criado</param>
        public void Create(CompanyLog companyLog)
        {
            _context.CompanyLogs.Add(companyLog);
        }

        /// <summary>
        /// Método para remover CompanyLog
        /// </summary>
        /// <param name="companyLog">CompanyLog a ser removido</param>
        public void Delete(CompanyLog companyLog)
        {
            _context.CompanyLogs.Remove(companyLog);
        }

        /// <summary>
        /// Método para atualizar CompanyLog
        /// </summary>
        /// <param name="companyLog">CompanyLog a ser atualizado</param>
        public void Update(CompanyLog companyLog)
        {
            _context.Entry(companyLog).State = EntityState.Modified;
        }

        /// <summary>
        /// Método para buscar todos os CompanyLogs
        /// </summary>
        /// <returns>Retorna todos os CompanyLogs criados</returns>
        public List<CompanyLog> Get()
        {
            return _context.CompanyLogs
                           .OrderBy(CompanyLogSpecs.OrderByDefault())
                           .ToList();
        }

        /// <summary>
        /// Método para buscar CompanyLogs, informando quantas deseja buscar e quantas deseja pular
        /// </summary>
        /// <param name="skip">Quantidade de CompanyLogs a ser desconsiderado</param>
        /// <param name="take">Quantidade de CompanyLogs que deseja obter</param>
        /// <returns>Retorna uma Lista de CompanyLog</returns>
        public List<CompanyLog> Get(int skip, int take)
        {
            return _context.CompanyLogs
                           .OrderBy(CompanyLogSpecs.OrderByDefault())
                           .Skip(skip)
                           .Take(take)
                           .ToList();
        }

        /// <summary>
        /// Método para retornar CompanyLog de um período específico
        /// </summary>
        /// <param name="startDate">Data de início</param>
        /// <param name="endDate">Data final</param>
        /// <returns>Retorna List<CompanyLog> com data de criação entre as datas passadas como parâmetro</returns>
        public List<CompanyLog> Get(DateTime startDate, DateTime endDate)
        {
            return _context.CompanyLogs
                           .Where(CompanyLogSpecs.Get(startDate, endDate))
                           .OrderBy(CompanyLogSpecs.OrderByDefault())
                           .ToList();
        }

        #endregion
    }
}
