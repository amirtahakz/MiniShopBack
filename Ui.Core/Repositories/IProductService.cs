using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ui.Data.Entities;

namespace Ui.Core.Repositories
{
    public interface IProductService
    {
        #region IMethods

        IQueryable<Product> GetByName(string name = "");
        Task AddOne(Product model);

        Task<Product> GetById(Guid id);

        #endregion
    }
}
