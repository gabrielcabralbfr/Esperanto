using Esperanto.Domain.Entities;
using System;
using System.Collections.Generic;


namespace Esperanto.Domain.Repositories
{
    public interface IProjectLogRepository
    {

        /// <summary>
        /// Método para criar ProjectLog
        /// </summary>
        /// <param name="projectLog">ProjectLog a ser criado</param>
        void Create(ProjectLog projectLog);

        /// <summary>
        /// Método para remover ProjectLog
        /// </summary>
        /// <param name="projectLog">ProjectLog a ser atualizado</param>
        void Delete(ProjectLog projectLog);

        /// <summary>
        /// Método para buscar todos os ProjectLog
        /// </summary>
        /// <returns>Retorna todos os ProjectLog criados</returns>
        List<ProjectLog> Get();

        /// <summary>
        /// Método para buscar ProjectLogs, informando quantas deseja buscar e quantas deseja pular
        /// </summary>
        /// <param name="skip">Quantidade de ProjectLog a ser desconsiderado</param>
        /// <param name="take">Quantidade de ProjectLog que deseja obter</param>
        /// <returns>Retorna List de ProjectLog</returns>
        List<ProjectLog> Get(int skip, int take);

        /// <summary>
        /// Método para Retornar UserLog de um período específico
        /// </summary>
        /// <param name="startDate">Data de início</param>
        /// <param name="endDate">Data final</param>
        /// <returns>Retorna List<UserLog> com data de criação entre as datas passadas como parâmetro</returns>
        List<ProjectLog> Get(DateTime startDate, DateTime endDate);
    }
}
