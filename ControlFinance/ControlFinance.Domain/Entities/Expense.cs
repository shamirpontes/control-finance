using ControlFinance.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFinance.Domain.Entities 
{
    [Table("Expense")]
    public class Expense  : Base
    {
        public decimal Value { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public EnumTypeExpense TypeExpense { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public DateTime PaymentDate { get; set; }

        public DateTime DueDate { get; set; }

        public bool Paid { get; set; }

        public bool OverdueExpense { get; set; }



        [ForeignKey("Category")]
        [Column(Order = 1)]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
