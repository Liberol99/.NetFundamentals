using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmCv
    {
        public HrmCv()
        {
            ErpEmployeeRelations = new HashSet<ErpEmployeeRelation>();
            HrmApplications = new HashSet<HrmApplication>();
            HrmCvabilities = new HashSet<HrmCvability>();
            HrmCvattachments = new HashSet<HrmCvattachment>();
            HrmCvcomputerExperiences = new HashSet<HrmCvcomputerExperience>();
            HrmCvcourses = new HashSet<HrmCvcourse>();
            HrmCveducations = new HashSet<HrmCveducation>();
            HrmCvexperiences = new HashSet<HrmCvexperience>();
            HrmCvforeignLanguages = new HashSet<HrmCvforeignLanguage>();
            HrmCvinterviews = new HashSet<HrmCvinterview>();
            HrmCvreferences = new HashSet<HrmCvreference>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public long? EmployeeId { get; set; }
        public long? ReferenceEmployeeId { get; set; }
        public int? PositionId { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Cvtitle { get; set; }
        public byte[]? CandidatePicture { get; set; }
        public byte? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? BirthPlace { get; set; }
        public byte? MaritalStatus { get; set; }
        public string? IdCardNo { get; set; }
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
        public DateTime? IdIssuedDate { get; set; }
        public string? Nationality { get; set; }
        public byte? BloodGroup { get; set; }
        public byte? IsTerrorStricken { get; set; }
        public byte? IsSentenced { get; set; }
        public byte? IsImmigrant { get; set; }
        public byte? IsSmoke { get; set; }
        public byte? MilitaryStatus { get; set; }
        public string? ExemptExplanation { get; set; }
        public DateTime? DeferralDate { get; set; }
        public byte? DisabilityStatus { get; set; }
        public string? DisabilityExplanation { get; set; }
        public byte? DriverLicence { get; set; }
        public DateTime? DriverLicenceDate { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public int? DistrictId { get; set; }
        public int? TownId { get; set; }
        public int? StreetId { get; set; }
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public string? PostalCode { get; set; }
        public string? Phone { get; set; }
        public string? MobilePhone { get; set; }
        public string? MobilePhone2 { get; set; }
        public string? Email { get; set; }
        public DateTime? PossibleStartDate { get; set; }
        public decimal? DemandSalary { get; set; }
        public byte? DemandAccountType { get; set; }
        public byte? DemandSalaryType { get; set; }
        public decimal? ProposedSalary { get; set; }
        public byte? ProposedAccountType { get; set; }
        public byte? ProposedSalaryType { get; set; }
        public string? AssessmentExplanation { get; set; }
        public byte? WorkType { get; set; }
        public long? PlacementId { get; set; }
        public int? DepartmentId { get; set; }
        public decimal? StartSalary { get; set; }
        public byte? StartAccountType { get; set; }
        public byte? StartSalaryType { get; set; }
        public DateTime? StartDate { get; set; }
        public short? TrialPeriod { get; set; }
        public string? DecisionExplanation { get; set; }
        public byte? IsHouseRented { get; set; }
        public byte? IsVehicleServiceAvailability { get; set; }
        public byte? WorkerType { get; set; }
        public byte? IsFormerEmployee { get; set; }
        public byte? ApplicationSource { get; set; }
        public DateTime? JobApplicationDate { get; set; }
        public DateTime? StartApprovedDate { get; set; }
        public byte? CanWorkOvertime { get; set; }
        public byte? CanWorkShift { get; set; }
        public decimal? PreviousSalary { get; set; }
        public byte? PreviousSalaryType { get; set; }
        public byte? IsUnemploymentSalary { get; set; }
        public byte? HasCriminalRecord { get; set; }
        public string? CriminalRecordExplanation { get; set; }
        public byte? HasHealthProblem { get; set; }
        public string? HealthProblemExplanation { get; set; }
        public byte? IsPensioner { get; set; }
        public byte? IsStartJobTraining { get; set; }
        public string? AccessCode { get; set; }
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
        public virtual MetaCountry? Country { get; set; }
        public virtual ErpDepartment? Department { get; set; }
        public virtual MetaDistrict? District { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual HrmPlacement? Placement { get; set; }
        public virtual HrmPosition? Position { get; set; }
        public virtual ErpEmployee? ReferenceEmployee { get; set; }
        public virtual MetaStreet? Street { get; set; }
        public virtual MetaTown? Town { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpEmployeeRelation> ErpEmployeeRelations { get; set; }
        public virtual ICollection<HrmApplication> HrmApplications { get; set; }
        public virtual ICollection<HrmCvability> HrmCvabilities { get; set; }
        public virtual ICollection<HrmCvattachment> HrmCvattachments { get; set; }
        public virtual ICollection<HrmCvcomputerExperience> HrmCvcomputerExperiences { get; set; }
        public virtual ICollection<HrmCvcourse> HrmCvcourses { get; set; }
        public virtual ICollection<HrmCveducation> HrmCveducations { get; set; }
        public virtual ICollection<HrmCvexperience> HrmCvexperiences { get; set; }
        public virtual ICollection<HrmCvforeignLanguage> HrmCvforeignLanguages { get; set; }
        public virtual ICollection<HrmCvinterview> HrmCvinterviews { get; set; }
        public virtual ICollection<HrmCvreference> HrmCvreferences { get; set; }
    }
}
