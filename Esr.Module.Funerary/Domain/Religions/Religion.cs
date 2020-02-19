﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using System.Collections.Generic;
using Esr.Module.Funerary.Domain.DataDeceaseds;

namespace Esr.Module.Funerary.Domain.Religions
{
    [DisplayName(@"Religião")]
    public class Religion : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName(@"Código"), Required, Unique]
        public string Code { get; set; }

        [DisplayName(@"Descrição"), Required]
        public string Description { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }

        public virtual ICollection<DataDeceased> DataDeceaseds { get; set; }
    }
}
