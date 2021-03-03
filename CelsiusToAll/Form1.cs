using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelsiusToAll
{
    public partial class CelsiusToAll : Form
    {
        public CelsiusToAll()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double Celsius = Convert.ToDouble(tbCelsius.Text);
            
            if (Celsius >= -273.15)
            {
                double Fahrenheit = Convert.ToDouble((Celsius * 1.8) + 32);
                lbFahrenheit.Text = Convert.ToString(Fahrenheit);
                double Kelvin = Convert.ToDouble(Celsius + 273.15);
                lbKelvin.Text = Convert.ToString(Kelvin);
                double Reaumur = Convert.ToDouble(Celsius * 0.8);
                lbReaumur.Text = Convert.ToString(Reaumur);
            }
            else if (Celsius < -273.15)
            {
                MessageBox.Show("Temperature cannot be less than absolute zero!");
            }
        }
    }
}
