﻿using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmCvcomputerExperience
    {
        public long RecId { get; set; }
        public long? CvId { get; set; }
        public string? ExperienceExplanation { get; set; }
        public byte? ExperienceLevel { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual HrmCv? Cv { get; set; }
    }
}
