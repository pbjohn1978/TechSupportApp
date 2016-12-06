using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TechSupportApp.Classes
{
    public class Incidents
    {
        public int IncidentID { get; set; }

        public int CustomerID { get; set; }
        [Required]
        public string CustomerName { get; set; }

        public string ProductCode { get; set; }
        [Required]
        public string ProductName { get; set; }

        public int TechID { get; set; }
        [Required]
        public string TechName { get; set; }
        [Required]
        public DateTime DateOpened { get; set; }

        public DateTime? DateClosed { get; set; }
        [Required]
        public String Title { get; set; }
        [Required]
        public String Description { get; set; }

       
    }
}
