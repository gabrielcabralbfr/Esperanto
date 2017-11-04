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


        public void Create(Company company)
        {
            _context.Companies.Add(company);
        }

        public void Delete(Company company)
        {
            _context.Companies.Remove(company);
        }

        public void Update(Company company)
        {
            _context.Entry(company).State = EntityState.Modified;
        }

        public List<Company> Get()
        {
            return _context.Companies
                           .OrderBy(CompanySpecs.OrderByDefault())
                           .ToList();
        }

        public List<Company> Get(int skip, int take)
        {
            return _context.Companies
                            .Skip(skip)
                            .Take(take)
                            .OrderBy(CompanySpecs.OrderByDefault())
                            .ToList();
        }

        public Company Get(Guid companyId)
        {
            return _context.Companies
                            .FirstOrDefault(CompanySpecs.GetById(companyId));
                            
        }

        public Company GetByName(string name)
        {
            return _context.Companies
                           .FirstOrDefault(CompanySpecs.GetByName(name));
        }

        public List<Company> GetActive()
        {
            return _context.Companies
                           .Where(CompanySpecs.GetActives())
                           .OrderBy(CompanySpecs.OrderByDefault())
                           .ToList();
        }

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
