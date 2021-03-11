using System;

namespace BatteryManagement
{
    internal class TestBatteryStatus
    {
       
        public static void CheckBatteryStatus(float temperature, float soc, float chargeRate)
        {
          CheckTemperature(temperature);
            CheckStateOfCharge(soc);
            CheckChargeRate(chargeRate);
        }
        public static void CheckTemperature(float temperature)
        {
            CheckBatteryLevel(temperature, Constants.minTemperature, Constants.maxTemperature);
            BatteryStates batteryTemperature = BatteryCondition.CheckBatteryCondition(temperature, Constants.minTemperature, Constants.maxTemperature);
            BatteryMessages.DisplayBatteryStatus("Temperature", batteryTemperature);
        }
        public static void CheckStateOfCharge(float soc)
        {
            CheckBatteryLevel(soc, Constants.minStateOfCharge, Constants.maxStateOfCharge);
            BatteryStates batteryChargeState = BatteryCondition.CheckBatteryCondition(soc, Constants.minStateOfCharge, Constants.maxStateOfCharge);
            BatteryMessages.DisplayBatteryStatus("State of charge", batteryChargeState);
        }

        public static void CheckChargeRate(float chargeRate)
        {
            CheckBatteryLevel(chargeRate, Constants.minChargeRate, Constants.maxChargeRate);
            BatteryStates batteryChargeRate = BatteryCondition.CheckBatteryCondition(chargeRate, Constants.minChargeRate, Constants.maxChargeRate);
            BatteryMessages.DisplayBatteryStatus("Charge Rate", batteryChargeRate);
        }

      

       
        public static void CheckBatteryLevel(float ActualValue, float minValue, float maxValue)
        {
            float Thresholdlimit = CalculateThreshold(ActualValue, Constants.thresholdPercent);
            BatteryBreachLevel.CheckMinBreachLevel(Thresholdlimit, ActualValue, minValue);
            BatteryBreachLevel.CheckMaxBreachLevel(Thresholdlimit, ActualValue, maxValue);
        }

        public static float CalculateThreshold(float actualValue, float thresholdPercent)
        {
            return thresholdPercent * actualValue / 100;
        }

    }
}
