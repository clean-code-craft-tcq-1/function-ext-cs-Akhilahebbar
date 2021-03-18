using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
  public   class Battery
    {
        public string Property { get; set; }
        public float temperature { get; set; }
        public float StateCharge { get; set; }
        public float ChargeRate { get; set; }
        public string Status { get; set; }
        public float TempMin { get; set; }
        public float TempMax { get; set; }
        public float SocMin { get; set; }
        public float SocMax { get; set; }
        public float ChargeRateMin { get; set; }
        public float ChargeRateMax { get; set; }
        public float threshold { get; set; }
        public float WarnMessage { get; set; }
    }
}
