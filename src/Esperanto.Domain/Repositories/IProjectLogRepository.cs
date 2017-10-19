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
        /// <param name="projectLog"></param>
        void Create(ProjectLog projectLog);

        /// <summary>
        /// Método para atualizar ProjectLog
        /// </summary>
        /// <param name="projectLog">ProjectLog a ser atualizado</param>
        void Update(ProjectLog projectLog);

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
        /// Método para retornar ProjectLog de um período específico
        /// </summary>
        /// <param name="startDate">Data de início</param>
        /// <param name="endDate">Data final</param>
        /// <returns>Retorna List<ProjectLog> com data de criação entre as datas passadas como parâmetro</returns>
        List<ProjectLog> Get(DateTime startDate, DateTime endDate);

        /// <summary>
        /// Método para buscar ProjectLog por ID
        /// </summary>
        /// <param name="projectLogId">ID do ProjectLog a ser buscado</param>
        /// <returns>Retorna o ProjectLog com o ID informado</returns>
        ProjectLog GetById(string projectLogId);
    }
}
