using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace Tracker.Models
{
    public class Sim_Info
    {
        [Key]
        public int Sim_InfoId { get; set; }
        public string Sim_Ap { get; set; }
        public long Iccid_Sim_number { get; set; }
        public int Sim_Pin { get; set; }

    }
}
