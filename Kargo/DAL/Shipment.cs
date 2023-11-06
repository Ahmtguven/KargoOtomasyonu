using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Shipment
    {
        public int ShipmentNo { get; set; }
        public string ShipmentName { get; set; }
        public string ShipmentSP { get; set; }
        public string ShipmenFP { get; set; }
        public int Distance { get; set; }
        public decimal TotalPrice { get; set; }
        public int CarNo { get; set; }
        public int CustomerNo { get; set; }
        public int PersonelNo { get; set; }
    }
}
