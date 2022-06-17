using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DropDown.Models
{
    [Table("StateMaster")]
    public partial class StateMaster
    {
        [Key]
        public int StateId { get; set; }
        public int CountryId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string StateName { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string ShortName { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty(nameof(CountryMaster.StateMasters))]
        public virtual CountryMaster Country { get; set; }
    }
}
