using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpWorkplace
    {
        public ErpWorkplace()
        {
            ErpAddresses = new HashSet<ErpAddress>();
            ErpBankAccountWorkplaces = new HashSet<ErpBankAccountWorkplace>();
            ErpBankAccounts = new HashSet<ErpBankAccount>();
            ErpBankCredits = new HashSet<ErpBankCredit>();
            ErpBankReceipts = new HashSet<ErpBankReceipt>();
            ErpBankWorkplaces = new HashSet<ErpBankWorkplace>();
            ErpBanks = new HashSet<ErpBank>();
            ErpBudgetItems = new HashSet<ErpBudgetItem>();
            ErpBudgets = new HashSet<ErpBudget>();
            ErpCalendars = new HashSet<ErpCalendar>();
            ErpCallerIdLogs = new HashSet<ErpCallerIdLog>();
            ErpCashes = new HashSet<ErpCash>();
            ErpChequeReceiptTransferWorkplaces = new HashSet<ErpChequeReceipt>();
            ErpChequeReceiptWorkplaces = new HashSet<ErpChequeReceipt>();
            ErpCheques = new HashSet<ErpCheque>();
            ErpContractItems = new HashSet<ErpContractItem>();
            ErpContracts = new HashSet<ErpContract>();
            ErpCurrentAccountReceiptItems = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpCurrentAccountReceipts = new HashSet<ErpCurrentAccountReceipt>();
            ErpCurrentAccountTransactions = new HashSet<ErpCurrentAccountTransaction>();
            ErpCurrentAccountWorkplaces = new HashSet<ErpCurrentAccountWorkplace>();
            ErpCurrentAccounts = new HashSet<ErpCurrentAccount>();
            ErpCustomerTransactions = new HashSet<ErpCustomerTransaction>();
            ErpDemandReceiptItems = new HashSet<ErpDemandReceiptItem>();
            ErpDemandReceipts = new HashSet<ErpDemandReceipt>();
            ErpDepartments = new HashSet<ErpDepartment>();
            ErpDocuments = new HashSet<ErpDocument>();
            ErpEducations = new HashSet<ErpEducation>();
            ErpEmployees = new HashSet<ErpEmployee>();
            ErpExpos = new HashSet<ErpExpo>();
            ErpFixedAssetDebits = new HashSet<ErpFixedAssetDebit>();
            ErpGlaccounts = new HashSet<ErpGlaccount>();
            ErpGleledgers = new HashSet<ErpGleledger>();
            ErpGlreceipts = new HashSet<ErpGlreceipt>();
            ErpInitialCosts = new HashSet<ErpInitialCost>();
            ErpInventories = new HashSet<ErpInventory>();
            ErpInventoryPriceLists = new HashSet<ErpInventoryPriceList>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpInventoryReceipts = new HashSet<ErpInventoryReceipt>();
            ErpInventorySets = new HashSet<ErpInventorySet>();
            ErpInventoryWorkplaces = new HashSet<ErpInventoryWorkplace>();
            ErpInvoices = new HashSet<ErpInvoice>();
            ErpLoyalityCards = new HashSet<ErpLoyalityCard>();
            ErpNews = new HashSet<ErpNews>();
            ErpNotificationItems = new HashSet<ErpNotificationItem>();
            ErpNotifications = new HashSet<ErpNotification>();
            ErpOrderReceiptItems = new HashSet<ErpOrderReceiptItem>();
            ErpOrderReceipts = new HashSet<ErpOrderReceipt>();
            ErpParameterBarcodes = new HashSet<ErpParameterBarcode>();
            ErpParameterBonus = new HashSet<ErpParameterBonu>();
            ErpParameterDocNos = new HashSet<ErpParameterDocNo>();
            ErpParameterPos = new HashSet<ErpParameterPo>();
            ErpParameterPosDevices = new HashSet<ErpParameterPosDevice>();
            ErpParameterPosExps = new HashSet<ErpParameterPosExp>();
            ErpParameterPosPrinters = new HashSet<ErpParameterPosPrinter>();
            ErpParameters = new HashSet<ErpParameter>();
            ErpPlannings = new HashSet<ErpPlanning>();
            ErpPolls = new HashSet<ErpPoll>();
            ErpPos = new HashSet<ErpPo>();
            ErpPosEndOfDateRaports = new HashSet<ErpPosEndOfDateRaport>();
            ErpProductConfigurators = new HashSet<ErpProductConfigurator>();
            ErpProjects = new HashSet<ErpProject>();
            ErpQualityControlReceipts = new HashSet<ErpQualityControlReceipt>();
            ErpQualityControls = new HashSet<ErpQualityControl>();
            ErpQuotationReceiptItems = new HashSet<ErpQuotationReceiptItem>();
            ErpQuotationReceipts = new HashSet<ErpQuotationReceipt>();
            ErpRecipes = new HashSet<ErpRecipe>();
            ErpResources = new HashSet<ErpResource>();
            ErpServiceWorkplaces = new HashSet<ErpServiceWorkplace>();
            ErpTasks = new HashSet<ErpTask>();
            ErpWarehouses = new HashSet<ErpWarehouse>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
            HrmCvs = new HashSet<HrmCv>();
            HrmEmployeeDemands = new HashSet<HrmEmployeeDemand>();
            MetaDistricts = new HashSet<MetaDistrict>();
            MetaMessageProviders = new HashSet<MetaMessageProvider>();
            MetaMessageTemplates = new HashSet<MetaMessageTemplate>();
            MetaPos = new HashSet<MetaPo>();
            MetaPrinters = new HashSet<MetaPrinter>();
            MetaReports = new HashSet<MetaReport>();
            MetaResources = new HashSet<MetaResource>();
            MetaTowns = new HashSet<MetaTown>();
            MetaUserCompanies = new HashSet<MetaUserCompany>();
            PosShifts = new HashSet<PosShift>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? WorkplaceCode { get; set; }
        public string? WorkplaceName { get; set; }
        public short? WorkplaceType { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Village { get; set; }
        public string? Area { get; set; }
        public string? Avenue { get; set; }
        public string? Street { get; set; }
        public string? DoorNo { get; set; }
        public string? ApartmentNo { get; set; }
        public int? DistrictId { get; set; }
        public int? CityId { get; set; }
        public string? PostalCode { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public int? TownId { get; set; }
        public int? StreetId { get; set; }
        public decimal? GpsXcoordinate { get; set; }
        public decimal? GpsYcoordinate { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? TimeZone { get; set; }
        public byte? InUse { get; set; }
        public byte? IsShop { get; set; }
        public string? MersisNo { get; set; }
        public string? TradeRegistrationNo { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaCity? City { get; set; }
        public virtual MetaCountry? Country { get; set; }
        public virtual MetaDistrict? District { get; set; }
        public virtual MetaState? State { get; set; }
        public virtual MetaStreet? StreetNavigation { get; set; }
        public virtual MetaTown? Town { get; set; }
        public virtual ICollection<ErpAddress> ErpAddresses { get; set; }
        public virtual ICollection<ErpBankAccountWorkplace> ErpBankAccountWorkplaces { get; set; }
        public virtual ICollection<ErpBankAccount> ErpBankAccounts { get; set; }
        public virtual ICollection<ErpBankCredit> ErpBankCredits { get; set; }
        public virtual ICollection<ErpBankReceipt> ErpBankReceipts { get; set; }
        public virtual ICollection<ErpBankWorkplace> ErpBankWorkplaces { get; set; }
        public virtual ICollection<ErpBank> ErpBanks { get; set; }
        public virtual ICollection<ErpBudgetItem> ErpBudgetItems { get; set; }
        public virtual ICollection<ErpBudget> ErpBudgets { get; set; }
        public virtual ICollection<ErpCalendar> ErpCalendars { get; set; }
        public virtual ICollection<ErpCallerIdLog> ErpCallerIdLogs { get; set; }
        public virtual ICollection<ErpCash> ErpCashes { get; set; }
        public virtual ICollection<ErpChequeReceipt> ErpChequeReceiptTransferWorkplaces { get; set; }
        public virtual ICollection<ErpChequeReceipt> ErpChequeReceiptWorkplaces { get; set; }
        public virtual ICollection<ErpCheque> ErpCheques { get; set; }
        public virtual ICollection<ErpContractItem> ErpContractItems { get; set; }
        public virtual ICollection<ErpContract> ErpContracts { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItems { get; set; }
        public virtual ICollection<ErpCurrentAccountReceipt> ErpCurrentAccountReceipts { get; set; }
        public virtual ICollection<ErpCurrentAccountTransaction> ErpCurrentAccountTransactions { get; set; }
        public virtual ICollection<ErpCurrentAccountWorkplace> ErpCurrentAccountWorkplaces { get; set; }
        public virtual ICollection<ErpCurrentAccount> ErpCurrentAccounts { get; set; }
        public virtual ICollection<ErpCustomerTransaction> ErpCustomerTransactions { get; set; }
        public virtual ICollection<ErpDemandReceiptItem> ErpDemandReceiptItems { get; set; }
        public virtual ICollection<ErpDemandReceipt> ErpDemandReceipts { get; set; }
        public virtual ICollection<ErpDepartment> ErpDepartments { get; set; }
        public virtual ICollection<ErpDocument> ErpDocuments { get; set; }
        public virtual ICollection<ErpEducation> ErpEducations { get; set; }
        public virtual ICollection<ErpEmployee> ErpEmployees { get; set; }
        public virtual ICollection<ErpExpo> ErpExpos { get; set; }
        public virtual ICollection<ErpFixedAssetDebit> ErpFixedAssetDebits { get; set; }
        public virtual ICollection<ErpGlaccount> ErpGlaccounts { get; set; }
        public virtual ICollection<ErpGleledger> ErpGleledgers { get; set; }
        public virtual ICollection<ErpGlreceipt> ErpGlreceipts { get; set; }
        public virtual ICollection<ErpInitialCost> ErpInitialCosts { get; set; }
        public virtual ICollection<ErpInventory> ErpInventories { get; set; }
        public virtual ICollection<ErpInventoryPriceList> ErpInventoryPriceLists { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceipts { get; set; }
        public virtual ICollection<ErpInventorySet> ErpInventorySets { get; set; }
        public virtual ICollection<ErpInventoryWorkplace> ErpInventoryWorkplaces { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoices { get; set; }
        public virtual ICollection<ErpLoyalityCard> ErpLoyalityCards { get; set; }
        public virtual ICollection<ErpNews> ErpNews { get; set; }
        public virtual ICollection<ErpNotificationItem> ErpNotificationItems { get; set; }
        public virtual ICollection<ErpNotification> ErpNotifications { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItems { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceipts { get; set; }
        public virtual ICollection<ErpParameterBarcode> ErpParameterBarcodes { get; set; }
        public virtual ICollection<ErpParameterBonu> ErpParameterBonus { get; set; }
        public virtual ICollection<ErpParameterDocNo> ErpParameterDocNos { get; set; }
        public virtual ICollection<ErpParameterPo> ErpParameterPos { get; set; }
        public virtual ICollection<ErpParameterPosDevice> ErpParameterPosDevices { get; set; }
        public virtual ICollection<ErpParameterPosExp> ErpParameterPosExps { get; set; }
        public virtual ICollection<ErpParameterPosPrinter> ErpParameterPosPrinters { get; set; }
        public virtual ICollection<ErpParameter> ErpParameters { get; set; }
        public virtual ICollection<ErpPlanning> ErpPlannings { get; set; }
        public virtual ICollection<ErpPoll> ErpPolls { get; set; }
        public virtual ICollection<ErpPo> ErpPos { get; set; }
        public virtual ICollection<ErpPosEndOfDateRaport> ErpPosEndOfDateRaports { get; set; }
        public virtual ICollection<ErpProductConfigurator> ErpProductConfigurators { get; set; }
        public virtual ICollection<ErpProject> ErpProjects { get; set; }
        public virtual ICollection<ErpQualityControlReceipt> ErpQualityControlReceipts { get; set; }
        public virtual ICollection<ErpQualityControl> ErpQualityControls { get; set; }
        public virtual ICollection<ErpQuotationReceiptItem> ErpQuotationReceiptItems { get; set; }
        public virtual ICollection<ErpQuotationReceipt> ErpQuotationReceipts { get; set; }
        public virtual ICollection<ErpRecipe> ErpRecipes { get; set; }
        public virtual ICollection<ErpResource> ErpResources { get; set; }
        public virtual ICollection<ErpServiceWorkplace> ErpServiceWorkplaces { get; set; }
        public virtual ICollection<ErpTask> ErpTasks { get; set; }
        public virtual ICollection<ErpWarehouse> ErpWarehouses { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
        public virtual ICollection<HrmCv> HrmCvs { get; set; }
        public virtual ICollection<HrmEmployeeDemand> HrmEmployeeDemands { get; set; }
        public virtual ICollection<MetaDistrict> MetaDistricts { get; set; }
        public virtual ICollection<MetaMessageProvider> MetaMessageProviders { get; set; }
        public virtual ICollection<MetaMessageTemplate> MetaMessageTemplates { get; set; }
        public virtual ICollection<MetaPo> MetaPos { get; set; }
        public virtual ICollection<MetaPrinter> MetaPrinters { get; set; }
        public virtual ICollection<MetaReport> MetaReports { get; set; }
        public virtual ICollection<MetaResource> MetaResources { get; set; }
        public virtual ICollection<MetaTown> MetaTowns { get; set; }
        public virtual ICollection<MetaUserCompany> MetaUserCompanies { get; set; }
        public virtual ICollection<PosShift> PosShifts { get; set; }
    }
}
