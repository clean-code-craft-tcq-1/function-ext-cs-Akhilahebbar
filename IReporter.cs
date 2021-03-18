using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagement
{
  public  interface IReporter
    {
        public void ReportData(string message);
    }
}
