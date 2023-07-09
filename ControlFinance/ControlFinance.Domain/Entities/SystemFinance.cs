using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFinance.Domain.Entities 
{
    public class SystemFinance : Base
    {
        public int Month { get; set; }

        public int Year { get; set; }

        public int CloseDay { get; set; }

        public bool CopyExpense { get; set; }

        public int MonthCopy { get; set; }

        public int YearCopy { get; set; }
    }
}
