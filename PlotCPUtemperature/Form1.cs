using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenHardwareMonitor;

namespace PlotCPUtemperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private float[] GetRandomValueByCount(int count, float min, float max)
        {
            float[] data = new float[count];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = (float)random.NextDouble() * (max - min) + min;
            }
            return data;
        }

        Timer timer = new Timer();
        private void userButton2_Click(object sender, EventArgs e)
        {
            float min = float.MaxValue, max = float.MinValue;
            CpuTemperatureReader reader = new CpuTemperatureReader();
            userCurve1.SetLeftCurve("B", new float[] { }, Color.Tomato);
            timer.Interval = 500;
            timer.Tick += (sender1, e1) =>
            {               
                float a = reader.GetTemperaturesInCelsius();
                if(a<min)
                {
                    min = a;
                }
                if(a>max)
                {
                    max = a;
                }
                userCurve1.AddCurveData("B", a);
                userCurve1.StrechDataCountMax++; 
                userCurve1.Title = ("当前温度："+a.ToString()+"，最低："+min.ToString()+"，最高："+max.ToString());
            };
            timer.Start();
        }
        private void userButton3_Click(object sender, EventArgs e)
        {
            timer.Stop();
            userCurve1.RemoveAllCurve();
            userCurve1.StrechDataCountMax = 10;
        }
    }
}
