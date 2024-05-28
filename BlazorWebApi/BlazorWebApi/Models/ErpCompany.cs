using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCompany
    {
        public ErpCompany()
        {
            CrmLeads = new HashSet<CrmLead>();
            CrmMarketingActivities = new HashSet<CrmMarketingActivity>();
            CrmMarketingTypes = new HashSet<CrmMarketingType>();
            CrmStatuses = new HashSet<CrmStatus>();
            CrmTerritories = new HashSet<CrmTerritory>();
            CrmTransactionFlows = new HashSet<CrmTransactionFlow>();
            CrmTransactionTypes = new HashSet<CrmTransactionType>();
            CrmWorkFlowStates = new HashSet<CrmWorkFlowState>();
            ErpAccessCodes = new HashSet<ErpAccessCode>();
            ErpActualCosts = new HashSet<ErpActualCost>();
            ErpAsserviceFaulties = new HashSet<ErpAsserviceFaulty>();
            ErpBankCredits = new HashSet<ErpBankCredit>();
            ErpBankReceipts = new HashSet<ErpBankReceipt>();
            ErpBanks = new HashSet<ErpBank>();
            ErpBoxes = new HashSet<ErpBox>();
            ErpBudgets = new HashSet<ErpBudget>();
            ErpCalendars = new HashSet<ErpCalendar>();
            ErpCallerIdLogs = new HashSet<ErpCallerIdLog>();
            ErpCashes = new HashSet<ErpCash>();
            ErpCategories = new HashSet<ErpCategory>();
            ErpCertifications = new HashSet<ErpCertification>();
            ErpChequeReceipts = new HashSet<ErpChequeReceipt>();
            ErpCheques = new HashSet<ErpCheque>();
            ErpCompanyBanks = new HashSet<ErpCompanyBank>();
            ErpCompanyCurrentAccountCompanies = new HashSet<ErpCompanyCurrentAccount>();
            ErpCompanyCurrentAccountCompanyId2Navigations = new HashSet<ErpCompanyCurrentAccount>();
            ErpCompanyIas = new HashSet<ErpCompanyIa>();
            ErpCompetencies = new HashSet<ErpCompetency>();
            ErpCompetitors = new HashSet<ErpCompetitor>();
            ErpContracts = new HashSet<ErpContract>();
            ErpCostCenters = new HashSet<ErpCostCenter>();
            ErpCurrentAccountCategories = new HashSet<ErpCurrentAccountCategory>();
            ErpCurrentAccountGroups = new HashSet<ErpCurrentAccountGroup>();
            ErpCurrentAccountReceiptItems = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpCurrentAccountReceipts = new HashSet<ErpCurrentAccountReceipt>();
            ErpCustomerTransactions = new HashSet<ErpCustomerTransaction>();
            ErpDeclarations = new HashSet<ErpDeclaration>();
            ErpDemandReceipts = new HashSet<ErpDemandReceipt>();
            ErpDepartmentGroups = new HashSet<ErpDepartmentGroup>();
            ErpDepartments = new HashSet<ErpDepartment>();
            ErpDespatchContacts = new HashSet<ErpDespatchContact>();
            ErpDiscounts = new HashSet<ErpDiscount>();
            ErpDocuments = new HashSet<ErpDocument>();
            ErpEducations = new HashSet<ErpEducation>();
            ErpEinvoices = new HashSet<ErpEinvoice>();
            ErpEmployees = new HashSet<ErpEmployee>();
            ErpExpenseReports = new HashSet<ErpExpenseReport>();
            ErpExpenses = new HashSet<ErpExpense>();
            ErpExpos = new HashSet<ErpExpo>();
            ErpFinancialTableItems = new HashSet<ErpFinancialTableItem>();
            ErpFinancialTables = new HashSet<ErpFinancialTable>();
            ErpFixedAssetUsefulServiceLives = new HashSet<ErpFixedAssetUsefulServiceLife>();
            ErpGiftVoucherTypes = new HashSet<ErpGiftVoucherType>();
            ErpGiftVouchers = new HashSet<ErpGiftVoucher>();
            ErpGlaccounts = new HashSet<ErpGlaccount>();
            ErpGleledgers = new HashSet<ErpGleledger>();
            ErpGlreceipts = new HashSet<ErpGlreceipt>();
            ErpGlreflectionDefinitions = new HashSet<ErpGlreflectionDefinition>();
            ErpGlreflections = new HashSet<ErpGlreflection>();
            ErpGlregBooks = new HashSet<ErpGlregBook>();
            ErpInitialCostCards = new HashSet<ErpInitialCostCard>();
            ErpInitialCosts = new HashSet<ErpInitialCost>();
            ErpInterestRates = new HashSet<ErpInterestRate>();
            ErpInventories = new HashSet<ErpInventory>();
            ErpInventoryAttributeSets = new HashSet<ErpInventoryAttributeSet>();
            ErpInventoryCampaigns = new HashSet<ErpInventoryCampaign>();
            ErpInventoryGroups = new HashSet<ErpInventoryGroup>();
            ErpInventoryMargins = new HashSet<ErpInventoryMargin>();
            ErpInventoryPriceLists = new HashSet<ErpInventoryPriceList>();
            ErpInventoryReceipts = new HashSet<ErpInventoryReceipt>();
            ErpInventorySerialCards = new HashSet<ErpInventorySerialCard>();
            ErpInventorySets = new HashSet<ErpInventorySet>();
            ErpInvoices = new HashSet<ErpInvoice>();
            ErpLabRecipes = new HashSet<ErpLabRecipe>();
            ErpLoyalityCardTypes = new HashSet<ErpLoyalityCardType>();
            ErpLoyalityCards = new HashSet<ErpLoyalityCard>();
            ErpMachineOwners = new HashSet<ErpMachineOwner>();
            ErpManufacturingTypes = new HashSet<ErpManufacturingType>();
            ErpMarks = new HashSet<ErpMark>();
            ErpMaterialRequirements = new HashSet<ErpMaterialRequirement>();
            ErpNews = new HashSet<ErpNews>();
            ErpNotifications = new HashSet<ErpNotification>();
            ErpOrderReceipts = new HashSet<ErpOrderReceipt>();
            ErpPackagings = new HashSet<ErpPackaging>();
            ErpPackingLists = new HashSet<ErpPackingList>();
            ErpParameterBarcodes = new HashSet<ErpParameterBarcode>();
            ErpParameterBonus = new HashSet<ErpParameterBonu>();
            ErpParameterDocNos = new HashSet<ErpParameterDocNo>();
            ErpParameterPos = new HashSet<ErpParameterPo>();
            ErpParameterPosDevices = new HashSet<ErpParameterPosDevice>();
            ErpParameterPosExps = new HashSet<ErpParameterPosExp>();
            ErpParameterPosPrinters = new HashSet<ErpParameterPosPrinter>();
            ErpParameters = new HashSet<ErpParameter>();
            ErpPaymentCards = new HashSet<ErpPaymentCard>();
            ErpPaymentPlans = new HashSet<ErpPaymentPlan>();
            ErpPolls = new HashSet<ErpPoll>();
            ErpPos = new HashSet<ErpPo>();
            ErpPosEndOfDateRaports = new HashSet<ErpPosEndOfDateRaport>();
            ErpProcesses = new HashSet<ErpProcess>();
            ErpProductConfigurators = new HashSet<ErpProductConfigurator>();
            ErpProjects = new HashSet<ErpProject>();
            ErpPublishDocuments = new HashSet<ErpPublishDocument>();
            ErpPurchaseContracts = new HashSet<ErpPurchaseContract>();
            ErpQualityControlReceipts = new HashSet<ErpQualityControlReceipt>();
            ErpQualityControlTestCards = new HashSet<ErpQualityControlTestCard>();
            ErpQualityControls = new HashSet<ErpQualityControl>();
            ErpQualityTypes = new HashSet<ErpQualityType>();
            ErpQuotationReceipts = new HashSet<ErpQuotationReceipt>();
            ErpRecipeProgramTypes = new HashSet<ErpRecipeProgramType>();
            ErpRecipePrograms = new HashSet<ErpRecipeProgram>();
            ErpRecipes = new HashSet<ErpRecipe>();
            ErpRefundCheques = new HashSet<ErpRefundCheque>();
            ErpResourceAttributeSets = new HashSet<ErpResourceAttributeSet>();
            ErpResourceOutOfUseReasons = new HashSet<ErpResourceOutOfUseReason>();
            ErpResources = new HashSet<ErpResource>();
            ErpReturnTypes = new HashSet<ErpReturnType>();
            ErpRoutes = new HashSet<ErpRoute>();
            ErpSalesContracts = new HashSet<ErpSalesContract>();
            ErpSeasons = new HashSet<ErpSeason>();
            ErpServiceGroups = new HashSet<ErpServiceGroup>();
            ErpServices = new HashSet<ErpService>();
            ErpSizeSetParameters = new HashSet<ErpSizeSetParameter>();
            ErpSizeSets = new HashSet<ErpSizeSet>();
            ErpSubscriptions = new HashSet<ErpSubscription>();
            ErpTasks = new HashSet<ErpTask>();
            ErpTaxes = new HashSet<ErpTax>();
            ErpTests = new HashSet<ErpTest>();
            ErpTradingGroups = new HashSet<ErpTradingGroup>();
            ErpTransporters = new HashSet<ErpTransporter>();
            ErpVariantTypes = new HashSet<ErpVariantType>();
            ErpVehicles = new HashSet<ErpVehicle>();
            ErpWorkFlowCards = new HashSet<ErpWorkFlowCard>();
            ErpWorkFlowMsgAddresses = new HashSet<ErpWorkFlowMsgAddress>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
            HrmAddPaymentDeductions = new HashSet<HrmAddPaymentDeduction>();
            HrmAdvertisements = new HashSet<HrmAdvertisement>();
            HrmApplications = new HashSet<HrmApplication>();
            HrmCvs = new HashSet<HrmCv>();
            HrmEmployeeAccruals = new HashSet<HrmEmployeeAccrual>();
            HrmEmployeeDemands = new HashSet<HrmEmployeeDemand>();
            HrmEmployeeLeaves = new HashSet<HrmEmployeeLeave>();
            HrmLeaveEntitlements = new HashSet<HrmLeaveEntitlement>();
            HrmLeaveGroups = new HashSet<HrmLeaveGroup>();
            HrmLeaveTypes = new HashSet<HrmLeaveType>();
            HrmPlacements = new HashSet<HrmPlacement>();
            HrmPositions = new HashSet<HrmPosition>();
            HrmTestEmployees = new HashSet<HrmTestEmployee>();
            HrmTests = new HashSet<HrmTest>();
            HrmTimes = new HashSet<HrmTime>();
            MetaDataConstraints = new HashSet<MetaDataConstraint>();
            MetaMessageProviders = new HashSet<MetaMessageProvider>();
            MetaMessageTemplates = new HashSet<MetaMessageTemplate>();
            MetaPos = new HashSet<MetaPo>();
            MetaPresets = new HashSet<MetaPreset>();
            MetaPrinters = new HashSet<MetaPrinter>();
            MetaReports = new HashSet<MetaReport>();
            MetaResources = new HashSet<MetaResource>();
            MetaUserCompanies = new HashSet<MetaUserCompany>();
            MetaUserRights = new HashSet<MetaUserRight>();
            MetaUserRoles = new HashSet<MetaUserRole>();
            PosMenus = new HashSet<PosMenu>();
            PosShifts = new HashSet<PosShift>();
            RplTaskTargets = new HashSet<RplTaskTarget>();
            RplTasks = new HashSet<RplTask>();
            RplXrefFromCompanies = new HashSet<RplXref>();
            RplXrefToCompanies = new HashSet<RplXref>();
        }

        public int RecId { get; set; }
        public string? CompanyCode { get; set; }
        public string? CompanyName { get; set; }
        public string? TradeName { get; set; }
        public string? Password { get; set; }
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
        public int? StateId { get; set; }
        public string? PostalCode { get; set; }
        public int? CountryId { get; set; }
        public int? TownId { get; set; }
        public int? StreetId { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Internet { get; set; }
        public string? Email { get; set; }
        public int? TaxOfficeId { get; set; }
        public string? TaxNo { get; set; }
        public string? IdNo { get; set; }
        public string? CompanyType { get; set; }
        public byte[]? CompanyLogo { get; set; }
        public byte[]? CompanySigner { get; set; }
        public string? Activity { get; set; }
        public byte? IsEinvoice { get; set; }
        public string? EinvoiceAlias { get; set; }
        public byte? EinvoiceScenario { get; set; }
        public byte? IsEarchive { get; set; }
        public byte? IsEdespatch { get; set; }
        public string? EdespatchAlias { get; set; }
        public byte? IsEledger { get; set; }
        public byte? IsEexim { get; set; }
        public byte? IsEproducerReceipt { get; set; }
        public string? TurMobToken { get; set; }
        public byte? InUse { get; set; }
        public string? TypeCode { get; set; }
        public int? TypeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? NaceCode { get; set; }
        public string? MersisNo { get; set; }
        public string? TradeRegistrationNo { get; set; }
        public string? AcountantName { get; set; }
        public string? AcountantBuildingNumber { get; set; }
        public int? AcountantStreetId { get; set; }
        public string? AcountantAddressStreet2 { get; set; }
        public int? AcountantCityId { get; set; }
        public int? AcountantCountryId { get; set; }
        public string? AcountantZipOrPostalCode { get; set; }
        public string? AcountantContactPhoneNumber { get; set; }
        public string? AcountantEngagementTypeDescription { get; set; }
        public string? AcountantContactFaxNumber { get; set; }
        public string? AcountantEmailAddress { get; set; }
        public string? Acountant2Name { get; set; }
        public string? Acountant2BuildingNumber { get; set; }
        public int? Acountant2StreetId { get; set; }
        public string? Acountant2AddressStreet2 { get; set; }
        public int? Acountant2CityId { get; set; }
        public int? Acountant2CountryId { get; set; }
        public string? Acountant2ZipOrPostalCode { get; set; }
        public string? Acountant2ContactPhoneNumber { get; set; }
        public string? Acountant2EngagementTypeDescription { get; set; }
        public string? Acountant2ContactFaxNumber { get; set; }
        public string? Acountant2EmailAddress { get; set; }
        public string? PersonFirstName { get; set; }
        public string? PersonFamilyName { get; set; }
        public byte? IsDontListedOnLoginScreen { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public byte? IsEguestCheck { get; set; }

        public virtual MetaCity? Acountant2City { get; set; }
        public virtual MetaCountry? Acountant2Country { get; set; }
        public virtual MetaStreet? Acountant2Street { get; set; }
        public virtual MetaCity? AcountantCity { get; set; }
        public virtual MetaCountry? AcountantCountry { get; set; }
        public virtual MetaStreet? AcountantStreet { get; set; }
        public virtual MetaCity? City { get; set; }
        public virtual MetaCountry? Country { get; set; }
        public virtual MetaDistrict? District { get; set; }
        public virtual MetaState? State { get; set; }
        public virtual MetaStreet? StreetNavigation { get; set; }
        public virtual MetaTaxOffice? TaxOffice { get; set; }
        public virtual MetaTown? Town { get; set; }
        public virtual ICollection<CrmLead> CrmLeads { get; set; }
        public virtual ICollection<CrmMarketingActivity> CrmMarketingActivities { get; set; }
        public virtual ICollection<CrmMarketingType> CrmMarketingTypes { get; set; }
        public virtual ICollection<CrmStatus> CrmStatuses { get; set; }
        public virtual ICollection<CrmTerritory> CrmTerritories { get; set; }
        public virtual ICollection<CrmTransactionFlow> CrmTransactionFlows { get; set; }
        public virtual ICollection<CrmTransactionType> CrmTransactionTypes { get; set; }
        public virtual ICollection<CrmWorkFlowState> CrmWorkFlowStates { get; set; }
        public virtual ICollection<ErpAccessCode> ErpAccessCodes { get; set; }
        public virtual ICollection<ErpActualCost> ErpActualCosts { get; set; }
        public virtual ICollection<ErpAsserviceFaulty> ErpAsserviceFaulties { get; set; }
        public virtual ICollection<ErpBankCredit> ErpBankCredits { get; set; }
        public virtual ICollection<ErpBankReceipt> ErpBankReceipts { get; set; }
        public virtual ICollection<ErpBank> ErpBanks { get; set; }
        public virtual ICollection<ErpBox> ErpBoxes { get; set; }
        public virtual ICollection<ErpBudget> ErpBudgets { get; set; }
        public virtual ICollection<ErpCalendar> ErpCalendars { get; set; }
        public virtual ICollection<ErpCallerIdLog> ErpCallerIdLogs { get; set; }
        public virtual ICollection<ErpCash> ErpCashes { get; set; }
        public virtual ICollection<ErpCategory> ErpCategories { get; set; }
        public virtual ICollection<ErpCertification> ErpCertifications { get; set; }
        public virtual ICollection<ErpChequeReceipt> ErpChequeReceipts { get; set; }
        public virtual ICollection<ErpCheque> ErpCheques { get; set; }
        public virtual ICollection<ErpCompanyBank> ErpCompanyBanks { get; set; }
        public virtual ICollection<ErpCompanyCurrentAccount> ErpCompanyCurrentAccountCompanies { get; set; }
        public virtual ICollection<ErpCompanyCurrentAccount> ErpCompanyCurrentAccountCompanyId2Navigations { get; set; }
        public virtual ICollection<ErpCompanyIa> ErpCompanyIas { get; set; }
        public virtual ICollection<ErpCompetency> ErpCompetencies { get; set; }
        public virtual ICollection<ErpCompetitor> ErpCompetitors { get; set; }
        public virtual ICollection<ErpContract> ErpContracts { get; set; }
        public virtual ICollection<ErpCostCenter> ErpCostCenters { get; set; }
        public virtual ICollection<ErpCurrentAccountCategory> ErpCurrentAccountCategories { get; set; }
        public virtual ICollection<ErpCurrentAccountGroup> ErpCurrentAccountGroups { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItems { get; set; }
        public virtual ICollection<ErpCurrentAccountReceipt> ErpCurrentAccountReceipts { get; set; }
        public virtual ICollection<ErpCustomerTransaction> ErpCustomerTransactions { get; set; }
        public virtual ICollection<ErpDeclaration> ErpDeclarations { get; set; }
        public virtual ICollection<ErpDemandReceipt> ErpDemandReceipts { get; set; }
        public virtual ICollection<ErpDepartmentGroup> ErpDepartmentGroups { get; set; }
        public virtual ICollection<ErpDepartment> ErpDepartments { get; set; }
        public virtual ICollection<ErpDespatchContact> ErpDespatchContacts { get; set; }
        public virtual ICollection<ErpDiscount> ErpDiscounts { get; set; }
        public virtual ICollection<ErpDocument> ErpDocuments { get; set; }
        public virtual ICollection<ErpEducation> ErpEducations { get; set; }
        public virtual ICollection<ErpEinvoice> ErpEinvoices { get; set; }
        public virtual ICollection<ErpEmployee> ErpEmployees { get; set; }
        public virtual ICollection<ErpExpenseReport> ErpExpenseReports { get; set; }
        public virtual ICollection<ErpExpense> ErpExpenses { get; set; }
        public virtual ICollection<ErpExpo> ErpExpos { get; set; }
        public virtual ICollection<ErpFinancialTableItem> ErpFinancialTableItems { get; set; }
        public virtual ICollection<ErpFinancialTable> ErpFinancialTables { get; set; }
        public virtual ICollection<ErpFixedAssetUsefulServiceLife> ErpFixedAssetUsefulServiceLives { get; set; }
        public virtual ICollection<ErpGiftVoucherType> ErpGiftVoucherTypes { get; set; }
        public virtual ICollection<ErpGiftVoucher> ErpGiftVouchers { get; set; }
        public virtual ICollection<ErpGlaccount> ErpGlaccounts { get; set; }
        public virtual ICollection<ErpGleledger> ErpGleledgers { get; set; }
        public virtual ICollection<ErpGlreceipt> ErpGlreceipts { get; set; }
        public virtual ICollection<ErpGlreflectionDefinition> ErpGlreflectionDefinitions { get; set; }
        public virtual ICollection<ErpGlreflection> ErpGlreflections { get; set; }
        public virtual ICollection<ErpGlregBook> ErpGlregBooks { get; set; }
        public virtual ICollection<ErpInitialCostCard> ErpInitialCostCards { get; set; }
        public virtual ICollection<ErpInitialCost> ErpInitialCosts { get; set; }
        public virtual ICollection<ErpInterestRate> ErpInterestRates { get; set; }
        public virtual ICollection<ErpInventory> ErpInventories { get; set; }
        public virtual ICollection<ErpInventoryAttributeSet> ErpInventoryAttributeSets { get; set; }
        public virtual ICollection<ErpInventoryCampaign> ErpInventoryCampaigns { get; set; }
        public virtual ICollection<ErpInventoryGroup> ErpInventoryGroups { get; set; }
        public virtual ICollection<ErpInventoryMargin> ErpInventoryMargins { get; set; }
        public virtual ICollection<ErpInventoryPriceList> ErpInventoryPriceLists { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceipts { get; set; }
        public virtual ICollection<ErpInventorySerialCard> ErpInventorySerialCards { get; set; }
        public virtual ICollection<ErpInventorySet> ErpInventorySets { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoices { get; set; }
        public virtual ICollection<ErpLabRecipe> ErpLabRecipes { get; set; }
        public virtual ICollection<ErpLoyalityCardType> ErpLoyalityCardTypes { get; set; }
        public virtual ICollection<ErpLoyalityCard> ErpLoyalityCards { get; set; }
        public virtual ICollection<ErpMachineOwner> ErpMachineOwners { get; set; }
        public virtual ICollection<ErpManufacturingType> ErpManufacturingTypes { get; set; }
        public virtual ICollection<ErpMark> ErpMarks { get; set; }
        public virtual ICollection<ErpMaterialRequirement> ErpMaterialRequirements { get; set; }
        public virtual ICollection<ErpNews> ErpNews { get; set; }
        public virtual ICollection<ErpNotification> ErpNotifications { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceipts { get; set; }
        public virtual ICollection<ErpPackaging> ErpPackagings { get; set; }
        public virtual ICollection<ErpPackingList> ErpPackingLists { get; set; }
        public virtual ICollection<ErpParameterBarcode> ErpParameterBarcodes { get; set; }
        public virtual ICollection<ErpParameterBonu> ErpParameterBonus { get; set; }
        public virtual ICollection<ErpParameterDocNo> ErpParameterDocNos { get; set; }
        public virtual ICollection<ErpParameterPo> ErpParameterPos { get; set; }
        public virtual ICollection<ErpParameterPosDevice> ErpParameterPosDevices { get; set; }
        public virtual ICollection<ErpParameterPosExp> ErpParameterPosExps { get; set; }
        public virtual ICollection<ErpParameterPosPrinter> ErpParameterPosPrinters { get; set; }
        public virtual ICollection<ErpParameter> ErpParameters { get; set; }
        public virtual ICollection<ErpPaymentCard> ErpPaymentCards { get; set; }
        public virtual ICollection<ErpPaymentPlan> ErpPaymentPlans { get; set; }
        public virtual ICollection<ErpPoll> ErpPolls { get; set; }
        public virtual ICollection<ErpPo> ErpPos { get; set; }
        public virtual ICollection<ErpPosEndOfDateRaport> ErpPosEndOfDateRaports { get; set; }
        public virtual ICollection<ErpProcess> ErpProcesses { get; set; }
        public virtual ICollection<ErpProductConfigurator> ErpProductConfigurators { get; set; }
        public virtual ICollection<ErpProject> ErpProjects { get; set; }
        public virtual ICollection<ErpPublishDocument> ErpPublishDocuments { get; set; }
        public virtual ICollection<ErpPurchaseContract> ErpPurchaseContracts { get; set; }
        public virtual ICollection<ErpQualityControlReceipt> ErpQualityControlReceipts { get; set; }
        public virtual ICollection<ErpQualityControlTestCard> ErpQualityControlTestCards { get; set; }
        public virtual ICollection<ErpQualityControl> ErpQualityControls { get; set; }
        public virtual ICollection<ErpQualityType> ErpQualityTypes { get; set; }
        public virtual ICollection<ErpQuotationReceipt> ErpQuotationReceipts { get; set; }
        public virtual ICollection<ErpRecipeProgramType> ErpRecipeProgramTypes { get; set; }
        public virtual ICollection<ErpRecipeProgram> ErpRecipePrograms { get; set; }
        public virtual ICollection<ErpRecipe> ErpRecipes { get; set; }
        public virtual ICollection<ErpRefundCheque> ErpRefundCheques { get; set; }
        public virtual ICollection<ErpResourceAttributeSet> ErpResourceAttributeSets { get; set; }
        public virtual ICollection<ErpResourceOutOfUseReason> ErpResourceOutOfUseReasons { get; set; }
        public virtual ICollection<ErpResource> ErpResources { get; set; }
        public virtual ICollection<ErpReturnType> ErpReturnTypes { get; set; }
        public virtual ICollection<ErpRoute> ErpRoutes { get; set; }
        public virtual ICollection<ErpSalesContract> ErpSalesContracts { get; set; }
        public virtual ICollection<ErpSeason> ErpSeasons { get; set; }
        public virtual ICollection<ErpServiceGroup> ErpServiceGroups { get; set; }
        public virtual ICollection<ErpService> ErpServices { get; set; }
        public virtual ICollection<ErpSizeSetParameter> ErpSizeSetParameters { get; set; }
        public virtual ICollection<ErpSizeSet> ErpSizeSets { get; set; }
        public virtual ICollection<ErpSubscription> ErpSubscriptions { get; set; }
        public virtual ICollection<ErpTask> ErpTasks { get; set; }
        public virtual ICollection<ErpTax> ErpTaxes { get; set; }
        public virtual ICollection<ErpTest> ErpTests { get; set; }
        public virtual ICollection<ErpTradingGroup> ErpTradingGroups { get; set; }
        public virtual ICollection<ErpTransporter> ErpTransporters { get; set; }
        public virtual ICollection<ErpVariantType> ErpVariantTypes { get; set; }
        public virtual ICollection<ErpVehicle> ErpVehicles { get; set; }
        public virtual ICollection<ErpWorkFlowCard> ErpWorkFlowCards { get; set; }
        public virtual ICollection<ErpWorkFlowMsgAddress> ErpWorkFlowMsgAddresses { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
        public virtual ICollection<HrmAddPaymentDeduction> HrmAddPaymentDeductions { get; set; }
        public virtual ICollection<HrmAdvertisement> HrmAdvertisements { get; set; }
        public virtual ICollection<HrmApplication> HrmApplications { get; set; }
        public virtual ICollection<HrmCv> HrmCvs { get; set; }
        public virtual ICollection<HrmEmployeeAccrual> HrmEmployeeAccruals { get; set; }
        public virtual ICollection<HrmEmployeeDemand> HrmEmployeeDemands { get; set; }
        public virtual ICollection<HrmEmployeeLeave> HrmEmployeeLeaves { get; set; }
        public virtual ICollection<HrmLeaveEntitlement> HrmLeaveEntitlements { get; set; }
        public virtual ICollection<HrmLeaveGroup> HrmLeaveGroups { get; set; }
        public virtual ICollection<HrmLeaveType> HrmLeaveTypes { get; set; }
        public virtual ICollection<HrmPlacement> HrmPlacements { get; set; }
        public virtual ICollection<HrmPosition> HrmPositions { get; set; }
        public virtual ICollection<HrmTestEmployee> HrmTestEmployees { get; set; }
        public virtual ICollection<HrmTest> HrmTests { get; set; }
        public virtual ICollection<HrmTime> HrmTimes { get; set; }
        public virtual ICollection<MetaDataConstraint> MetaDataConstraints { get; set; }
        public virtual ICollection<MetaMessageProvider> MetaMessageProviders { get; set; }
        public virtual ICollection<MetaMessageTemplate> MetaMessageTemplates { get; set; }
        public virtual ICollection<MetaPo> MetaPos { get; set; }
        public virtual ICollection<MetaPreset> MetaPresets { get; set; }
        public virtual ICollection<MetaPrinter> MetaPrinters { get; set; }
        public virtual ICollection<MetaReport> MetaReports { get; set; }
        public virtual ICollection<MetaResource> MetaResources { get; set; }
        public virtual ICollection<MetaUserCompany> MetaUserCompanies { get; set; }
        public virtual ICollection<MetaUserRight> MetaUserRights { get; set; }
        public virtual ICollection<MetaUserRole> MetaUserRoles { get; set; }
        public virtual ICollection<PosMenu> PosMenus { get; set; }
        public virtual ICollection<PosShift> PosShifts { get; set; }
        public virtual ICollection<RplTaskTarget> RplTaskTargets { get; set; }
        public virtual ICollection<RplTask> RplTasks { get; set; }
        public virtual ICollection<RplXref> RplXrefFromCompanies { get; set; }
        public virtual ICollection<RplXref> RplXrefToCompanies { get; set; }
    }
}
