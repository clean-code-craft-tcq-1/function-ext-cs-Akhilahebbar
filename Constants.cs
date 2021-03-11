using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
    public  class Warnings
    {
      public static string Discharge { get;set; }
      public static string ChargePeak { get; set; }
       public Warnings(string discharge,string chargePeak)
        {
            Discharge = discharge;
            ChargePeak = chargePeak;
        }
    }
    public enum BatteryStates
    {
        Low,
        Normal,
        High
    }
    public static class Constants
    {
        public static float minChargeRate = 0.3f;
        public static float maxChargeRate = 0.8f;
        public static float minStateOfCharge = 20;
        public static float maxStateOfCharge = 80;
         public static float minTemperature = 0;
        public static float maxTemperature = 45;
        public static float thresholdPercent = 5;
        public static string LowDischarge = "Approaching Discharge";
        public static string PeakDischarge = "Approaching charge-peak";
       
    }
}
