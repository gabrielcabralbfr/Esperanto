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
    public class CompanyRepository : ICompanyRepository
    {

        #region Properties

        private StoreDataContext _context { get; set; }

        #endregion


        #region Constructor

        public CompanyRepository(StoreDataContext context)
        {
            this._context = context;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Método para criar Companies
        /// </summary>
        /// <param name="company">Company a ser criada</param>
        public void Create(Company company)
        {
            _context.Companies.Add(company);
        }

        /// <summary>
        /// Método para remover Companies
        /// </summary>
        /// <param name="company">Company a ser removida</param>
        public void Delete(Company company)
        {
            _context.Companies.Remove(company);
        }

        /// <summary>
        /// Método para atualizar Companies
        /// </summary>
        /// <param name="company">Commpany a ser atualizada</param>
        public void Update(Company company)
        {
            _context.Entry(company).State = EntityState.Modified;
        }

        /// <summary>
        /// Método para buscar todas as Companies
        /// </summary>
        /// <returns>Retorna todas as Companies criadas</returns>
        public List<Company> Get()
        {
            return _context.Companies
                           .OrderBy(CompanySpecs.OrderByDefault())
                           .ToList();
        }

        /// <summary>
        /// Método para buscar companies, informando quantas deseja buscar e quantas deseja pular
        /// </summary>
        /// <param name="skip">Quantidade de Companies a ser desconsiderada</param>
        /// <param name="take">Quantidade de Companies que deseja obter</param>
        /// <returns>Retorna uma Lista de Company</returns>
        public List<Company> Get(int skip, int take)
        {
            return _context.Companies
                            .Skip(skip)
                            .Take(take)
                            .OrderBy(CompanySpecs.OrderByDefault())
                            .ToList();
        }

        /// <summary>
        /// Método para buscar Companies por ID
        /// </summary>
        /// <param name="companyId">ID da Company a ser buscada</param>
        /// <returns>Retorna a Company com o ID informado</returns>
        public Company GetById(Guid companyId)
        {
            return _context.Companies
                            .FirstOrDefault(CompanySpecs.GetById(companyId));
                            
        }

        /// <summary>
        /// Método para buscar uma Company pelo nome
        /// </summary>
        /// <param name="name">Nome da Company a ser buscada</param>
        /// <returns>Retorna uma Company caso exista com o nome informado</returns>
        public Company GetByName(string name)
        {
            return _context.Companies
                           .FirstOrDefault(CompanySpecs.GetByName(name));
        }

        /// <summary>
        /// Método para buscar todas as Company ativas
        /// </summary>
        /// <returns>Retorna uma lista de Company com status = ativo</returns>
        public List<Company> GetActive()
        {
            return _context.Companies
                           .Where(CompanySpecs.GetActives())
                           .OrderBy(CompanySpecs.OrderByDefault())
                           .ToList();
        }

        /// <summary>
        /// Método para buscar todas as Company inativas
        /// </summary>
        /// <returns>Retorna uma lista de Company com status = inativo</returns>
        public List<Company> GetInactive()
        {
            return _context.Companies
                           .Where(CompanySpecs.GetInactives())
                           .OrderBy(CompanySpecs.OrderByDefault())
                           .ToList();
        }

        #endregion
    }
}
