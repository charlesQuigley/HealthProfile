using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HealthProfile
{
    public partial class Form3 : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public Form3()
        {
            InitializeComponent();
        }

        /// <summary>
        ///I found how to do this on https://social.msdn.microsoft.com/Forums/windows/en-US/81b1c479-0884-42c7-9eaf-a8ec6b1c7f78/easiest-way-to-detect-an-open-form-in-c?forum=winforms.
        ///This is the approach of user "John Willemse".
        ///I use this overrided method because I want only one instance of the form that appears when the "Show me the BMI Chart" is clicked.
        ///In order to only have 1 instance of this form, I need to declare this form outside of the "bmiChartShow_Click" event handler.
        ///However, when I close the form3 and click "Show me the BMI Chart" again, errors occur because the form has already been disposed of.
        ///So, when we exit the Form3 window and then click "Show me the BMI Chart" again, this method basically says the close event was cancelled
        /// and then I'm just hiding the form from view. That way I only get 1 instance of this form and it is not disposed of until the HealtHProfile applciation
        ///is closed.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            
            e.Cancel = true;
            this.Hide();
        }


        /// <summary>
        /// There is a clickable link in this form. The link is for the Wikipedia article that I got the BMI chart
        /// picture from.
        /// If a user clicks on the link,  it should open up a web browser with the wikipedia article address.
        /// PARAMETERS: the object sending the event as well as the clickable link event itself.
        /// RETURN: none.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wikipediaSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.linklabel.linkclicked?view=netcore-3.1
            //^Helped me understand how to make links open up the actual website.
            //https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/start-internet-browser
            //^Said to wrap it in try-catch block
            //https://github.com/dotnet/runtime/issues/28005
            //^The method found in the above two links did not completely work. Error was thrown saying the file
            //could not be found. So, I used the method by user "dsplaisted".

            wikipediaSource.LinkVisited = true;

            System.Diagnostics.ProcessStartInfo wikipediaLink = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://en.wikipedia.org/wiki/Body_mass_index",
                UseShellExecute = true

            };

            try
            {
                Process.Start(wikipediaLink);
            }
            catch (System.Exception ex) //If the website could not be found/opened for some reason, the error message will help us figure out why.
            {
                MessageBox.Show(ex.Message);

            }

        }
    }

 
}
