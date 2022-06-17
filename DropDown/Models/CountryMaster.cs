using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DropDown.Models
{
    [Table("CountryMaster")]
    public partial class CountryMaster
    {
        public CountryMaster()
        {
            StateMasters = new HashSet<StateMaster>();
        }

        [Key]
        public int CountryId { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string CountryName { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string ShortName { get; set; }

        [InverseProperty(nameof(StateMaster.Country))]
        public virtual ICollection<StateMaster> StateMasters { get; set; }
    }
}
