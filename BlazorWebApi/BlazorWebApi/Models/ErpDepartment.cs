using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpDepartment
    {
        public ErpDepartment()
        {
            CrmTransactionFlows = new HashSet<CrmTransactionFlow>();
            CrmTransactionTypes = new HashSet<CrmTransactionType>();
            ErpCallerIdLogs = new HashSet<ErpCallerIdLog>();
            ErpCurrentAccountReceiptItems = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpCurrentAccountTransactions = new HashSet<ErpCurrentAccountTransaction>();
            ErpCustomerTransactions = new HashSet<ErpCustomerTransaction>();
            ErpDepartmentCapacities = new HashSet<ErpDepartmentCapacity>();
            ErpDepartmentCashes = new HashSet<ErpDepartmentCash>();
            ErpDepartmentDeliveries = new HashSet<ErpDepartmentDelivery>();
            ErpDepartmentServices = new HashSet<ErpDepartmentService>();
            ErpDepartmentWarehouses = new HashSet<ErpDepartmentWarehouse>();
            ErpDocuments = new HashSet<ErpDocument>();
            ErpEmployeeDepartments = new HashSet<ErpEmployee>();
            ErpEmployeeHistories = new HashSet<ErpEmployeeHistory>();
            ErpEmployeeWorkStations = new HashSet<ErpEmployee>();
            ErpGiftVoucherDepts = new HashSet<ErpGiftVoucherDept>();
            ErpGiftVoucherTypeDepts = new HashSet<ErpGiftVoucherTypeDept>();
            ErpInventoryCampaignDepartments = new HashSet<ErpInventoryCampaignDepartment>();
            ErpInventoryPriceLists = new HashSet<ErpInventoryPriceList>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpLoyalityCardDepts = new HashSet<ErpLoyalityCardDept>();
            ErpLoyalityCardTypeDepts = new HashSet<ErpLoyalityCardTypeDept>();
            ErpNotificationItems = new HashSet<ErpNotificationItem>();
            ErpParameterPos = new HashSet<ErpParameterPo>();
            ErpParameterPosDevices = new HashSet<ErpParameterPosDevice>();
            ErpParameterPosPrinters = new HashSet<ErpParameterPosPrinter>();
            ErpPaymentCardDepts = new HashSet<ErpPaymentCardDept>();
            ErpPlannings = new HashSet<ErpPlanning>();
            ErpPos = new HashSet<ErpPo>();
            ErpPosEndOfDateRaports = new HashSet<ErpPosEndOfDateRaport>();
            ErpQualityControlProcessDetails = new HashSet<ErpQualityControlProcessDetail>();
            ErpRecipeItemWastageWarehouses = new HashSet<ErpRecipeItemWastageWarehouse>();
            ErpResources = new HashSet<ErpResource>();
            ErpServicePriceLists = new HashSet<ErpServicePriceList>();
            ErpWarehouseLocationDepartmentId2Navigations = new HashSet<ErpWarehouseLocation>();
            ErpWarehouseLocationDepartments = new HashSet<ErpWarehouseLocation>();
            HrmAdvertisements = new HashSet<HrmAdvertisement>();
            HrmCvs = new HashSet<HrmCv>();
            HrmEmployeeAccruals = new HashSet<HrmEmployeeAccrual>();
            HrmEmployeeDemands = new HashSet<HrmEmployeeDemand>();
            HrmPlacementItems = new HashSet<HrmPlacementItem>();
            HrmTestEmployees = new HashSet<HrmTestEmployee>();
            InverseParent = new HashSet<ErpDepartment>();
            MetaPos = new HashSet<MetaPo>();
            MetaReports = new HashSet<MetaReport>();
            MetaUsers = new HashSet<MetaUser>();
            PosMenuItems = new HashSet<PosMenuItem>();
            PosMenus = new HashSet<PosMenu>();
            PosShifts = new HashSet<PosShift>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public string? DepartmentCode { get; set; }
        public string? DepartmentName { get; set; }
        public int? ParentId { get; set; }
        public int? DepartmentGroupId { get; set; }
        public int? CostCenterId { get; set; }
        public long? ServiceId { get; set; }
        public string? Explanation { get; set; }
        public string? PhoneNumbers { get; set; }
        public string? PriceGroupCode { get; set; }
        public short? Area { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public int? DistrictId { get; set; }
        public int? CityId { get; set; }
        public string? PostalCode { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public int? TownId { get; set; }
        public int? StreetId { get; set; }
        public decimal? GpsXcoordinate { get; set; }
        public decimal? GpsYcoordinate { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? DepartmentType { get; set; }
        public byte? IsVirtual { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaCity? City { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCostCenter? CostCenter { get; set; }
        public virtual MetaCountry? Country { get; set; }
        public virtual ErpDepartmentGroup? DepartmentGroup { get; set; }
        public virtual MetaDistrict? District { get; set; }
        public virtual ErpDepartment? Parent { get; set; }
        public virtual ErpService? Service { get; set; }
        public virtual MetaState? State { get; set; }
        public virtual MetaStreet? Street { get; set; }
        public virtual MetaTown? Town { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<CrmTransactionFlow> CrmTransactionFlows { get; set; }
        public virtual ICollection<CrmTransactionType> CrmTransactionTypes { get; set; }
        public virtual ICollection<ErpCallerIdLog> ErpCallerIdLogs { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItems { get; set; }
        public virtual ICollection<ErpCurrentAccountTransaction> ErpCurrentAccountTransactions { get; set; }
        public virtual ICollection<ErpCustomerTransaction> ErpCustomerTransactions { get; set; }
        public virtual ICollection<ErpDepartmentCapacity> ErpDepartmentCapacities { get; set; }
        public virtual ICollection<ErpDepartmentCash> ErpDepartmentCashes { get; set; }
        public virtual ICollection<ErpDepartmentDelivery> ErpDepartmentDeliveries { get; set; }
        public virtual ICollection<ErpDepartmentService> ErpDepartmentServices { get; set; }
        public virtual ICollection<ErpDepartmentWarehouse> ErpDepartmentWarehouses { get; set; }
        public virtual ICollection<ErpDocument> ErpDocuments { get; set; }
        public virtual ICollection<ErpEmployee> ErpEmployeeDepartments { get; set; }
        public virtual ICollection<ErpEmployeeHistory> ErpEmployeeHistories { get; set; }
        public virtual ICollection<ErpEmployee> ErpEmployeeWorkStations { get; set; }
        public virtual ICollection<ErpGiftVoucherDept> ErpGiftVoucherDepts { get; set; }
        public virtual ICollection<ErpGiftVoucherTypeDept> ErpGiftVoucherTypeDepts { get; set; }
        public virtual ICollection<ErpInventoryCampaignDepartment> ErpInventoryCampaignDepartments { get; set; }
        public virtual ICollection<ErpInventoryPriceList> ErpInventoryPriceLists { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpLoyalityCardDept> ErpLoyalityCardDepts { get; set; }
        public virtual ICollection<ErpLoyalityCardTypeDept> ErpLoyalityCardTypeDepts { get; set; }
        public virtual ICollection<ErpNotificationItem> ErpNotificationItems { get; set; }
        public virtual ICollection<ErpParameterPo> ErpParameterPos { get; set; }
        public virtual ICollection<ErpParameterPosDevice> ErpParameterPosDevices { get; set; }
        public virtual ICollection<ErpParameterPosPrinter> ErpParameterPosPrinters { get; set; }
        public virtual ICollection<ErpPaymentCardDept> ErpPaymentCardDepts { get; set; }
        public virtual ICollection<ErpPlanning> ErpPlannings { get; set; }
        public virtual ICollection<ErpPo> ErpPos { get; set; }
        public virtual ICollection<ErpPosEndOfDateRaport> ErpPosEndOfDateRaports { get; set; }
        public virtual ICollection<ErpQualityControlProcessDetail> ErpQualityControlProcessDetails { get; set; }
        public virtual ICollection<ErpRecipeItemWastageWarehouse> ErpRecipeItemWastageWarehouses { get; set; }
        public virtual ICollection<ErpResource> ErpResources { get; set; }
        public virtual ICollection<ErpServicePriceList> ErpServicePriceLists { get; set; }
        public virtual ICollection<ErpWarehouseLocation> ErpWarehouseLocationDepartmentId2Navigations { get; set; }
        public virtual ICollection<ErpWarehouseLocation> ErpWarehouseLocationDepartments { get; set; }
        public virtual ICollection<HrmAdvertisement> HrmAdvertisements { get; set; }
        public virtual ICollection<HrmCv> HrmCvs { get; set; }
        public virtual ICollection<HrmEmployeeAccrual> HrmEmployeeAccruals { get; set; }
        public virtual ICollection<HrmEmployeeDemand> HrmEmployeeDemands { get; set; }
        public virtual ICollection<HrmPlacementItem> HrmPlacementItems { get; set; }
        public virtual ICollection<HrmTestEmployee> HrmTestEmployees { get; set; }
        public virtual ICollection<ErpDepartment> InverseParent { get; set; }
        public virtual ICollection<MetaPo> MetaPos { get; set; }
        public virtual ICollection<MetaReport> MetaReports { get; set; }
        public virtual ICollection<MetaUser> MetaUsers { get; set; }
        public virtual ICollection<PosMenuItem> PosMenuItems { get; set; }
        public virtual ICollection<PosMenu> PosMenus { get; set; }
        public virtual ICollection<PosShift> PosShifts { get; set; }
    }
}
