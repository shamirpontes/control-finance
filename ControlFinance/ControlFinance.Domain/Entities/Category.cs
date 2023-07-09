using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFinance.Domain.Entities 
{
    [Table("Category")]
    public class Category : Base
    {

        [ForeignKey("SystemFinance")]
        [Column(Order = 1)]

        public int SystemId { get; set; }

        public virtual SystemFinance SystemFinance { get; set; }
    }
}
