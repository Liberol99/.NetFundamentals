using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpEmployee
    {
        public ErpEmployee()
        {
            ErpAddresses = new HashSet<ErpAddress>();
            ErpAsserviceCurrentAccountDetails = new HashSet<ErpAsserviceCurrentAccountDetail>();
            ErpBankReceiptItems = new HashSet<ErpBankReceiptItem>();
            ErpBoxes = new HashSet<ErpBox>();
            ErpBudgetItems = new HashSet<ErpBudgetItem>();
            ErpContractItemEmployees = new HashSet<ErpContractItem>();
            ErpContractItemUsedEmployees = new HashSet<ErpContractItem>();
            ErpContracts = new HashSet<ErpContract>();
            ErpCurrentAccountEmployees = new HashSet<ErpCurrentAccount>();
            ErpCurrentAccountReceiptItemCashiers = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpCurrentAccountReceiptItemCouriers = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpCurrentAccountReceiptItemEmployees = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpCurrentAccountSellers = new HashSet<ErpCurrentAccount>();
            ErpCurrentAccountTransactions = new HashSet<ErpCurrentAccountTransaction>();
            ErpCustomerTransactionActivities = new HashSet<ErpCustomerTransactionActivity>();
            ErpDemandReceiptItemEmployees = new HashSet<ErpDemandReceiptItem>();
            ErpDemandReceiptItemUsedEmployees = new HashSet<ErpDemandReceiptItem>();
            ErpDemandReceipts = new HashSet<ErpDemandReceipt>();
            ErpEmployeeAddPayments = new HashSet<ErpEmployeeAddPayment>();
            ErpEmployeeAttachments = new HashSet<ErpEmployeeAttachment>();
            ErpEmployeeCompetencies = new HashSet<ErpEmployeeCompetency>();
            ErpEmployeeHistories = new HashSet<ErpEmployeeHistory>();
            ErpEmployeeIas = new HashSet<ErpEmployeeIa>();
            ErpEmployeePremia = new HashSet<ErpEmployeePremium>();
            ErpEmployeeRelations = new HashSet<ErpEmployeeRelation>();
            ErpEmployeeTimeAttandances = new HashSet<ErpEmployeeTimeAttandance>();
            ErpExpoItems = new HashSet<ErpExpoItem>();
            ErpExpos = new HashSet<ErpExpo>();
            ErpFixedAssetDebitDebitEmployees = new HashSet<ErpFixedAssetDebit>();
            ErpFixedAssetDebitUsedEmployees = new HashSet<ErpFixedAssetDebit>();
            ErpInventoryReceiptItemEmployees = new HashSet<ErpInventoryReceiptItem>();
            ErpInventoryReceiptItemUsedEmployees = new HashSet<ErpInventoryReceiptItem>();
            ErpInventoryReceiptShipments = new HashSet<ErpInventoryReceiptShipment>();
            ErpInventoryReceipts = new HashSet<ErpInventoryReceipt>();
            ErpInventorySerialCardItems = new HashSet<ErpInventorySerialCardItem>();
            ErpInventorySerialCards = new HashSet<ErpInventorySerialCard>();
            ErpInvoices = new HashSet<ErpInvoice>();
            ErpLabRecipes = new HashSet<ErpLabRecipe>();
            ErpOrderReceiptItemEmployees = new HashSet<ErpOrderReceiptItem>();
            ErpOrderReceiptItemUsedEmployees = new HashSet<ErpOrderReceiptItem>();
            ErpOrderReceipts = new HashSet<ErpOrderReceipt>();
            ErpPlannings = new HashSet<ErpPlanning>();
            ErpPoCashiers = new HashSet<ErpPo>();
            ErpPoCouriers = new HashSet<ErpPo>();
            ErpPoEmployees = new HashSet<ErpPo>();
            ErpProjects = new HashSet<ErpProject>();
            ErpQualityControlProcessDetails = new HashSet<ErpQualityControlProcessDetail>();
            ErpQualityControlQualityControllers = new HashSet<ErpQualityControl>();
            ErpQualityControlRamQualityControllers = new HashSet<ErpQualityControl>();
            ErpQualityControlReceiptItems = new HashSet<ErpQualityControlReceiptItem>();
            ErpQualityControlReceipts = new HashSet<ErpQualityControlReceipt>();
            ErpQualityControlSanforizeQualityControllers = new HashSet<ErpQualityControl>();
            ErpQualityControlTestDetails = new HashSet<ErpQualityControlTestDetail>();
            ErpQuotationReceiptItemEmployees = new HashSet<ErpQuotationReceiptItem>();
            ErpQuotationReceiptItemUsedEmployees = new HashSet<ErpQuotationReceiptItem>();
            ErpQuotationReceipts = new HashSet<ErpQuotationReceipt>();
            ErpResources = new HashSet<ErpResource>();
            ErpWorkOrderProductionEmployees = new HashSet<ErpWorkOrderProduction>();
            ErpWorkOrderProductionEmployeesNavigation = new HashSet<ErpWorkOrderProductionEmployee>();
            ErpWorkOrderProductionOtherEmployees = new HashSet<ErpWorkOrderProduction>();
            ErpWorkOrderProductionStartEmployees = new HashSet<ErpWorkOrderProduction>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
            HrmCheckings = new HashSet<HrmChecking>();
            HrmCvEmployees = new HashSet<HrmCv>();
            HrmCvReferenceEmployees = new HashSet<HrmCv>();
            HrmCvinterviews = new HashSet<HrmCvinterview>();
            HrmEmployeeAccruals = new HashSet<HrmEmployeeAccrual>();
            HrmEmployeeDemandDemandeds = new HashSet<HrmEmployeeDemand>();
            HrmEmployeeDemandManagers = new HashSet<HrmEmployeeDemand>();
            HrmEmployeeLeaveApprovedByNavigations = new HashSet<HrmEmployeeLeave>();
            HrmEmployeeLeaveEmployees = new HashSet<HrmEmployeeLeave>();
            HrmExecutionProceedings = new HashSet<HrmExecutionProceeding>();
            HrmLeaveEntitlements = new HashSet<HrmLeaveEntitlement>();
            HrmPlacementItems = new HashSet<HrmPlacementItem>();
            HrmSeverancePays = new HashSet<HrmSeverancePay>();
            HrmTestEmployees = new HashSet<HrmTestEmployee>();
            InverseManager = new HashSet<ErpEmployee>();
            MetaUsers = new HashSet<MetaUser>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public int? CostCenterId { get; set; }
        public int? DepartmentId { get; set; }
        public long? ManagerId { get; set; }
        public string? EmployeeCode { get; set; }
        public string? EmployeeName { get; set; }
        public short? EmployeeType { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte[]? EmployeePicture { get; set; }
        public byte[]? EmployeeSigner { get; set; }
        public string? PortalPassword { get; set; }
        public string? Email { get; set; }
        public string? WebAddress { get; set; }
        public string? Blog { get; set; }
        public string? Facebook { get; set; }
        public string? Twitter { get; set; }
        public string? LinkedIn { get; set; }
        public byte? IsCourier { get; set; }
        public decimal? ToleranceLimit { get; set; }
        public string? EmployeeSurname { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? SsiQuitReasonId { get; set; }
        public string? QuitExplanation { get; set; }
        public int? MlssQuitReasonId { get; set; }
        public decimal? Salary { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexSalary { get; set; }
        public DateTime? PensionStartDate { get; set; }
        public DateTime? PensionEndDate { get; set; }
        public decimal? PensionDeductionRate { get; set; }
        public byte? FundType { get; set; }
        public byte? IdentityType { get; set; }
        public decimal? PrvInsuranceEmpPrm { get; set; }
        public decimal? PrvInsuranceComPrm { get; set; }
        public decimal? IndPensionEmpPrm { get; set; }
        public decimal? IndPensionComPrm { get; set; }
        public decimal? AttendanceFee { get; set; }
        public string? SsiNo { get; set; }
        public string? EttsCode { get; set; }
        public int? TaxOfficeId { get; set; }
        public string? TaxNo { get; set; }
        public byte? Status { get; set; }
        public byte? PaymentPeriod { get; set; }
        public byte? SalaryType { get; set; }
        public byte? SsiStatus { get; set; }
        public byte? DisabilityStatus { get; set; }
        public byte? IsImmigrant { get; set; }
        public byte? IsUnionMember { get; set; }
        public string? UnionMemberNo { get; set; }
        public byte? HasUnemploymentInsurance { get; set; }
        public byte? Gender { get; set; }
        public byte? MaritalStatus { get; set; }
        public byte? Education { get; set; }
        public string? Nationality { get; set; }
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
        public string? IdNo { get; set; }
        public string? IdCardNo { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? BirthPlace { get; set; }
        public DateTime? IdIssuedDate { get; set; }
        public string? BankAccountNo { get; set; }
        public string? Explanation { get; set; }
        public string? ProxyNo { get; set; }
        public decimal? LastYearCumTaxBase { get; set; }
        public decimal? LastYearCumTaxAmount { get; set; }
        public decimal? SpecialExpenditureBase { get; set; }
        public decimal? ThisYearCumTaxBase { get; set; }
        public decimal? ThisYearCumTaxAmount { get; set; }
        public byte? IsSecondCoveredJob { get; set; }
        public byte? DocumentType { get; set; }
        public byte? BloodGroup { get; set; }
        public byte? IsMinWaged { get; set; }
        public byte? WorkType { get; set; }
        public DateTime? ContractExpirationDate { get; set; }
        public decimal? WorkTime { get; set; }
        public byte? IsDisabled { get; set; }
        public byte? IsSentenced { get; set; }
        public byte? IsTerrorStricken { get; set; }
        public byte? IsUnderGroundWorker { get; set; }
        public string? PreviousSurname { get; set; }
        public int? GlaccountId { get; set; }
        public decimal? MedReportedDays { get; set; }
        public byte? IsMinWageBaseInsured { get; set; }
        public byte? IsTransfer { get; set; }
        public byte? ApplyMla { get; set; }
        public decimal? Last3Years { get; set; }
        public byte? GoverningLawArticle { get; set; }
        public byte? IsDisabilityExemption { get; set; }
        public string? PreviousEmployer { get; set; }
        public string? PreviousEmployerAddress { get; set; }
        public DateTime? PreviousStartDate { get; set; }
        public DateTime? PreviousQuitDate { get; set; }
        public string? BankBranchCode { get; set; }
        public string? BankAdditionalNo { get; set; }
        public string? IbanNo { get; set; }
        public byte? Article5510 { get; set; }
        public byte? MonCount6111 { get; set; }
        public int? SsiProfessionId { get; set; }
        public decimal? CumPrvInsurance { get; set; }
        public short? JobCode { get; set; }
        public int? WorkStationId { get; set; }
        public decimal? MaxDiscountRate { get; set; }
        public long? LeaveGroupId { get; set; }
        public int? BankId { get; set; }
        public byte? MonCount4447 { get; set; }
        public int? PositionId { get; set; }
        public long? CurrentAccountId { get; set; }
        public int? ProcessId { get; set; }
        public long? CalendarId { get; set; }
        public byte? InOutType { get; set; }
        public byte? Quality { get; set; }
        public string? GsmPhone { get; set; }
        public int? ProjectId { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public string? ApprovedExplanation { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public decimal? MinWageIncomeCumTaxBase { get; set; }
        public byte? MilitaryStatus { get; set; }
        public string? DischargeNo { get; set; }
        public DateTime? DischargeDate { get; set; }
        public byte? HasPreRightOfLeave { get; set; }
        public DateTime? SeverancePayDate { get; set; }
        public DateTime? ShortTimeWorkingStartDate { get; set; }
        public DateTime? ShortTimeWorkingEndDate { get; set; }
        public decimal? WorkWeek { get; set; }
        public decimal? NonWorkWeek { get; set; }
        public decimal? ShortTimePaidDay { get; set; }
        public byte? ShortTimePaidDayType { get; set; }
        public decimal? DisabilityRate { get; set; }
        public string? HesCode { get; set; }
        public short? PreRightSsiDay { get; set; }
        public DateTime? PrvInsuranceEmpPrmStartDate { get; set; }
        public DateTime? PrvInsuranceEmpPrmEndDate { get; set; }
        public decimal? LastYearMinWageIncomeTaxBase { get; set; }
        public decimal? MilitaryDebtAmount { get; set; }
        public decimal? BirthDebtAmount { get; set; }
        public decimal? MilitaryDebtUsedAmount { get; set; }
        public decimal? MilitaryDebtBalance { get; set; }
        public decimal? BirthDebtUsedAmount { get; set; }
        public decimal? BirthDebtBalance { get; set; }
        public decimal? UsedMinWageIncomeTax { get; set; }
        public decimal? UsedMinWageStampDue { get; set; }
        public byte? AsserviceEmployeeType { get; set; }

        public virtual MetaBank? Bank { get; set; }
        public virtual ErpCalendar? Calendar { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCostCenter? CostCenter { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpDepartment? Department { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpGlaccount? Glaccount { get; set; }
        public virtual HrmLeaveGroup? LeaveGroup { get; set; }
        public virtual ErpEmployee? Manager { get; set; }
        public virtual MetaHrmQuit? MlssQuitReason { get; set; }
        public virtual HrmPosition? Position { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpProject? Project { get; set; }
        public virtual MetaHrmProfession? SsiProfession { get; set; }
        public virtual MetaHrmQuit? SsiQuitReason { get; set; }
        public virtual MetaTaxOffice? TaxOffice { get; set; }
        public virtual ErpDepartment? WorkStation { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpAddress> ErpAddresses { get; set; }
        public virtual ICollection<ErpAsserviceCurrentAccountDetail> ErpAsserviceCurrentAccountDetails { get; set; }
        public virtual ICollection<ErpBankReceiptItem> ErpBankReceiptItems { get; set; }
        public virtual ICollection<ErpBox> ErpBoxes { get; set; }
        public virtual ICollection<ErpBudgetItem> ErpBudgetItems { get; set; }
        public virtual ICollection<ErpContractItem> ErpContractItemEmployees { get; set; }
        public virtual ICollection<ErpContractItem> ErpContractItemUsedEmployees { get; set; }
        public virtual ICollection<ErpContract> ErpContracts { get; set; }
        public virtual ICollection<ErpCurrentAccount> ErpCurrentAccountEmployees { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItemCashiers { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItemCouriers { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItemEmployees { get; set; }
        public virtual ICollection<ErpCurrentAccount> ErpCurrentAccountSellers { get; set; }
        public virtual ICollection<ErpCurrentAccountTransaction> ErpCurrentAccountTransactions { get; set; }
        public virtual ICollection<ErpCustomerTransactionActivity> ErpCustomerTransactionActivities { get; set; }
        public virtual ICollection<ErpDemandReceiptItem> ErpDemandReceiptItemEmployees { get; set; }
        public virtual ICollection<ErpDemandReceiptItem> ErpDemandReceiptItemUsedEmployees { get; set; }
        public virtual ICollection<ErpDemandReceipt> ErpDemandReceipts { get; set; }
        public virtual ICollection<ErpEmployeeAddPayment> ErpEmployeeAddPayments { get; set; }
        public virtual ICollection<ErpEmployeeAttachment> ErpEmployeeAttachments { get; set; }
        public virtual ICollection<ErpEmployeeCompetency> ErpEmployeeCompetencies { get; set; }
        public virtual ICollection<ErpEmployeeHistory> ErpEmployeeHistories { get; set; }
        public virtual ICollection<ErpEmployeeIa> ErpEmployeeIas { get; set; }
        public virtual ICollection<ErpEmployeePremium> ErpEmployeePremia { get; set; }
        public virtual ICollection<ErpEmployeeRelation> ErpEmployeeRelations { get; set; }
        public virtual ICollection<ErpEmployeeTimeAttandance> ErpEmployeeTimeAttandances { get; set; }
        public virtual ICollection<ErpExpoItem> ErpExpoItems { get; set; }
        public virtual ICollection<ErpExpo> ErpExpos { get; set; }
        public virtual ICollection<ErpFixedAssetDebit> ErpFixedAssetDebitDebitEmployees { get; set; }
        public virtual ICollection<ErpFixedAssetDebit> ErpFixedAssetDebitUsedEmployees { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItemEmployees { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItemUsedEmployees { get; set; }
        public virtual ICollection<ErpInventoryReceiptShipment> ErpInventoryReceiptShipments { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceipts { get; set; }
        public virtual ICollection<ErpInventorySerialCardItem> ErpInventorySerialCardItems { get; set; }
        public virtual ICollection<ErpInventorySerialCard> ErpInventorySerialCards { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoices { get; set; }
        public virtual ICollection<ErpLabRecipe> ErpLabRecipes { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItemEmployees { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItemUsedEmployees { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceipts { get; set; }
        public virtual ICollection<ErpPlanning> ErpPlannings { get; set; }
        public virtual ICollection<ErpPo> ErpPoCashiers { get; set; }
        public virtual ICollection<ErpPo> ErpPoCouriers { get; set; }
        public virtual ICollection<ErpPo> ErpPoEmployees { get; set; }
        public virtual ICollection<ErpProject> ErpProjects { get; set; }
        public virtual ICollection<ErpQualityControlProcessDetail> ErpQualityControlProcessDetails { get; set; }
        public virtual ICollection<ErpQualityControl> ErpQualityControlQualityControllers { get; set; }
        public virtual ICollection<ErpQualityControl> ErpQualityControlRamQualityControllers { get; set; }
        public virtual ICollection<ErpQualityControlReceiptItem> ErpQualityControlReceiptItems { get; set; }
        public virtual ICollection<ErpQualityControlReceipt> ErpQualityControlReceipts { get; set; }
        public virtual ICollection<ErpQualityControl> ErpQualityControlSanforizeQualityControllers { get; set; }
        public virtual ICollection<ErpQualityControlTestDetail> ErpQualityControlTestDetails { get; set; }
        public virtual ICollection<ErpQuotationReceiptItem> ErpQuotationReceiptItemEmployees { get; set; }
        public virtual ICollection<ErpQuotationReceiptItem> ErpQuotationReceiptItemUsedEmployees { get; set; }
        public virtual ICollection<ErpQuotationReceipt> ErpQuotationReceipts { get; set; }
        public virtual ICollection<ErpResource> ErpResources { get; set; }
        public virtual ICollection<ErpWorkOrderProduction> ErpWorkOrderProductionEmployees { get; set; }
        public virtual ICollection<ErpWorkOrderProductionEmployee> ErpWorkOrderProductionEmployeesNavigation { get; set; }
        public virtual ICollection<ErpWorkOrderProduction> ErpWorkOrderProductionOtherEmployees { get; set; }
        public virtual ICollection<ErpWorkOrderProduction> ErpWorkOrderProductionStartEmployees { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
        public virtual ICollection<HrmChecking> HrmCheckings { get; set; }
        public virtual ICollection<HrmCv> HrmCvEmployees { get; set; }
        public virtual ICollection<HrmCv> HrmCvReferenceEmployees { get; set; }
        public virtual ICollection<HrmCvinterview> HrmCvinterviews { get; set; }
        public virtual ICollection<HrmEmployeeAccrual> HrmEmployeeAccruals { get; set; }
        public virtual ICollection<HrmEmployeeDemand> HrmEmployeeDemandDemandeds { get; set; }
        public virtual ICollection<HrmEmployeeDemand> HrmEmployeeDemandManagers { get; set; }
        public virtual ICollection<HrmEmployeeLeave> HrmEmployeeLeaveApprovedByNavigations { get; set; }
        public virtual ICollection<HrmEmployeeLeave> HrmEmployeeLeaveEmployees { get; set; }
        public virtual ICollection<HrmExecutionProceeding> HrmExecutionProceedings { get; set; }
        public virtual ICollection<HrmLeaveEntitlement> HrmLeaveEntitlements { get; set; }
        public virtual ICollection<HrmPlacementItem> HrmPlacementItems { get; set; }
        public virtual ICollection<HrmSeverancePay> HrmSeverancePays { get; set; }
        public virtual ICollection<HrmTestEmployee> HrmTestEmployees { get; set; }
        public virtual ICollection<ErpEmployee> InverseManager { get; set; }
        public virtual ICollection<MetaUser> MetaUsers { get; set; }
    }
}
