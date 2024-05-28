using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class LicenseActivation
    {
        public int RecId { get; set; }
        public byte? LicenseType { get; set; }
        public string? LicenseCustomer { get; set; }
        public string? LicenseCode { get; set; }
        public string? LicenseData { get; set; }
        public string? ValidationHash { get; set; }
    }
}
