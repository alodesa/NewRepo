using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webapi2.Entitites
{
    public class Case
    {
        public int Id { get; set; }
        public int CaseWorkerId { get; set; }
        public int CustomerId { get; set; }
        public int CaseStatusId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
       

        public  CaseStatus CaseStatus { get; set; }
        public CaseWorker CaseWorkers { get; set; }
        public Customer Customers { get; set; }
    }
}
