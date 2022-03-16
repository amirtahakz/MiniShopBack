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
    public class CommentService : BaseService<Comment>, ICommentService
    {
        public CommentService(ApplicationDbContext context) : base(context) { }

        public async Task<IQueryable<Comment>> GetCommentsProduct(Guid id)
        {
            return Table().Where(c => c.ProductId == id);
        }

        public async Task PostComment(Comment model)
        {
            await AddAsync(model);
        }
    }
}
