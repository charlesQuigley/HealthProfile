using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthProfile
{
    //This class is used to generate a healthProfile. It is the first window that pops up
    //when we open the application.
    public partial class healthProfile : Form
    {
       
        /// <summary>
        /// Constructor for the first form that opens as soon as the application starts.
        /// </summary>
        public healthProfile()
        {
            InitializeComponent();

            //This method allows for comboBoxes to show text as soon as the program runs.
            //This does not appear possible in the Windows Form Designer Generator.
            //So, I did it outside the generated region.
            AdditionalComponentBehavior();
           
        }


        /// <summary>
        /// This function takes the name of a month and converts it to a number.
        /// So, January = 1, February = 2, ... , December = 12.
        /// PARAMETERS: the name of a month.
        /// RETURN: integer value ranging from 1-12.
        /// </summary>
        /// <param name="month"></param>
        /// <returns></returns>
        private int convertMonthStringToInt(string month)
        {
            if(month == "January")
            {
                return 1;
            }
            else if(month == "February")
            {
                return 2;
            }
            else if(month == "March")
            {
                return 3;
            }
            else if(month == "April")
            {
                return 4;
            }
            else if(month == "May")
            {
                return 5;
            }
            else if(month == "June")
            {
                return 6;
            }
            else if(month == "July")
            {
                return 7;
            }
            else if(month == "August")
            {
                return 8;
            }
            else if(month == "September")
            {
                return 9;
            }
            else if(month == "October")
            {
                return 10;
            }
            else if(month == "November")
            {
                return 11;
            }
            else
            {
                return 12;
            }
        }

        /// <summary>
        /// This function takes the year as a string value as a parameter. It then 
        /// converts the string value into an integer. So for example,
        /// inputting "1992" as a paramter would return 1992. 
        /// PARAMETERS: The year as a string.
        /// RETURN: The year as an integer.
        /// </summary>
        /// <param name="yearString"></param>
        /// <returns></returns>
        private int convertYearStringToInt(string yearString)
        {
            int yearInt = 0; //accumulator
            int tensPlace = 3; //what exponent we raise 10 to.

            for (int i = 0; i < 4; i++)
            {
                //Example: yearInt = 0 + 1 * 10^3 = 1000.
                //next: yearInt = 1000 + 9 * 10^2 = 1000 + 900 = 1900
                //next: yearInt = 1000 + 9 * 10^1 = 1900 + 90 = 1990
                //finally: yearInt = 1990 + 2 * 10^0 = 1990 + 2 = 1992.
                //The minus 48 is used to convert the character into an integer.
                //For example, '9' in ASCII is 57. 57-48 is the ineteger 9.
                yearInt = yearInt + ((int)yearString[i] - 48) * (int)Math.Pow(10, tensPlace);

                tensPlace--;

            }

            return yearInt;

        }

        /// <summary>
        /// This function converts the day from a string to a number.
        /// For example, if it were 10/19/2020, then "19" would be the day.
        /// We would then convert "19" into 19 integer form.
        /// PARAMETERS: string representation of the day as a number.
        /// RETURN: integer value of the day as a number. 
        /// </summary>
        /// <param name="dayStr"></param>
        /// <returns></returns>
        private int convertDayStringToInt(string dayStr)
        {
            //Same setup as convertYearStringToInt().
            int tensPlace = dayStr.Length - 1; //Days will have at most 2 characters. Ex: "31".
            int dayInt = 0;

            for (int i = 0; i < dayStr.Length; i++)
            {
                dayInt = dayInt + ((int)dayStr[i] - 48) * (int)Math.Pow(10, tensPlace);
                tensPlace--;

            }


            return dayInt;

        }

        /// <summary>
        /// This function checks to see if the selected day is correct when compared
        /// to the selected month. For example, since January has 31 days in it, the user should be able
        /// to select 31 as the day. If, however, the user selects Feburary as the month, selecting the day to be 31
        /// is not acceptable because February only has 28 days during non-leap years and 29 days during leap years.
        /// This function takes the selected day, month, and year to determine if the day is correct for the month.
        /// This function can either return error codes ranging from -996 to -998, where each error code means something slightly different,
        /// or the function can return 1, which means there was no error detected.
        /// PARAMETERS: day, month, year as integers. (Example: day = 27, month = 2, year = 1996).
        /// RETURN: integer codes. (1 = no error detected. -996 = month is February and day is greater than 29. 
        /// -997 = month is February, day = 29, but a non-leap year was selected. -998 = A month that is not February was selected
        /// that does not have 31 days, but 31 was selected as the day).
        /// </summary>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        int correctDayForMonth(int day, int month, int year)
        {
            //If birth month is February
            if (month == 2)
            {
                //February cannot have more than  29 days even if it is leap year.
                if (day > 29)
                {
                    return -996; //return error code
                }
                else if (day == 29) //February has 29 days in leap year.
                {
                    //https://www.timeanddate.com/date/leapyear.html
                    //^explains how to determine leap years.
                    double yearDivisibleBy4 = year / 4.0;
                    double yearDivisibleBy100 = year / 100.0;
                    double yearDivisibleBy400 = year / 400.0;

                    //If the year = 1996, then 1996 / 4 = 499. Thus, the floor of 499 = 499.
                    //So, if the floor of the year / 4 is the same as year / 4, then the year is 
                    //evenly divisble by 4.
                    if (yearDivisibleBy4 == Math.Floor(yearDivisibleBy4))
                    {
                        //If the year is evenly divsible by 100, it is not a leap year unless it 
                        //is also evenly divisble by 400. 
                        if (yearDivisibleBy100 == Math.Floor(yearDivisibleBy100))
                        {
                            if (yearDivisibleBy400 == Math.Floor(yearDivisibleBy400))
                            {
                                return 1; //The month is february on a leap year, so the day can equal 29.
                                        //return 1 to show no error was detected.
                            }
                            return -997; //If the year was evenly divisble by 100 but not 400,
                                        //then Feburary is the month but the year is not a leap year.
                                        //So, the day cannot be 29. Return -997 to reflect this.
                        }

                        return 1; //If the year was evenly divisble by 4 but not evenly divisble by 100,
                                //then it is a leap year. So the day can be 29 for February.
                    }

                    return -997; //If the year was not evenly divisble by 4 and the month is February, the day
                                   //cannot be 29. So, return -997 to reflect this.

                }

                //If the month is February and the day is less than 29, it is valid.
                return 1;

            }
           else if(month == 4 || month == 6 || month == 9 || month == 11 )
            { 
                //Months with 30 days. 4 = April, 6 = June, 9 = September, 11 = November.
                if(day > 30)
                {
                    return -998; //Return -998, which means that a month that has at most 30 days was selected 
                                 //and 31 was selected as the day. 
                }

                
            }

            //Return 1 (which means valid) if a month with 31 days was selected. Since 31 is the highest the day 
            //combo box goes and 1 is the lowest, any day selecfed will be valid for these months.
            return 1;
            
            



        }

        /// <summary>
        /// This function determines how old the person is in years.
        /// This function also calls correctDayForMonth(), which determines if the selected day
        /// is valid for the selected month.
        /// RETURN: integer value (the age). Example: 24 could be a returned value. Error codes could also be returned
        /// via correctDayForMonth(). Check that function to understand the error codes.
        /// </summary>
        /// <returns></returns>
        private int calculateAge()
        {
           
            int currentMonthInt = 0;
            int monthOfBirth = 0;
            int currentDayInt = 0;
            int birthDayInt = 0;
            int currentYearInt = 0;
            int yearOfBirth = 0;
            int age = 0;

            //https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1
            //^DateTime format strings

            //Get the day, month, year from the computer's clock.
            DateTime time = DateTime.Now;

            //Convert the string version of the yesr into an integer version.
            currentYearInt = convertYearStringToInt(time.ToString("yyyy"));

            //Convert the person's year of birth from a string to an integer. Example: "1992" to 1992.
            yearOfBirth = convertYearStringToInt(yearComboBox.Text);


            
            age = currentYearInt - yearOfBirth;

            //If we are currently in the same month as the month the person was born.  We need to check
            //The days to see how old the person is. if a person was born on 12/12/1980 and it is currenlt 12/11/2020,
            //the person is 39, not 40. Same thing for months: If a person was born on 12/12/1980 and it is currengtly 11/12/1980,
            //that person is still 39. 

            //Get current month as an integer value. Example: October = 10
            currentMonthInt = convertMonthStringToInt(time.ToString("MMMM"));
            //Get the month of birth as an integer value.
            monthOfBirth = convertMonthStringToInt(monthComboBox.Text);


            //We have to check the days.
            string currentDayStr = "";

            currentDayStr = time.ToString("dd");

            currentDayInt = convertDayStringToInt(currentDayStr);

            birthDayInt = convertDayStringToInt(dayComboBox.Text);

            int checkDayMonth = correctDayForMonth(birthDayInt, monthOfBirth, yearOfBirth);

            if (checkDayMonth != 1)
            {
                return checkDayMonth;
            }

            

            //If the person has not yet had his/her birthday this year, age - 1.
            if (monthOfBirth > currentMonthInt)
            {
                age = age - 1;
            }
            else if (monthOfBirth == currentMonthInt) //If it is currently the person's birthday month.
            {

                //If the person's birthday has not yet occurred, age - 1.
                if (birthDayInt > currentDayInt)
                {
                    age = age - 1;
                }

            }

            return age;
        }

        /// <summary>
        /// This function takes a person's age and returns his/her maximum heart rate.
        /// https://www.heart.org/en/healthy-living/fitness/fitness-basics/target-heart-rates?uid=1801 .
        /// The website states that  max heart rate is roughly 220 - age.
        /// PARAMETERS: the person's age in years.
        /// RETURN: The max heart rate for that person.
        /// </summary>
        /// <param name="personAge"></param>
        /// <returns></returns>
        private int calculateMaxHeartRate(int personAge)
        {
            return 220 - personAge;
        }

        /// <summary>
        /// This function uses a person's age to determine his/her target heart rate, which is a range
        /// of heart rates to maximize the benefits of a workout. 
        /// PARAMETERS: age of the person in years.
        /// RETURN: a string stating the target heart rate range for that person.
        /// </summary>
        /// <param name="personAge"></param>
        /// <returns></returns>
        private string calculateTargetHeartRate(int personAge)
        {
            //https://www.heart.org/en/healthy-living/fitness/fitness-basics/target-heart-rates?uid=1801
            //^These target heart rates are found here.
            if (personAge >= 70)
            {
                return "75-128 bpm (beats per minute)";
            }
            else if (personAge >= 65)
            {
                return "78-132 bpm (beats per minute)";
            }
            else if (personAge >= 60)
            {
                return "80-136 bpm (beats per minute)";
            }
            else if (personAge >= 55)
            {
                return "83-140 bpm (beats per minute)";
            }
            else if (personAge >= 50)
            {
                return "85-145 bpm (beats per minute)";
            }
            else if (personAge >= 45)
            {
                return "88-149 bpm (beats per minute)";
            }
            else if (personAge >= 40)
            {
                return "90-153 bpm (beats per minute)";
            }
            else if (personAge >= 35)
            {
                return "93-157 bpm (beats per minute)";
            }
            else if (personAge >= 30)
            {
                return "95-162 bpm (beats per minute)";
            }
            else if (personAge >= 20)
            {
                return "100-170 bpm (beats per minute)";
            }
            else //Person age from 10-19.
            {
                //https://schoolwires.henry.k12.ga.us/cms/lib/GA01000549/Centricity/Domain/6592/Determining%20your%20Target%20Heart%20Rate%20Zone.pdf
                //^^This website shows how to calculate Target Heart Rate. I'm basing mine off someone who is 10 years old.
                return "105-179 bpm (beats per minute)";
            }
        }

        /// <summary>
        /// This function converts a person's weight from a string to an integer value.
        /// PARAMETERS: the weight of a person in pounds as a string. So, if a person is 120 lb, "120" is the input.
        /// RETURN: the weight as an integer.
        /// </summary>
        /// <param name="weightStr"></param>
        /// <returns></returns>
        int calculateWeight(string weightStr)
        {
            int weightInt = 0;
            int tensPlace = 0;

            //Make sure the tensPlace value only reflects the numbers for the weight.
            //If the user accidentally places space(s), ignore those spaces when calculating
            //what the tens place of the weight is. 
            //For example, " 192 " should be evaluated as "192", meaning that tensPlace = 3. 
            for(int i = 0; i < weightStr.Length; i++)
            {
                if(weightStr[i].Equals(' ') == false)
                {
                    tensPlace++;
                }
            }

            //If the weight is 192, the tensPlace should be 2 because 10^tensPlace = 10^2 = 100. 
            //So, based on this example, the for-loop above will have tensPlace = 3. So, we have to 
            //subtract 1. 
            tensPlace = tensPlace - 1;


            if(tensPlace > 2) //Cannot have weight in the thousands of pounds. Unrealistic.
            {
                return -999;
            }

            //convert weight from a string to an int.
            for(int i = 0; i < weightStr.Length; i++)
            {
                //Just in case the user accidentally inputs a space with a number.
                if (weightStr[i].Equals(' ') == false)
                {
                    weightInt = weightInt + ((int)(weightStr[i] - 48)) * (int)Math.Pow(10, tensPlace);
                    tensPlace--;
                }
            }
            
            if(weightInt > 800) //Heaviest man in the world weighed around 900 pounds, so 800 pounds is a good cut-off.
            {
                return -999; //return error.
            }

            //According to Google, the average weight of a 9 year old (which is the youngest age for this application) is around 64 pounds.
            //So, I think 50 pounds is a good cut-off point.
            if(weightInt < 50)
            {
                return -999; //return error.
            }

            return weightInt;
        }

      
        /// <summary>
        /// This function does simple checks on names. A name cannot be more than 18 characters long for 
        /// this application. Also, a name must be atleast 1 character long. Also, any spaces inputted with names, such
        /// as "Joh  n", are gotten rid of. So the return would be "John".
        /// PARAMETERS: a name
        /// RETURN: the name if it is valid. Otherwise, "-999" is returned.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        string getAndCheckName(string name)
        {
            //first and last name both being 18 chararcters long is roughly the maximum amount of space 
            //that can be taken up within the "CHECK BMI" form. If the names are of greater length than 18, 
            //The full name may go passed the edge of the form and thus be unreadable.
            //Also, names need to atleast be 1 character long.
            if(name.Length > 18 || name.Length < 1)
            {
                return "-999"; //return error.
            }

            //Also, any spaces in the first or last name will be gotten rid of.
            string nameStringWithoutSpaces = "";

            for(int i = 0; i < name.Length; i++)
            {
                if (name[i] != ' ')
                {
                    nameStringWithoutSpaces = nameStringWithoutSpaces + name[i];
                }
            }

            //Beyond checking length and spaces, names can pretty much be whatever. Supposedly
            //Elon Musk named his kid X A-12 or something...so I don't think there should be
            //a check on names beyond length and space requirements.
            return nameStringWithoutSpaces;
        }

        /// <summary>
        /// This function gets the height of the person from the height combo box.
        /// It converts the string found in the height combo box into an integer.
        /// This function then retruns the height as an integer.
        /// This is necessary if we wish to calculate the BMI.
        /// heighStr = the string value found in the Height Combo Box.
        /// PARAMTERS: The height of a person in inches (as a string).
        /// RETURN: The height of a person in inches (as an integer).
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        int calculateHeight(string heightStr)
        {
            int heightInt = 0;
            int tensPlace = heightStr.Length - 1;

            //Convert the string height into an integer height. For example: "68" converts to 68.
            for (int i = 0; i < heightStr.Length; i++)
            {
                heightInt = heightInt + ((int)(heightStr[i] - 48)) * (int)Math.Pow(10, tensPlace);
                tensPlace--;
            }


            return heightInt;
        }

        /// <summary>
        /// BMI = kilograms / m^2. This function converts the weight in pounds and the height in inches into
        /// kilograms and meters respectfully. It then returns the calcukated BMI of the person.
        /// RETURN TYPE: the BMI.
        /// </summary>
        /// <returns></returns>
        double calculateBMI(int weightInPounds, int heightInInches)
        {
            //https://www.rapidtables.com/convert/weight/how-pound-to-kg.html says
            //1 pound = 0.45359237 kg.
            double weightInKiloGrams = weightInPounds * 0.45359237;

            //https://www.rapidtables.com/convert/length/inch-to-meter.html says
            //1 inch = 0.0254 meters.
            double heightInMeters = heightInInches * 0.0254;

            //BMI = kg / m^2
            double BMI = weightInKiloGrams / (Math.Pow(heightInMeters, 2));

            //https://docs.microsoft.com/en-us/dotnet/api/system.math.round?view=netcore-3.1#Round7_Example
            //^How to round a number in the conventional sense. So 3.45 = 3.5 when rounded.
            //Most of the BMI calculators online that I saw give BMI only to the first decimal place.
            return Math.Round(BMI, 1, MidpointRounding.AwayFromZero);
        }
        
        //This is the form that pops up when the "CALCULATE BMI" button is pressed.
        Form2 form2 = new Form2();

        /// <summary>
        /// This method is called when the "CALCULATE BMI" button is clicked.
        /// It populates Form2 to show the person's first and last name, gender,
        /// age, target heart rate range, maximum heart rate, and BMI.
        /// PARAMETERS: The object sending the event and the event signal itself.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calcBMI_Click(object sender, EventArgs e)
        {

            int weight = calculateWeight(weightTextBox.Text); //get the person's weight in pounds.
            string firstName = getAndCheckName(firstNameText.Text); //get the person's first name.
            string lastName = getAndCheckName(lastNameText.Text); //get the person's last name.

            //If calculateWeight() returned an error.
            if (weight == -999)
            {
                MessageBox.Show("The range of acceptable values for weight is 50-800 pounds.");
            }
            else if(firstName == "-999" || lastName == "-999")
            {
                //If getAndCheckName() returned an error.
                MessageBox.Show("First and Last names must each be between 1-18 characters long.");
            }
            else
            {
                int age = calculateAge(); //get the person's age in years.

                //If age = -996, that means the selected month is February and the selected day is more than 29.
                if (age == -996)
                {
                    form2.Hide();
                    MessageBox.Show("February does not have more than 29 days, even on a Leap Year.");
                    
                }
                else if (age == -997)
                {
                    //if the selected month is February and the selected day is 29 and it is not a leap year,
                    //raise an error in a message box.
                    form2.Hide();
                    MessageBox.Show("February does not have more than 28 days when it is not a Leap Year.");
                    
                }
                else if (age == -998)
                {
                    //If the selected month does not have 31 days in it, but 31 was selected as the day,
                    //raise an error in a message box.
                    form2.Hide();
                    MessageBox.Show("The selected month does not have more than 30 days.");
                    
                }
                else
                {
                    //If the selected day is correct for the selected month.

                    int height = calculateHeight(heightComboBox.Text); //get the person's height in  inches.

                    int maxHeartRate = calculateMaxHeartRate(age); //get the person's max heart rate in beats-per-minute. 

                    string targetHeartRate = calculateTargetHeartRate(age); //get the person's target heart rate range.

                    double BMI = calculateBMI(weight, height); //Calculate the BMI

                    //Clear the info in the form.
                    form2.clear();
                    //Put this person's info in the form.
                    form2.setName(firstName);
                    form2.setName(lastName);
                    form2.setAge(age);
                    form2.setGender(genderText.Text);
                    form2.setMaxHeartRate(maxHeartRate);
                    form2.setTargetHeartRate(targetHeartRate);
                    form2.setWeight("" + weight);
                    form2.setHeight("" + height);
                    form2.setBMI(BMI);
                    form2.Show(); //make it visibile.
                }
            }
            
            


          
           
            
        }

        //This form contains the BMI chart as well as the Wikipedia link that the chart comes from.
        Form3 form3 = new Form3();
        /// <summary>
        /// This method is called when the user clicks on the "Show me the BMI chart" button.
        /// PARAMETERS: The object the event came from and the event signal itself.
        /// RETURN: none.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bmiChartShow_Click(object sender, EventArgs e)
        {
            //Show the form containing the BMI chart as well as the clickable link to the Wikipedia article
            //that the chart came from.
            form3.Show();
        }
    }
}
