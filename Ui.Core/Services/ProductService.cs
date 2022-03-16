using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ui.Core.Repositories;
using Ui.Data.Context;
using Ui.Data.Entities;

namespace Ui.Core.Services
{
    public class ProductService : BaseService<Product> , IProductService
    {
        public ProductService(ApplicationDbContext context) : base(context) { }


        public IQueryable<Product> GetByName(string? name)
        {
            if (string.IsNullOrEmpty(name)) return Table();


            var foundProducts = Table().Where(i => i.Name.Contains(name));
            return foundProducts;
        }

        public async Task AddOne(Product model)
        {
            await AddAsync(model);
        }

        public async Task<Product> GetById(Guid id)
        {
            return await GetByIdAsync(id);
        }
    }
}
