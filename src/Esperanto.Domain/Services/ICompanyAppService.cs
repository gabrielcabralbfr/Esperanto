using Esperanto.Domain.Commands.CompanyCommands;
using Esperanto.Domain.Entities;
using System.Collections.Generic;


namespace Esperanto.Domain.Services
{
    public interface ICompanyAppService
    {
        #region Methods

        /// <summary>
        /// Método para obter todos os Company
        /// </summary>
        /// <returns>Retorna uma Lista de Company</returns>
        List<Company> Get();

        /// <summary>
        /// Método para obter uma Lista de Company ignorando a quantidade informada no parâmetro skip
        /// e selecionando a quantidade informada no parâmetro take
        /// </summary>
        /// <param name="skip">Quantidade de Company a serem desconsiderados</param>
        /// <param name="take">Quantidade de Company a serem obtidos</param>
        /// <returns>Retorna uma Lista de Company</returns>
        List<Company> Get(int skip, int take);

        /// <summary>
        /// Método que recebe um comando de criação de Company
        /// </summary>
        /// <param name="command">Cmoando de criação do Company</param>
        /// <returns>Retorna a Company criada</returns>
        Company Create(CreateCompanyCommand command);

        /// <summary>
        /// Método que recebe um comando de atualização de um Company
        /// </summary>
        /// <param name="command">Comando de atualização de um Company</param>
        /// <returns>Retorna a Company atualizada</returns>
        Company Update(UpdateCompanyCommand command);

        /// <summary>
        /// Método que recebe um comando de exclusão de uma Company
        /// </summary>
        /// <param name="command">Comando de exclusão da Company</param>
        void Delete(DeleteCompanyCommand command);

        #endregion
    }
}
