using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFinance.Domain.Entities 
{
    public class ApplicationUser : IdentityUser
    {
        [Column("USR_CPF")]

        public int Cpf { get; set; }
    }
}
