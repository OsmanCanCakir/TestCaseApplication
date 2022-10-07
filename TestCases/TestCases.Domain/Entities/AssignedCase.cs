using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCases.Domain.Entities
{
    public class AssignedCase
    {
        public int Id { get; set; }

        public int CaseId { get; set; }
        public int UserId { get; set; }

        public string Description { get; set; }


    }
}
