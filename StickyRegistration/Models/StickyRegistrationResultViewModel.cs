using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StickyRegistration.Models
{
    public class StickyRegistrationResultViewModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public CategoryList Category { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Result { get; set; }
    }
}


