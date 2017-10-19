using Esperanto.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Esperanto.Domain.Repositories
{
    public interface IUserLogRepository
    {
        /// <summary>
        /// Método para criar UserLog
        /// </summary>
        /// <param name="userLog"></param>
        void Create(UserLog userLog);

        /// <summary>
        /// Método para atualizar UserLogs
        /// </summary>
        /// <param name="userLog">UserLog a ser atualizado</param>
        void Update(UserLog userLog);

        /// <summary>
        /// Método para remover UserLog
        /// </summary>
        /// <param name="userLog">UserLog a ser atualizado</param>
        void Delete(UserLog userLog);

        /// <summary>
        /// Método para buscar todos os UserLogs
        /// </summary>
        /// <returns>Retorna todos os UserLogs criados</returns>
        List<UserLog> Get();

        /// <summary>
        /// Método para buscar UserLogs, informando quantas deseja buscar e quantas deseja pular
        /// </summary>
        /// <param name="skip">Quantidade de UserLogs a ser desconsiderado</param>
        /// <param name="take">Quantidade de UserLogs que deseja obter</param>
        /// <returns>Retorna List de UserLogs</returns>
        List<UserLog> Get(int skip, int take);

        /// <summary>
        /// Método para Retornar UserLog de um período específico
        /// </summary>
        /// <param name="startDate">Data de início</param>
        /// <param name="endDate">Data final</param>
        /// <returns>Retorna List<UserLog> com data de criação entre as datas passadas como parâmetro</returns>
        List<UserLog> Get(DateTime startDate, DateTime endDate);
        
        /// <summary>
        /// Método para buscar UserLog por ID
        /// </summary>
        /// <param name="userLogId">ID do UserLog a ser buscado</param>
        /// <returns>Retorna o UserLog com o ID informado</returns>
        Project GetById(string userLogId);

        
    }
}
