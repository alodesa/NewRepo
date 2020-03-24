using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Models
{
    public class CaseModel
    {
        public int Id { get; set; }
        public int CaseWorkerId { get; set; }
        public int CustomerId { get; set; }
        public int CaseStatusId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }


       
        public CaseWorkerModel Caseworkers { get; set; }
        public CustomerModel Customers { get; set; }
    }
}
