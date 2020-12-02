using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tracker.Models
{
    public class TrackerOrderHistory
    {
        [Key]
        public int TrackerOrderHistoryId { get; set; }
        public string Device_Name { get; set; }
        public int Device_Imei { get; set; }
        public string Device_QR { get; set; }
        public int Iccid_Sim_Number { get; set; }
    }

}
