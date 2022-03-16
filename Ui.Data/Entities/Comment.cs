using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ui.Data.Entities
{
    public class Comment : BaseEntity
    {

        public string Text { get; set; }
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
        public string Author { get; set; }

        #region Realtions

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        #endregion
    }
}
