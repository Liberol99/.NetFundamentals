using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class VwGlaccountBalance
    {
        public int? CompanyId { get; set; }
        public int? AccountId { get; set; }
        public string? AccountCode { get; set; }
        public string? AccountName { get; set; }
        public short? FiscalYear { get; set; }
        public int? ForexId { get; set; }
        public decimal? DebitAll { get; set; }
        public decimal? CreditAll { get; set; }
    }
}
