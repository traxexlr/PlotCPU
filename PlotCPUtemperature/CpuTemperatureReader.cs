using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotCPUtemperature
{
    class CpuTemperatureReader: IDisposable
    {
        private readonly Computer _computer;
        public void Dispose()
        {
            try
            {
                _computer.Close();
            }
            catch (Exception)
            {
                //ignore closing errors
            }
        }
        public CpuTemperatureReader()
        {
            _computer = new Computer { CPUEnabled = true };
            _computer.Open();
        }

        public float GetTemperaturesInCelsius()
        {
            foreach (var hardware in _computer.Hardware)
            {
                hardware.Update(); //use hardware.Name to get CPU model
                foreach (var sensor in hardware.Sensors)
                {
                    if (sensor.SensorType == SensorType.Temperature && sensor.Name == "CPU Package" && sensor.Value.HasValue)
                    {
                        return sensor.Value.Value;
                    }
                }
            }
            return 0;
        }
    }
}
