using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupportApp.Classes
{
    public class Incidents
    {
        public int IncidentID { get; set; }

        public int CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string ProductCode { get; set; }

        public string ProductName { get; set; }

        public int TechID { get; set; }

        public string TechName { get; set; }

        public DateTime DateOpened { get; set; }

        public DateTime? DateClosed { get; set; }

        public String Title { get; set; }

        public String Description { get; set; }
    }
}
