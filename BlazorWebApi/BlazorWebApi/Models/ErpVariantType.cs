using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpVariantType
    {
        public ErpVariantType()
        {
            ErpInventoryCampaignItems = new HashSet<ErpInventoryCampaignItem>();
            ErpInventoryVariant1Types = new HashSet<ErpInventory>();
            ErpInventoryVariant2Types = new HashSet<ErpInventory>();
            ErpInventoryVariant3Types = new HashSet<ErpInventory>();
            ErpInventoryVariant4Types = new HashSet<ErpInventory>();
            ErpInventoryVariant5Types = new HashSet<ErpInventory>();
            ErpInventoryVariantVariant1Types = new HashSet<ErpInventoryVariant>();
            ErpInventoryVariantVariant2Types = new HashSet<ErpInventoryVariant>();
            ErpInventoryVariantVariant3Types = new HashSet<ErpInventoryVariant>();
            ErpInventoryVariantVariant4Types = new HashSet<ErpInventoryVariant>();
            ErpInventoryVariantVariant5Types = new HashSet<ErpInventoryVariant>();
            ErpVariantCardRelatedTypes = new HashSet<ErpVariantCard>();
            ErpVariantCardTypes = new HashSet<ErpVariantCard>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? TypeName { get; set; }
        public byte? TypeUsage { get; set; }
        public short? DataType { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<ErpInventoryCampaignItem> ErpInventoryCampaignItems { get; set; }
        public virtual ICollection<ErpInventory> ErpInventoryVariant1Types { get; set; }
        public virtual ICollection<ErpInventory> ErpInventoryVariant2Types { get; set; }
        public virtual ICollection<ErpInventory> ErpInventoryVariant3Types { get; set; }
        public virtual ICollection<ErpInventory> ErpInventoryVariant4Types { get; set; }
        public virtual ICollection<ErpInventory> ErpInventoryVariant5Types { get; set; }
        public virtual ICollection<ErpInventoryVariant> ErpInventoryVariantVariant1Types { get; set; }
        public virtual ICollection<ErpInventoryVariant> ErpInventoryVariantVariant2Types { get; set; }
        public virtual ICollection<ErpInventoryVariant> ErpInventoryVariantVariant3Types { get; set; }
        public virtual ICollection<ErpInventoryVariant> ErpInventoryVariantVariant4Types { get; set; }
        public virtual ICollection<ErpInventoryVariant> ErpInventoryVariantVariant5Types { get; set; }
        public virtual ICollection<ErpVariantCard> ErpVariantCardRelatedTypes { get; set; }
        public virtual ICollection<ErpVariantCard> ErpVariantCardTypes { get; set; }
    }
}
