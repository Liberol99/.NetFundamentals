using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpExpo
    {
        public ErpExpo()
        {
            ErpBankCreditExpoClosings = new HashSet<ErpBankCreditExpoClosing>();
            ErpBankCreditItems = new HashSet<ErpBankCreditItem>();
            ErpBankReceiptItems = new HashSet<ErpBankReceiptItem>();
            ErpCurrentAccountReceiptItems = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpExpoAttachments = new HashSet<ErpExpoAttachment>();
            ErpExpoImportClosings = new HashSet<ErpExpoImportClosing>();
            ErpExpoItemDetails = new HashSet<ErpExpoItemDetail>();
            ErpExpoItemExpos = new HashSet<ErpExpoItem>();
            ErpExpoItemImportExpos = new HashSet<ErpExpoItem>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public byte? ExpoType { get; set; }
        public short? ExpoSubType { get; set; }
        public short? ExpoYear { get; set; }
        public string? ExpoNo { get; set; }
        public DateTime? ExpoDate { get; set; }
        public string? AccessCode { get; set; }
        public byte? ControlCode { get; set; }
        public string? Explanation { get; set; }
        public long? ManufacturerId { get; set; }
        public DateTime? ManufacturerInvoiceDate { get; set; }
        public string? ManufacturerInvoiceNo { get; set; }
        public DateTime? ManufacturerReceiptDate { get; set; }
        public string? ManufacturerReceiptNo { get; set; }
        public long? SellerId { get; set; }
        public DateTime? SellerInvoiceDate { get; set; }
        public string? SellerInvoiceNo { get; set; }
        public long? CurrentAccountId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string? InvoiceNo { get; set; }
        public long? CustomerId { get; set; }
        public int? CountryId { get; set; }
        public int? CorrespondentBankId { get; set; }
        public long? AddressId { get; set; }
        public long? Address1Id { get; set; }
        public long? Address2Id { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public int? IntermediaryBankId { get; set; }
        public string? IntermediaryBankReference { get; set; }
        public int? AdvisingBankAccountId { get; set; }
        public byte? ExportImportType { get; set; }
        public byte? DeliveryType { get; set; }
        public string? LetterOfCreditNo { get; set; }
        public byte? PaymentType { get; set; }
        public DateTime? PaymentTerm { get; set; }
        public byte? BillOfLoadingOwner { get; set; }
        public string? Instructor { get; set; }
        public byte? TransportType { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public string? ShipmentPlace { get; set; }
        public string? GoodsLocation { get; set; }
        public string? DestinationPoint { get; set; }
        public string? DischargingPoint { get; set; }
        public string? ProductOrigin { get; set; }
        public short? PackageType { get; set; }
        public DateTime? Dodate { get; set; }
        public string? Dono { get; set; }
        public decimal? Doforex1Rate { get; set; }
        public decimal? Doforex1Amount { get; set; }
        public decimal? Doforex2Rate { get; set; }
        public decimal? Doforex2Amount { get; set; }
        public decimal? Doamount { get; set; }
        public string? DocustomOutwards { get; set; }
        public string? DooutwardsGate { get; set; }
        public DateTime? DoclosedDate { get; set; }
        public DateTime? DoarrivalDate { get; set; }
        public DateTime? DodeliveredDate { get; set; }
        public decimal? DogrossWeight { get; set; }
        public decimal? DonetWeight { get; set; }
        public long? CustomBrokerId { get; set; }
        public string? AuthorityName { get; set; }
        public long? TransporterId { get; set; }
        public string? VehicleTypeName { get; set; }
        public string? VehicleId { get; set; }
        public string? VehicleScheduleNo { get; set; }
        public string? VehicleNationality { get; set; }
        public string? VehicleFlag { get; set; }
        public DateTime? BillOfLoadingDate { get; set; }
        public string? BillOfLoadingNo { get; set; }
        public DateTime? ManifestDate { get; set; }
        public string? ManifestNo { get; set; }
        public DateTime? WaybillDate { get; set; }
        public string? WaybillNo { get; set; }
        public long? CommissionerId { get; set; }
        public byte? CommissionType { get; set; }
        public decimal? CommissionRate { get; set; }
        public decimal? CommissionAmount { get; set; }
        public long? InsuranceId { get; set; }
        public string? InsuranceAgencyName { get; set; }
        public DateTime? InsuranceLastOfferDate { get; set; }
        public DateTime? IncuranceDate { get; set; }
        public string? InsuranceNo { get; set; }
        public byte? InsuranceDocumentType { get; set; }
        public int? InsuranceForexId { get; set; }
        public decimal? InsuranceForexRate { get; set; }
        public long? InvoiceId { get; set; }
        public long? PaymentPlanId { get; set; }
        public string? CustomerOrderNo { get; set; }
        public int? ProjectId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime? DestinationDate { get; set; }
        public decimal? QuantityTotal { get; set; }
        public decimal? LocalAmount { get; set; }
        public string? IbanNo { get; set; }
        public string? DeliveredPlace { get; set; }
        public string? CorrespondentBankReference { get; set; }
        public string? VehicleName { get; set; }
        public int? RegimeTypeId { get; set; }
        public byte? GuaranteeStatus { get; set; }
        public DateTime? GuaranteeDate { get; set; }
        public short? GuaranteeType { get; set; }
        public string? GuaranteeNo { get; set; }
        public int? GuaranteeBankId { get; set; }
        public DateTime? GuaranteeSolvedDate { get; set; }
        public decimal? GuaranteeAmount { get; set; }
        public decimal? ExpoAsset { get; set; }
        public decimal? SsiCost { get; set; }
        public decimal? FreightCost { get; set; }
        public byte? DiscountType { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? DiscountTotal { get; set; }
        public decimal? Fobtotal { get; set; }
        public decimal? Ciftotal { get; set; }
        public decimal? GeneralTotal { get; set; }
        public DateTime? LastReceiveDate { get; set; }
        public DateTime? ExchangeWarningDate { get; set; }
        public DateTime? LastForexReceiveDate { get; set; }
        public DateTime? VerifyBankDate { get; set; }
        public decimal? IncomingDabpercentage { get; set; }
        public int? DabbankId { get; set; }
        public long? LetterCreditId { get; set; }
        public decimal? CustomTaxAmount { get; set; }
        public decimal? AdditionCustomTaxAmount { get; set; }
        public decimal? AntiDampingTaxAmount { get; set; }
        public decimal? TotalLocalAmount { get; set; }
        public decimal? StampDutyTotal { get; set; }
        public byte? IsClosed { get; set; }
        public byte? IsLocked { get; set; }
        public DateTime? LockedAt { get; set; }
        public int? LockedBy { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpAddress? Address { get; set; }
        public virtual ErpAddress? Address1 { get; set; }
        public virtual ErpAddress? Address2 { get; set; }
        public virtual ErpBankAccount? AdvisingBankAccount { get; set; }
        public virtual ErpCurrentAccount? Commissioner { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpBankAccount? CorrespondentBank { get; set; }
        public virtual MetaCountry? Country { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpCurrentAccount? CustomBroker { get; set; }
        public virtual ErpCurrentAccount? Customer { get; set; }
        public virtual ErpBankAccount? Dabbank { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpBankAccount? GuaranteeBank { get; set; }
        public virtual ErpCurrentAccount? Insurance { get; set; }
        public virtual MetaForex? InsuranceForex { get; set; }
        public virtual ErpBankAccount? IntermediaryBank { get; set; }
        public virtual ErpInvoice? Invoice { get; set; }
        public virtual ErpBankCredit? LetterCredit { get; set; }
        public virtual ErpCurrentAccount? Manufacturer { get; set; }
        public virtual ErpPaymentPlan? PaymentPlan { get; set; }
        public virtual ErpProject? Project { get; set; }
        public virtual ErpRegimeType? RegimeType { get; set; }
        public virtual ErpCurrentAccount? Seller { get; set; }
        public virtual ErpCurrentAccount? Transporter { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpBankCreditExpoClosing> ErpBankCreditExpoClosings { get; set; }
        public virtual ICollection<ErpBankCreditItem> ErpBankCreditItems { get; set; }
        public virtual ICollection<ErpBankReceiptItem> ErpBankReceiptItems { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItems { get; set; }
        public virtual ICollection<ErpExpoAttachment> ErpExpoAttachments { get; set; }
        public virtual ICollection<ErpExpoImportClosing> ErpExpoImportClosings { get; set; }
        public virtual ICollection<ErpExpoItemDetail> ErpExpoItemDetails { get; set; }
        public virtual ICollection<ErpExpoItem> ErpExpoItemExpos { get; set; }
        public virtual ICollection<ErpExpoItem> ErpExpoItemImportExpos { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
    }
}
