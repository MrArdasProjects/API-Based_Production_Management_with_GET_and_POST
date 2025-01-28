using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partnera
{
    internal class Batch
    {
        public string CompanyCode { get; set; }
        public string OrganizationId { get; set; }
        public string OrganizationCode { get; set; }
        public string BatchNo { get; set; }
        public string Product { get; set; }
        public string Description { get; set; }
        public string PlanQty { get; set; }
        public string ActualQty { get; set; }
        public string DtlUm { get; set; }
        public string Subinventory { get; set; }
        public string BatchStatus { get; set; }
        public string PlanStartDate { get; set; }
        public string ActualStartDate { get; set; }
        public string DueDate { get; set; }
    }
}
