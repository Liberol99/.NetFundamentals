using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpGlregBook
    {
        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public short? RegBookYear { get; set; }
        public DateTime? RegBookDate { get; set; }
        public int? RegBookNo { get; set; }
        public decimal? RegBookDebit { get; set; }
        public decimal? RegBookCredit { get; set; }

        public virtual ErpCompany? Company { get; set; }
    }
}
