using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.Entity
{
    public abstract class DescriptiveEntityBase : EntityBase
    {
        [Required]
        public string Name { get; set; } = default!;

        [Required]
        public string Description { get; set; } = default!;
    }
}
