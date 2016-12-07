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
        [Required(ErrorMessage ="Name is required")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Product Code is required")]
        public string ProductCode { get; set; }
        [Required(ErrorMessage ="Product is required")]
        public string ProductName { get; set; }

        public int TechID { get; set; }
        [Required(ErrorMessage ="Technician is required")]
        public string TechName { get; set; }
        [Required(ErrorMessage ="Date is required")]

        public DateTime DateOpened { get; set; }

        public DateTime? DateClosed { get; set; }
        [Required(ErrorMessage ="Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Description is required")]
        public string Description { get; set; }

       
    }
}
