using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HealthProfile
{
    public partial class Form2 : Form
    {
        
        /// <summary>
        /// Constructor.
        /// </summary>
        public Form2()
        {
            InitializeComponent();
            this.clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This function is used to clear all of the labels containing the person's information.
        /// It is called whenever the Form is opened, exited and opened again, or opened again while
        /// it was already opened. 
        /// </summary>
        public void clear()
        {
            fullName.Text = "";
            ageLabel.Text = "";
            genderLabel.Text = "";
            maxHeartRateLabel.Text = "";
            targetHeartRateLabel.Text = "";
            weightLabel.Text = "";
            heightLabel.Text = "";
            bmiLabel.Text = "";
            this.CenterToScreen();
            this.Focus();
 
        }

        /// <summary>
        ///I found how to do this on https://social.msdn.microsoft.com/Forums/windows/en-US/81b1c479-0884-42c7-9eaf-a8ec6b1c7f78/easiest-way-to-detect-an-open-form-in-c?forum=winforms.
        ///This is the approach of user "John Willemse".
        ///I use this overrided method because I want only one instance of the form that appears when the "Calculate BMI button" is clicked.
        ///In order to only have 1 instance of this form, I need to declare this form outside of the "Calculate BMI" event handler.
        ///However, when I close the form2 and click "Calculate BMI" again, errors occur because the form has already been disposed of.
        ///So, when we exit the Form2 window and then click "CALCULATE BMI" again, this method basically says the close event was cancelled
        /// and then I'm just hiding the form from view. That way I only get 1 instance of this form and it is not disposed of until the HealtHProfile application
        ///is closed.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
          
            e.Cancel = true;
            this.Hide();
        }

        
        //setters
        public void setName(string name)
        {
            //Called twice, once for first name and once for last name.
            fullName.Text  = fullName.Text + name + " ";
           
        }

        public void setAge(int age)
        {
            
            //Age should not be less than 9.
            if(age >= 9)
            {
               

                ageLabel.Text = "" + age + " years old";  
            }
        }

        public void setGender(string gender)
        {
            genderLabel.Text = gender;
        }

        public void setMaxHeartRate(int maxHeartRate)
        {
            maxHeartRateLabel.Text = "" + maxHeartRate + " bpm (beats per minute)";
        }

        public void setTargetHeartRate(string targetHeartRate)
        {
            targetHeartRateLabel.Text = targetHeartRate;
        }

        public void setWeight(string weight)
        {
            weightLabel.Text = weight + " pounds";
        }

        public void setHeight(string height)
        {
            heightLabel.Text = height + " inches";
        }

       public void setBMI(double BMI)
        {
            //BMI is in kilograms/(meters^2). I just want to be sure users know this.
            bmiLabel.Text = "" + BMI + "     kg/m^2";
        }

       
    }
}
