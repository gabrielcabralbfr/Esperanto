using Esperanto.Domain.Repositories;
using Esperanto.Infrastructure.Context;
using System;
using System.Collections.Generic;
using Esperanto.Domain.Entities;
using System.Linq;
using Esperanto.Domain.Specs;

namespace Esperanto.Infrastructure.Repositories
{
    public class UserLogRepository : IUserLogRepository
    {

        #region Properties

        public StoreDataContext _context { get; set; }

        #endregion


        #region Constructor

        public UserLogRepository(StoreDataContext context)
        {
            this._context = context;
        }

        #endregion


        #region Methods

        /// <summary>
        /// Método para criação de um Log de usuário
        /// </summary>
        /// <param name="userLog">Log a ser criado</param>
        public void Create(UserLog userLog)
        {
            this._context.UserLogs.Add(userLog);
        }

        /// <summary>
        /// Método para exclusão de um Log de Usuário
        /// </summary>
        /// <param name="userLog">Log a ser removido</param>
        public void Delete(UserLog userLog)
        {
            this._context.UserLogs.Remove(userLog);
        }

        /// <summary>
        /// Método para obter todos os Logs de Usuário
        /// </summary>
        /// <returns>Retorna uma Lista de Logs</returns>
        public List<UserLog> Get()
        {
            return this._context.UserLogs
                                .OrderBy(UserLogSpecs.OrderByDefault())
                                .ToList();
        }

        /// <summary>
        /// Método para buscar UserLogs, informando quantas deseja buscar e quantas deseja pular
        /// </summary>
        /// <param name="skip">Quantidade de UserLogs a ser desconsiderado</param>
        /// <param name="take">Quantidade de UserLogs que deseja obter</param>
        /// <returns>Retorna List de UserLogs</returns>
        public List<UserLog> Get(int skip, int take)
        {
            return this._context.UserLogs
                                .OrderBy(UserLogSpecs.OrderByDefault())
                                .Skip(skip)
                                .Take(take)
                                .ToList();
        }

        /// <summary>
        /// Método para obter os Logs de Usuário por delimitação de período inicial e período final
        /// </summary>
        /// <param name="starDate">Período inicial</param>
        /// <param name="endDate">Período final</param>
        /// <returns>Retorna todos os Logs de Usuário dentro do período especificado</returns>
        public List<UserLog> Get(DateTime startDate, DateTime endDate)
        {
            return this._context.UserLogs
                                .Where(UserLogSpecs.Get(startDate, endDate))
                                .OrderBy(UserLogSpecs.OrderByDefault())
                                .ToList();
        }

        #endregion



    }
}
