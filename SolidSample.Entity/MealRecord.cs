using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.Entity
{
    public class MealRecord : EntityBase
    {
        [Required]
        public DateTime ConsumedOn { get; set; }

        [Required]
        public long PersonId { get; set; }
        [ForeignKey(nameof(PersonId))]
        public virtual Person Person { get; set; } = default!;

        [Required]
        public long MealId { get; set; }
        [ForeignKey(nameof(MealId))]
        public virtual Meal Meal { get; set; } = default!;
    }
}
