using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.Entity
{
    public class Meal : DescriptiveEntityBase
    {
        public string PreparationInstructions { get; set; } = default!;
    }
}
