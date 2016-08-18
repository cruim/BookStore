using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
   public class ShippingDetails
    {
        [Required(ErrorMessage = "Input Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Input Your Adress")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Input Your City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Input Your Country")]
        public string Country { get; set; }
    }
}
