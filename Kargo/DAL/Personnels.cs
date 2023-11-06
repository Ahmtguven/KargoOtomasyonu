using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Personnels
    {
        public int PersonnelNo { get; set; }
        public string NameSurname { get; set; }
        public string Task { get; set; }
        public string Caption { get; set; }
        public string Phone { get; set; }
        public decimal Salary { get; set; }
        public int CarNo { get; set; }

    }
}
