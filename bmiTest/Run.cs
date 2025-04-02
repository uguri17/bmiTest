using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmiTest
{
    public partial class MainApp
	{
        private void btnCal_Click(object sender, EventArgs e)
        {
            // height
            double cm = double.Parse(textboxCM.Text);
            double height = cm / 100;

            // weight
            double weight = double.Parse(textboxKG.Text);

            // bmi = weight / (heigt)^2
            double bmi = weight / (Math.Pow(height, 2));

            // Result 3종
            textboxCMresult.Text = $"{cm}cm";
            textboxKGresult.Text = $"{weight}kg";
            textboxBMIresult.Text = $"{bmi:F3}";

            labelbmiResult.Text = $"BMI: [ {bmi} ]";

            // Track_bar
            int ibmi = (int)Math.Round(bmi);
            tbarBmi.Value = ibmi;

            // Grade 
            if (bmi <= 18.5)
            {
                labelgradeResult.Text = "Grade: [ Underweight ]";
            }
            else if (bmi <= 23)
            {
                labelgradeResult.Text = "Grade: [ Normal weight ]";
            }
            else if (bmi <= 25)
            {
                labelgradeResult.Text = "Grade: [ Over weight ]";
            }
            else
            {
                labelgradeResult.Text = "Grade: [ Obese ]";
            }

            
        }
    }
}