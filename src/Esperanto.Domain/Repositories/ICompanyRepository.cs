using Esperanto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperanto.Domain.Repositories
{
    public interface ICompanyRepository
    {
        /// <summary>
        /// Método para criar Companies
        /// </summary>
        /// <param name="company">Company a ser criada</param>
        void Create(Company company);

        /// <summary>
        /// Método para atualizar Companies
        /// </summary>
        /// <param name="company">Commpany a ser atualizada</param>
        void Update(Company company);

        /// <summary>
        /// Método para remover Companies
        /// </summary>
        /// <param name="company">Company a ser removida</param>
        void Delete(Company company);

        /// <summary>
        /// Método para buscar todas as Companies
        /// </summary>
        /// <returns>Retorna todas as Companies criadas</returns>
        List<Company> Get();

        /// <summary>
        /// Método para buscar companies, informando quantas deseja buscar e quantas deseja pular
        /// </summary>
        /// <param name="skip">Quantidade de Companies a ser desconsiderada</param>
        /// <param name="take">Quantidade de Companies que deseja obter</param>
        /// <returns>Retorna uma Lista de Company</returns>
        List<Company> Get(int skip, int take);

        /// <summary>
        /// Método para buscar Companies por ID
        /// </summary>
        /// <param name="companyId">ID da Company a ser buscada</param>
        /// <returns>Retorna a Company com o ID informado</returns>
        Company GetById(Guid companyId);

        /// <summary>
        /// Método para buscar uma Company pelo nome
        /// </summary>
        /// <param name="name">Nome da Company a ser buscada</param>
        /// <returns>Retorna uma Company caso exista com o nome informado</returns>
        Company GetByName(string name);

        /// <summary>
        /// Método para buscar todas as Company ativas
        /// </summary>
        /// <returns>Retorna uma lista de Company com status = ativo</returns>
        List<Company> GetActive();

        /// <summary>
        /// Método para buscar todas as Company inativas
        /// </summary>
        /// <returns>Retorna uma lista de Company com status = inativo</returns>
        List<Company> GetInactive();
    }
}
