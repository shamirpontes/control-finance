using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFinance.Domain.Entities 
{
    public class SystemFinanceUser : Base
    {
        public int Id { get; set; }

        public string UserEmail { get; set; }

        public bool Administrator { get; set; }

        public bool CurrentSystem { get; set; }


        [ForeignKey("SystemFinance")]
        [Column(Order = 1)]

        public int SystemId { get; set; }

        public virtual SystemFinance SystemFinance { get; set; }

    }
}
