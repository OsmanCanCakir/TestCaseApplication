using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCases.Domain.Entities
{
    public class CaseStatus
    {
        public int Id { get; set; }

        public int CaseId { get; set; }

        public DateTime Date { get; set; }

        public int Status { get; set; }

      

    }
}
