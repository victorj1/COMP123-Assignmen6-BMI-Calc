using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMP123_Assignmen6_BMI_Calc;

/** Name: Victor Jdanovitch
 * Student#: 300869472
 * Date: August 20th, 2016
 * Description: COMP123 Assignemnt 7 - Creating a BMI calculator form
 * Version: 0.2 - Added all required features + optional Reset button
*/

namespace COMP123_Assignmen6_BMI_Calc
{
   /**
   * <summary>
   * This is the "driver" class for the BMI program
   * </summary>
   * 
   * @class Program
   */
    public partial class BMICalculator : Form
    {
        // default Bmi Radio choice

        bool metricUnits;

        public BMICalculator()
        {
            InitializeComponent();
        }

        /**
        * <summary>
        * This Method check radio button 
        * </summary>
        * 
        * @static
        * @method BMICalculator
        * 
        * @returns {void}
        */

        private void BMICalculator_Load(object sender, EventArgs e)
        {
            metricRadioButton.Checked = true;
        }

        /**
        * <summary>
        * This method checks which radio button is selected
        * </summary>
        * 
        * @static
        * @method 
        * 
        * @returns {void}
        */
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton tempButton = (RadioButton)sender;
            if (tempButton == imperialRadioButton)
            {
                metricUnits = false;
            }
            else
            {
                metricUnits = true;
            }
        }

        /**
        * <summary>
        * This method displays the BMI value and scale category
        * </summary>
        * 
        * @static
        * @method 
        * 
        * @returns {void}
        * 
        */

        private void BMIButton_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(myWeightTextBox.Text);
            double height = Convert.ToDouble(myHeightTextBox.Text);
            double bmi = weight / (height * height);
            if (!metricUnits)
            {
                bmi *= 703;

            }
            if (bmi <= 18.5)
            {
                BMIScaleTextBox.Text = "Underweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                BMIScaleTextBox.Text = "Normal";
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                BMIScaleTextBox.Text = "Overweight";
            }
            else
            {
                BMIScaleTextBox.Text = "Obese";
            }
            BMIValueTextBox.Text = bmi.ToString();

        }
        /**
        * <summary>
        * This method displays the scale result
        * </summary>
        * 
        * @static
        * @method 
        * 
        * @returns {void}
        */
        private void BMIScaleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /**
        * <summary>
        * This method resets all the textboxes to nothing.
        * </summary>
        * 
        * @static
        * @method 
        * 
        * @returns {void}
        */

        private void resetButton_Click(object sender, EventArgs e)
        {
            myHeightTextBox.Text = "";
            myWeightTextBox.Text = "";
            BMIValueTextBox.Text = "";
            BMIScaleTextBox.Text = "";
        }


        private void myHeightTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bmiCalculatorLabel_Click(object sender, EventArgs e)
        {

        }


    }
}
