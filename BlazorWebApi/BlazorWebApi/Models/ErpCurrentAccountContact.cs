using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCurrentAccountContact
    {
        public ErpCurrentAccountContact()
        {
            ErpContracts = new HashSet<ErpContract>();
            ErpCustomerTransactions = new HashSet<ErpCustomerTransaction>();
            ErpEducationStudents = new HashSet<ErpEducationStudent>();
            ErpInventoryReceipts = new HashSet<ErpInventoryReceipt>();
            ErpInvoices = new HashSet<ErpInvoice>();
            ErpNotificationItems = new HashSet<ErpNotificationItem>();
            ErpOrderReceipts = new HashSet<ErpOrderReceipt>();
            ErpPollAnswers = new HashSet<ErpPollAnswer>();
            ErpPollUserAnswers = new HashSet<ErpPollUserAnswer>();
            ErpQuotationReceipts = new HashSet<ErpQuotationReceipt>();
            ErpSubscriptions = new HashSet<ErpSubscription>();
        }

        public long RecId { get; set; }
        public string? Title { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Position { get; set; }
        public long? CurrentAccountId { get; set; }
        public long? AddressId { get; set; }
        public string? EmailAddress { get; set; }
        public short? PositionType { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? GsmNo { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? MariageDate { get; set; }
        public byte? Gender { get; set; }
        public string? Explanation { get; set; }
        public string? Blog { get; set; }
        public string? Facebook { get; set; }
        public string? Twitter { get; set; }
        public string? LinkedIn { get; set; }
        public string? EinvoiceAlias { get; set; }
        public string? B2buserName { get; set; }
        public string? B2bpassword { get; set; }
        public int? UserId { get; set; }
        public byte? IsDefault { get; set; }
        public byte? IsPartner { get; set; }
        public byte? IsSendMail { get; set; }
        public decimal? Capital { get; set; }
        public string? FathersName { get; set; }
        public string? IdCardNo { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpAddress? Address { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual MetaUser? User { get; set; }
        public virtual ICollection<ErpContract> ErpContracts { get; set; }
        public virtual ICollection<ErpCustomerTransaction> ErpCustomerTransactions { get; set; }
        public virtual ICollection<ErpEducationStudent> ErpEducationStudents { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceipts { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoices { get; set; }
        public virtual ICollection<ErpNotificationItem> ErpNotificationItems { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceipts { get; set; }
        public virtual ICollection<ErpPollAnswer> ErpPollAnswers { get; set; }
        public virtual ICollection<ErpPollUserAnswer> ErpPollUserAnswers { get; set; }
        public virtual ICollection<ErpQuotationReceipt> ErpQuotationReceipts { get; set; }
        public virtual ICollection<ErpSubscription> ErpSubscriptions { get; set; }
    }
}
