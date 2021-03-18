using System;

namespace BatteryManagement
{
    internal  class TestBatteryStatus
    {
      

        public  void CheckBatteryStatus(float temperature, float soc, float chargeRate)
        {
          CheckTemperature(temperature);
            CheckStateOfCharge(soc);
            CheckChargeRate(chargeRate);
        }
        public  void CheckTemperature(float temperature)
        {
            CheckBatteryLevel(temperature, Constants.minTemperature, Constants.maxTemperature);
            BatteryStates batteryTemperature = BatteryCondition.CheckBatteryCondition(temperature, Constants.minTemperature, Constants.maxTemperature);
            BatteryMessages.DisplayBatteryStatus("Temperature", batteryTemperature);
        }
        public  void CheckStateOfCharge(float soc)
        {
            CheckBatteryLevel(soc, Constants.minStateOfCharge, Constants.maxStateOfCharge);
            BatteryStates batteryChargeState = BatteryCondition.CheckBatteryCondition(soc, Constants.minStateOfCharge, Constants.maxStateOfCharge);
            BatteryMessages.DisplayBatteryStatus("State of charge", batteryChargeState);
        }

        public  void CheckChargeRate(float chargeRate)
        {
            CheckBatteryLevel(chargeRate, Constants.minChargeRate, Constants.maxChargeRate);
            BatteryStates batteryChargeRate = BatteryCondition.CheckBatteryCondition(chargeRate, Constants.minChargeRate, Constants.maxChargeRate);
            BatteryMessages.DisplayBatteryStatus("Charge Rate", batteryChargeRate);
        }

      

       
        public  void CheckBatteryLevel(float ActualValue, float minValue, float maxValue)
        {
            BatteryBreachLevel breachlevel = new BatteryBreachLevel();
            float Thresholdlimit = CalculateThreshold(ActualValue, Constants.thresholdPercent);
            breachlevel.CheckMinBreachLevel(Thresholdlimit, ActualValue, minValue);
            breachlevel.CheckMaxBreachLevel(Thresholdlimit, ActualValue, maxValue);
        }

        public  float CalculateThreshold(float actualValue, float thresholdPercent)
        {
            return thresholdPercent * actualValue / 100;
        }

    }
}
