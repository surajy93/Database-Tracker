using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tracker.Models
{
    public class TrackingDevice_Info
    {
        [Key]
        public int TrackingDevice_InfoId { get; set; }
        public string Device_Name { get; set; }
        public string Here_Sku { get; set; }
        public string Device_Model { get; set; }
        public int Device_Imei { get; set; }
        public string Device_Id { get; set; }
        public string Device_2nd { get; set; }
        public int Iccid_Sim_Number { get; set; }
    }
}
