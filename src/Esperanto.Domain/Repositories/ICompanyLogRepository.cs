using Esperanto.Domain.Entities;
using System;
using System.Collections.Generic;


namespace Esperanto.Domain.Repositories
{
    public interface ICompanyLogRepository
    {
        /// <summary>
        /// Método para criar CompanyLog
        /// </summary>
        /// <param name="companyLog">Log a ser criado</param>
        void Create(CompanyLog companyLog);

        /// <summary>
        /// Método para atualizar CompanyLog
        /// </summary>
        /// <param name="companyLog">CompanyLog a ser atualizado</param>
        void Update(CompanyLog companyLog);

        /// <summary>
        /// Método para remover CompanyLog
        /// </summary>
        /// <param name="companyLog">CompanyLog a ser removido</param>
        void Delete(CompanyLog companyLog);

        /// <summary>
        /// Método para buscar todos os CompanyLogs
        /// </summary>
        /// <returns>Retorna todos os CompanyLogs criados</returns>
        List<CompanyLog> Get();

        /// <summary>
        /// Método para buscar CompanyLogs, informando quantas deseja buscar e quantas deseja pular
        /// </summary>
        /// <param name="skip">Quantidade de CompanyLogs a ser desconsiderado</param>
        /// <param name="take">Quantidade de CompanyLogs que deseja obter</param>
        /// <returns>Retorna uma Lista de CompanyLog</returns>
        List<CompanyLog> Get(int skip, int take);

        /// <summary>
        /// Método para retornar CompanyLog de um período específico
        /// </summary>
        /// <param name="startDate">Data de início</param>
        /// <param name="endDate">Data final</param>
        /// <returns>Retorna List<CompanyLog> com data de criação entre as datas passadas como parâmetro</returns>
        List<CompanyLog> Get(DateTime startDate, DateTime endDate);
    }
}
