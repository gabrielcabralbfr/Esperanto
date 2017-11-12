using Esperanto.Infrastructure.Context;

namespace Esperanto.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Properties

        private StoreDataContext _context;

        #endregion


        #region Constructor

        public UnitOfWork(StoreDataContext context)
        {
            _context = context;
        }

        #endregion


        #region Methods

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();

                    _context = null;
                }
            }
        }


        #endregion
    }
}
