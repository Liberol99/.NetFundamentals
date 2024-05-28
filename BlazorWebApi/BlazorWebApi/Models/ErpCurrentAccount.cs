using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCurrentAccount
    {
        public ErpCurrentAccount()
        {
            CrmLeads = new HashSet<CrmLead>();
            ErpActualCosts = new HashSet<ErpActualCost>();
            ErpAddresses = new HashSet<ErpAddress>();
            ErpAsserviceCurrentAccountDetails = new HashSet<ErpAsserviceCurrentAccountDetail>();
            ErpAsserviceFaultyItems = new HashSet<ErpAsserviceFaultyItem>();
            ErpBankCreditItems = new HashSet<ErpBankCreditItem>();
            ErpBankCredits = new HashSet<ErpBankCredit>();
            ErpBankReceiptItems = new HashSet<ErpBankReceiptItem>();
            ErpBoxes = new HashSet<ErpBox>();
            ErpBudgetItems = new HashSet<ErpBudgetItem>();
            ErpCallerIdLogs = new HashSet<ErpCallerIdLog>();
            ErpCertifications = new HashSet<ErpCertification>();
            ErpChequeCurrentAccounts = new HashSet<ErpCheque>();
            ErpChequeOutflowCurrentAccounts = new HashSet<ErpCheque>();
            ErpChequeReceiptItems = new HashSet<ErpChequeReceiptItem>();
            ErpChequeReceipts = new HashSet<ErpChequeReceipt>();
            ErpCompanyCurrentAccountCurrentAccountId2Navigations = new HashSet<ErpCompanyCurrentAccount>();
            ErpCompanyCurrentAccountCurrentAccounts = new HashSet<ErpCompanyCurrentAccount>();
            ErpContractCurrentAccounts = new HashSet<ErpContract>();
            ErpContractDealers = new HashSet<ErpContract>();
            ErpCurrentAccountAttachments = new HashSet<ErpCurrentAccountAttachment>();
            ErpCurrentAccountBanks = new HashSet<ErpCurrentAccountBank>();
            ErpCurrentAccountContacts = new HashSet<ErpCurrentAccountContact>();
            ErpCurrentAccountExplanations = new HashSet<ErpCurrentAccountExplanation>();
            ErpCurrentAccountInventoryAttributes = new HashSet<ErpCurrentAccountInventoryAttribute>();
            ErpCurrentAccountMailings = new HashSet<ErpCurrentAccountMailing>();
            ErpCurrentAccountReceiptItemCurrentAccounts = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpCurrentAccountReceiptItemDealers = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpCurrentAccountReferences = new HashSet<ErpCurrentAccountReference>();
            ErpCurrentAccountRiskControls = new HashSet<ErpCurrentAccountRiskControl>();
            ErpCurrentAccountRiskTotals = new HashSet<ErpCurrentAccountRiskTotal>();
            ErpCurrentAccountTotals = new HashSet<ErpCurrentAccountTotal>();
            ErpCurrentAccountTransactions = new HashSet<ErpCurrentAccountTransaction>();
            ErpCurrentAccountWorkplaces = new HashSet<ErpCurrentAccountWorkplace>();
            ErpCustomerTransactions = new HashSet<ErpCustomerTransaction>();
            ErpDemandReceiptCurrentAccounts = new HashSet<ErpDemandReceipt>();
            ErpDemandReceiptDealers = new HashSet<ErpDemandReceipt>();
            ErpDemandReceiptItems = new HashSet<ErpDemandReceiptItem>();
            ErpDepartmentCapacities = new HashSet<ErpDepartmentCapacity>();
            ErpEmployees = new HashSet<ErpEmployee>();
            ErpExpoCommissioners = new HashSet<ErpExpo>();
            ErpExpoCurrentAccounts = new HashSet<ErpExpo>();
            ErpExpoCustomBrokers = new HashSet<ErpExpo>();
            ErpExpoCustomers = new HashSet<ErpExpo>();
            ErpExpoInsurances = new HashSet<ErpExpo>();
            ErpExpoManufacturers = new HashSet<ErpExpo>();
            ErpExpoSellers = new HashSet<ErpExpo>();
            ErpExpoTransporters = new HashSet<ErpExpo>();
            ErpGlreceiptItems = new HashSet<ErpGlreceiptItem>();
            ErpGuarantors = new HashSet<ErpGuarantor>();
            ErpInitialCosts = new HashSet<ErpInitialCost>();
            ErpInventories = new HashSet<ErpInventory>();
            ErpInventoryAllocations = new HashSet<ErpInventoryAllocation>();
            ErpInventoryBarcodes = new HashSet<ErpInventoryBarcode>();
            ErpInventoryCampaignItems = new HashSet<ErpInventoryCampaignItem>();
            ErpInventoryCampaignPromotions = new HashSet<ErpInventoryCampaignPromotion>();
            ErpInventoryMargins = new HashSet<ErpInventoryMargin>();
            ErpInventoryPriceListCurrAccs = new HashSet<ErpInventoryPriceList>();
            ErpInventoryPriceListCustomers = new HashSet<ErpInventoryPriceList>();
            ErpInventoryReceiptCurrentAccounts = new HashSet<ErpInventoryReceipt>();
            ErpInventoryReceiptCustomers = new HashSet<ErpInventoryReceipt>();
            ErpInventoryReceiptDealers = new HashSet<ErpInventoryReceipt>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpInventoryReceiptShipToCurrentAccounts = new HashSet<ErpInventoryReceipt>();
            ErpInventorySerialCards = new HashSet<ErpInventorySerialCard>();
            ErpInventorySuppliers = new HashSet<ErpInventorySupplier>();
            ErpInventoryWorkStudies = new HashSet<ErpInventoryWorkStudy>();
            ErpInvoiceBrokers = new HashSet<ErpInvoice>();
            ErpInvoiceCurrentAccounts = new HashSet<ErpInvoice>();
            ErpInvoiceCustomers = new HashSet<ErpInvoice>();
            ErpInvoiceCustomsCurrentAccounts = new HashSet<ErpInvoice>();
            ErpInvoiceDealers = new HashSet<ErpInvoice>();
            ErpInvoiceEarchivesCargos = new HashSet<ErpInvoice>();
            ErpInvoiceManufacturers = new HashSet<ErpInvoice>();
            ErpInvoicePaymentToCurrentAccounts = new HashSet<ErpInvoice>();
            ErpInvoiceShipToCurrentAccounts = new HashSet<ErpInvoice>();
            ErpLabRecipes = new HashSet<ErpLabRecipe>();
            ErpLoyalityCardTypes = new HashSet<ErpLoyalityCardType>();
            ErpLoyalityCards = new HashSet<ErpLoyalityCard>();
            ErpMachineOwners = new HashSet<ErpMachineOwner>();
            ErpMarks = new HashSet<ErpMark>();
            ErpMaterialRequirementItems = new HashSet<ErpMaterialRequirementItem>();
            ErpOrderReceiptCurrentAccounts = new HashSet<ErpOrderReceipt>();
            ErpOrderReceiptCustomers = new HashSet<ErpOrderReceipt>();
            ErpOrderReceiptDealers = new HashSet<ErpOrderReceipt>();
            ErpOrderReceiptShipToCurrentAccounts = new HashSet<ErpOrderReceipt>();
            ErpPackingLists = new HashSet<ErpPackingList>();
            ErpPaymentCards = new HashSet<ErpPaymentCard>();
            ErpPlannings = new HashSet<ErpPlanning>();
            ErpPoCurrentAccounts = new HashSet<ErpPo>();
            ErpPoDealers = new HashSet<ErpPo>();
            ErpProcessResources = new HashSet<ErpProcessResource>();
            ErpProjects = new HashSet<ErpProject>();
            ErpPurchaseContracts = new HashSet<ErpPurchaseContract>();
            ErpQualityControlReceipts = new HashSet<ErpQualityControlReceipt>();
            ErpQualityControls = new HashSet<ErpQualityControl>();
            ErpQuotationReceiptCurrentAccounts = new HashSet<ErpQuotationReceipt>();
            ErpQuotationReceiptDealers = new HashSet<ErpQuotationReceipt>();
            ErpReceiptPaymentItems = new HashSet<ErpReceiptPaymentItem>();
            ErpRecipeItems = new HashSet<ErpRecipeItem>();
            ErpRecipes = new HashSet<ErpRecipe>();
            ErpResources = new HashSet<ErpResource>();
            ErpRouteItems = new HashSet<ErpRouteItem>();
            ErpSalesContracts = new HashSet<ErpSalesContract>();
            ErpServicePriceLists = new HashSet<ErpServicePriceList>();
            ErpTests = new HashSet<ErpTest>();
            ErpTransporters = new HashSet<ErpTransporter>();
            ErpVehicles = new HashSet<ErpVehicle>();
            ErpWorkOrderCurrentAccounts = new HashSet<ErpWorkOrder>();
            ErpWorkOrderCustomers = new HashSet<ErpWorkOrder>();
            ErpWorkOrderItemProcesses = new HashSet<ErpWorkOrderItemProcess>();
            ErpWorkOrderItemRecipes = new HashSet<ErpWorkOrderItemRecipe>();
            ErpWorkOrderItems = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrderProductionAttachments = new HashSet<ErpWorkOrderProductionAttachment>();
            ErpWorkOrderProductions = new HashSet<ErpWorkOrderProduction>();
            InverseBroker = new HashSet<ErpCurrentAccount>();
            InverseParent = new HashSet<ErpCurrentAccount>();
            MetaBlackLists = new HashSet<MetaBlackList>();
            MetaCtsps = new HashSet<MetaCtsp>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public string? CurrentAccountCode { get; set; }
        public string? CurrentAccountName { get; set; }
        public byte? CurrentAccountType { get; set; }
        public byte? CurrentAccountKind { get; set; }
        public int? CategoryId { get; set; }
        public int? SectorId { get; set; }
        public int? TradingGroupId { get; set; }
        public long? GroupId { get; set; }
        public string? TradeName { get; set; }
        public string? AccessCode { get; set; }
        public string? SpecialCode { get; set; }
        public int? ForexRateId { get; set; }
        public int? ForexId { get; set; }
        public string? Email { get; set; }
        public string? WebAddress { get; set; }
        public string? WebContent { get; set; }
        public string? Blog { get; set; }
        public string? Facebook { get; set; }
        public string? Twitter { get; set; }
        public long? ParentId { get; set; }
        public long? BrokerId { get; set; }
        public short? PaymentType { get; set; }
        public short? StatusId { get; set; }
        public byte? IsBlackList { get; set; }
        public byte? IsVip { get; set; }
        public byte? IsFrequent { get; set; }
        public byte? IsPotential { get; set; }
        public byte? IsDealer { get; set; }
        public byte? IsAgent { get; set; }
        public string? CardNo { get; set; }
        public byte? IsCardActive { get; set; }
        public int? TaxOfficeId { get; set; }
        public string? TaxNo { get; set; }
        public long? EmployeeId { get; set; }
        public long? SellerId { get; set; }
        public int? CustomerGlaccountId { get; set; }
        public int? SupplierGlaccountId { get; set; }
        public short? TermDay { get; set; }
        public byte? VisitPeriodType { get; set; }
        public short? VisitPeriod { get; set; }
        public short? VisitDays { get; set; }
        public decimal? InterestRate { get; set; }
        public string? DiscountGroupCode { get; set; }
        public string? PriceGroupCode { get; set; }
        public int? SalesDiscountId { get; set; }
        public int? PurchaseDiscountId { get; set; }
        public decimal? RiskLimit { get; set; }
        public decimal? ChequeRiskLimit { get; set; }
        public decimal? EndorsmentChequeRiskLimit { get; set; }
        public decimal? NoteRiskLimit { get; set; }
        public decimal? EndorsmentNoteRiskLimit { get; set; }
        public decimal? ChequeRiskFactor { get; set; }
        public decimal? NoteRiskFactor { get; set; }
        public byte? RiskTypeCheque { get; set; }
        public byte? RiskTypeEndorsmentCheque { get; set; }
        public byte? RiskType { get; set; }
        public short? RiskOver { get; set; }
        public short? OrderRiskOver { get; set; }
        public short? DispatchRiskOver { get; set; }
        public short? ChequeRiskOver { get; set; }
        public int? WarehouseId { get; set; }
        public int? CostCenterId { get; set; }
        public short? ShipmentType { get; set; }
        public byte? IsPartialShipment { get; set; }
        public decimal? MinShipmentRate { get; set; }
        public int? TransporterId { get; set; }
        public int? BankId { get; set; }
        public long? PaymentPlanId { get; set; }
        public short? EducationType { get; set; }
        public short? MaritalStatus { get; set; }
        public string? IdType { get; set; }
        public string? IdCardNo { get; set; }
        public string? IdNo { get; set; }
        public string? IdFathersName { get; set; }
        public string? IdMothersName { get; set; }
        public string? IdCity { get; set; }
        public string? IdDistrict { get; set; }
        public string? IdMahalle { get; set; }
        public string? IdKoy { get; set; }
        public string? IdCilt { get; set; }
        public string? IdSayfa { get; set; }
        public string? IdKutuk { get; set; }
        public string? IdIssuedPlace { get; set; }
        public DateTime? IdIssuedDate { get; set; }
        public string? SocialSecurityNo { get; set; }
        public short? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? BirthPlace { get; set; }
        public string? CompanyName { get; set; }
        public string? JobTitle { get; set; }
        public string? Profession { get; set; }
        public string? GsmPhone { get; set; }
        public DateTime? MariageDate { get; set; }
        public string? SpouseName { get; set; }
        public DateTime? SpouseBirthDate { get; set; }
        public string? SpouseCompany { get; set; }
        public string? SpouseJobTitle { get; set; }
        public string? SpouseProfession { get; set; }
        public long? SymbolId { get; set; }
        public byte? IsEagreement { get; set; }
        public byte? IsEinvoice { get; set; }
        public byte? EinvoiceScenario { get; set; }
        public string? EinvoiceAlias { get; set; }
        public byte? IsEdespatch { get; set; }
        public int? NationalityId { get; set; }
        public int? MarketId { get; set; }
        public int? ForegroundColor { get; set; }
        public int? BackgroundColor { get; set; }
        public byte? NotForPaymentPlan { get; set; }
        public decimal? PaymentPlanDebit { get; set; }
        public int? PaymentPlanDebitForexId { get; set; }
        public int? LastPaymentDayPeriod { get; set; }
        public decimal? ValuationAmount { get; set; }
        public byte? IsForex { get; set; }
        public byte? IsProducer { get; set; }
        public byte? IsRiskControl { get; set; }
        public string? EarchivesShippingType { get; set; }
        public byte? InUse { get; set; }
        public string? PassportNo { get; set; }
        public DateTime? PassportIssueDate { get; set; }
        public string? NaceCode { get; set; }
        public string? MersisNo { get; set; }
        public string? TradeRegistrationNo { get; set; }
        public string? EinvoiceXsltName { get; set; }
        public string? EarchiveXsltName { get; set; }
        public string? EproducerReceiptXsltName { get; set; }
        public byte? IsLocked { get; set; }
        public DateTime? LockedAt { get; set; }
        public int? LockedBy { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public string? ApprovedExplanation { get; set; }
        public string? UdSvcariAltKod { get; set; }
        public string? UdSvcariKod { get; set; }
        public string? UdSvhesapTipi { get; set; }
        public byte? UdOtomatik { get; set; }
        public long? InterestRateId { get; set; }
        public byte? IsSendMail { get; set; }
        public string? UdSecondName { get; set; }
        public byte? AsserviceServiceType { get; set; }
        public string? EguestCheckXsltName { get; set; }
        public string? EdespatchXsltName { get; set; }

        public virtual ErpCurrentAccount? Broker { get; set; }
        public virtual ErpCurrentAccountCategory? Category { get; set; }
        public virtual ErpGlaccount? CustomerGlaccount { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual MetaForexPrm? ForexRate { get; set; }
        public virtual ErpCurrentAccountGroup? Group { get; set; }
        public virtual ErpInterestRate? InterestRateNavigation { get; set; }
        public virtual MetaCountry? Nationality { get; set; }
        public virtual ErpCurrentAccount? Parent { get; set; }
        public virtual ErpPaymentPlan? PaymentPlan { get; set; }
        public virtual MetaForex? PaymentPlanDebitForex { get; set; }
        public virtual ErpDiscount? PurchaseDiscount { get; set; }
        public virtual ErpDiscount? SalesDiscount { get; set; }
        public virtual MetaSector? Sector { get; set; }
        public virtual ErpEmployee? Seller { get; set; }
        public virtual ErpGlaccount? SupplierGlaccount { get; set; }
        public virtual MetaSymbol? Symbol { get; set; }
        public virtual MetaTaxOffice? TaxOffice { get; set; }
        public virtual ErpTradingGroup? TradingGroup { get; set; }
        public virtual ErpTransporter? Transporter { get; set; }
        public virtual ErpWarehouse? Warehouse { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<CrmLead> CrmLeads { get; set; }
        public virtual ICollection<ErpActualCost> ErpActualCosts { get; set; }
        public virtual ICollection<ErpAddress> ErpAddresses { get; set; }
        public virtual ICollection<ErpAsserviceCurrentAccountDetail> ErpAsserviceCurrentAccountDetails { get; set; }
        public virtual ICollection<ErpAsserviceFaultyItem> ErpAsserviceFaultyItems { get; set; }
        public virtual ICollection<ErpBankCreditItem> ErpBankCreditItems { get; set; }
        public virtual ICollection<ErpBankCredit> ErpBankCredits { get; set; }
        public virtual ICollection<ErpBankReceiptItem> ErpBankReceiptItems { get; set; }
        public virtual ICollection<ErpBox> ErpBoxes { get; set; }
        public virtual ICollection<ErpBudgetItem> ErpBudgetItems { get; set; }
        public virtual ICollection<ErpCallerIdLog> ErpCallerIdLogs { get; set; }
        public virtual ICollection<ErpCertification> ErpCertifications { get; set; }
        public virtual ICollection<ErpCheque> ErpChequeCurrentAccounts { get; set; }
        public virtual ICollection<ErpCheque> ErpChequeOutflowCurrentAccounts { get; set; }
        public virtual ICollection<ErpChequeReceiptItem> ErpChequeReceiptItems { get; set; }
        public virtual ICollection<ErpChequeReceipt> ErpChequeReceipts { get; set; }
        public virtual ICollection<ErpCompanyCurrentAccount> ErpCompanyCurrentAccountCurrentAccountId2Navigations { get; set; }
        public virtual ICollection<ErpCompanyCurrentAccount> ErpCompanyCurrentAccountCurrentAccounts { get; set; }
        public virtual ICollection<ErpContract> ErpContractCurrentAccounts { get; set; }
        public virtual ICollection<ErpContract> ErpContractDealers { get; set; }
        public virtual ICollection<ErpCurrentAccountAttachment> ErpCurrentAccountAttachments { get; set; }
        public virtual ICollection<ErpCurrentAccountBank> ErpCurrentAccountBanks { get; set; }
        public virtual ICollection<ErpCurrentAccountContact> ErpCurrentAccountContacts { get; set; }
        public virtual ICollection<ErpCurrentAccountExplanation> ErpCurrentAccountExplanations { get; set; }
        public virtual ICollection<ErpCurrentAccountInventoryAttribute> ErpCurrentAccountInventoryAttributes { get; set; }
        public virtual ICollection<ErpCurrentAccountMailing> ErpCurrentAccountMailings { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItemCurrentAccounts { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItemDealers { get; set; }
        public virtual ICollection<ErpCurrentAccountReference> ErpCurrentAccountReferences { get; set; }
        public virtual ICollection<ErpCurrentAccountRiskControl> ErpCurrentAccountRiskControls { get; set; }
        public virtual ICollection<ErpCurrentAccountRiskTotal> ErpCurrentAccountRiskTotals { get; set; }
        public virtual ICollection<ErpCurrentAccountTotal> ErpCurrentAccountTotals { get; set; }
        public virtual ICollection<ErpCurrentAccountTransaction> ErpCurrentAccountTransactions { get; set; }
        public virtual ICollection<ErpCurrentAccountWorkplace> ErpCurrentAccountWorkplaces { get; set; }
        public virtual ICollection<ErpCustomerTransaction> ErpCustomerTransactions { get; set; }
        public virtual ICollection<ErpDemandReceipt> ErpDemandReceiptCurrentAccounts { get; set; }
        public virtual ICollection<ErpDemandReceipt> ErpDemandReceiptDealers { get; set; }
        public virtual ICollection<ErpDemandReceiptItem> ErpDemandReceiptItems { get; set; }
        public virtual ICollection<ErpDepartmentCapacity> ErpDepartmentCapacities { get; set; }
        public virtual ICollection<ErpEmployee> ErpEmployees { get; set; }
        public virtual ICollection<ErpExpo> ErpExpoCommissioners { get; set; }
        public virtual ICollection<ErpExpo> ErpExpoCurrentAccounts { get; set; }
        public virtual ICollection<ErpExpo> ErpExpoCustomBrokers { get; set; }
        public virtual ICollection<ErpExpo> ErpExpoCustomers { get; set; }
        public virtual ICollection<ErpExpo> ErpExpoInsurances { get; set; }
        public virtual ICollection<ErpExpo> ErpExpoManufacturers { get; set; }
        public virtual ICollection<ErpExpo> ErpExpoSellers { get; set; }
        public virtual ICollection<ErpExpo> ErpExpoTransporters { get; set; }
        public virtual ICollection<ErpGlreceiptItem> ErpGlreceiptItems { get; set; }
        public virtual ICollection<ErpGuarantor> ErpGuarantors { get; set; }
        public virtual ICollection<ErpInitialCost> ErpInitialCosts { get; set; }
        public virtual ICollection<ErpInventory> ErpInventories { get; set; }
        public virtual ICollection<ErpInventoryAllocation> ErpInventoryAllocations { get; set; }
        public virtual ICollection<ErpInventoryBarcode> ErpInventoryBarcodes { get; set; }
        public virtual ICollection<ErpInventoryCampaignItem> ErpInventoryCampaignItems { get; set; }
        public virtual ICollection<ErpInventoryCampaignPromotion> ErpInventoryCampaignPromotions { get; set; }
        public virtual ICollection<ErpInventoryMargin> ErpInventoryMargins { get; set; }
        public virtual ICollection<ErpInventoryPriceList> ErpInventoryPriceListCurrAccs { get; set; }
        public virtual ICollection<ErpInventoryPriceList> ErpInventoryPriceListCustomers { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceiptCurrentAccounts { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceiptCustomers { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceiptDealers { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceiptShipToCurrentAccounts { get; set; }
        public virtual ICollection<ErpInventorySerialCard> ErpInventorySerialCards { get; set; }
        public virtual ICollection<ErpInventorySupplier> ErpInventorySuppliers { get; set; }
        public virtual ICollection<ErpInventoryWorkStudy> ErpInventoryWorkStudies { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoiceBrokers { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoiceCurrentAccounts { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoiceCustomers { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoiceCustomsCurrentAccounts { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoiceDealers { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoiceEarchivesCargos { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoiceManufacturers { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoicePaymentToCurrentAccounts { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoiceShipToCurrentAccounts { get; set; }
        public virtual ICollection<ErpLabRecipe> ErpLabRecipes { get; set; }
        public virtual ICollection<ErpLoyalityCardType> ErpLoyalityCardTypes { get; set; }
        public virtual ICollection<ErpLoyalityCard> ErpLoyalityCards { get; set; }
        public virtual ICollection<ErpMachineOwner> ErpMachineOwners { get; set; }
        public virtual ICollection<ErpMark> ErpMarks { get; set; }
        public virtual ICollection<ErpMaterialRequirementItem> ErpMaterialRequirementItems { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceiptCurrentAccounts { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceiptCustomers { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceiptDealers { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceiptShipToCurrentAccounts { get; set; }
        public virtual ICollection<ErpPackingList> ErpPackingLists { get; set; }
        public virtual ICollection<ErpPaymentCard> ErpPaymentCards { get; set; }
        public virtual ICollection<ErpPlanning> ErpPlannings { get; set; }
        public virtual ICollection<ErpPo> ErpPoCurrentAccounts { get; set; }
        public virtual ICollection<ErpPo> ErpPoDealers { get; set; }
        public virtual ICollection<ErpProcessResource> ErpProcessResources { get; set; }
        public virtual ICollection<ErpProject> ErpProjects { get; set; }
        public virtual ICollection<ErpPurchaseContract> ErpPurchaseContracts { get; set; }
        public virtual ICollection<ErpQualityControlReceipt> ErpQualityControlReceipts { get; set; }
        public virtual ICollection<ErpQualityControl> ErpQualityControls { get; set; }
        public virtual ICollection<ErpQuotationReceipt> ErpQuotationReceiptCurrentAccounts { get; set; }
        public virtual ICollection<ErpQuotationReceipt> ErpQuotationReceiptDealers { get; set; }
        public virtual ICollection<ErpReceiptPaymentItem> ErpReceiptPaymentItems { get; set; }
        public virtual ICollection<ErpRecipeItem> ErpRecipeItems { get; set; }
        public virtual ICollection<ErpRecipe> ErpRecipes { get; set; }
        public virtual ICollection<ErpResource> ErpResources { get; set; }
        public virtual ICollection<ErpRouteItem> ErpRouteItems { get; set; }
        public virtual ICollection<ErpSalesContract> ErpSalesContracts { get; set; }
        public virtual ICollection<ErpServicePriceList> ErpServicePriceLists { get; set; }
        public virtual ICollection<ErpTest> ErpTests { get; set; }
        public virtual ICollection<ErpTransporter> ErpTransporters { get; set; }
        public virtual ICollection<ErpVehicle> ErpVehicles { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrderCurrentAccounts { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrderCustomers { get; set; }
        public virtual ICollection<ErpWorkOrderItemProcess> ErpWorkOrderItemProcesses { get; set; }
        public virtual ICollection<ErpWorkOrderItemRecipe> ErpWorkOrderItemRecipes { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItems { get; set; }
        public virtual ICollection<ErpWorkOrderProductionAttachment> ErpWorkOrderProductionAttachments { get; set; }
        public virtual ICollection<ErpWorkOrderProduction> ErpWorkOrderProductions { get; set; }
        public virtual ICollection<ErpCurrentAccount> InverseBroker { get; set; }
        public virtual ICollection<ErpCurrentAccount> InverseParent { get; set; }
        public virtual ICollection<MetaBlackList> MetaBlackLists { get; set; }
        public virtual ICollection<MetaCtsp> MetaCtsps { get; set; }
    }
}
