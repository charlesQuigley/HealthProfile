using System.Windows.Forms;

namespace HealthProfile
{
    partial class healthProfile
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(healthProfile));
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.genderText = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.heightComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bmiChartShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameText
            // 
            this.firstNameText.BackColor = System.Drawing.SystemColors.Window;
            this.firstNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameText.Location = new System.Drawing.Point(15, 158);
            this.firstNameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(128, 30);
            this.firstNameText.TabIndex = 0;
            this.firstNameText.Text = "John";
            // 
            // lastNameText
            // 
            this.lastNameText.BackColor = System.Drawing.SystemColors.Window;
            this.lastNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameText.Location = new System.Drawing.Point(180, 158);
            this.lastNameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(128, 30);
            this.lastNameText.TabIndex = 1;
            this.lastNameText.Text = "Doe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(15, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(180, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // genderText
            // 
            this.genderText.BackColor = System.Drawing.SystemColors.Window;
            this.genderText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genderText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.genderText.ForeColor = System.Drawing.SystemColors.Desktop;
            this.genderText.FormattingEnabled = true;
            this.genderText.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderText.Location = new System.Drawing.Point(345, 158);
            this.genderText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.genderText.Name = "genderText";
            this.genderText.Size = new System.Drawing.Size(205, 31);
            this.genderText.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(345, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Biological Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(15, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date of Birth (Day, Month, Year)";
            // 
            // dayComboBox
            // 
            this.dayComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayComboBox.Location = new System.Drawing.Point(15, 259);
            this.dayComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(72, 31);
            this.dayComboBox.TabIndex = 12;
            // 
            // monthComboBox
            // 
            this.monthComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthComboBox.Location = new System.Drawing.Point(123, 259);
            this.monthComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(115, 31);
            this.monthComboBox.TabIndex = 13;
            // 
            // yearComboBox
            // 
            this.yearComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Items.AddRange(new object[] {
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010"});
            this.yearComboBox.Location = new System.Drawing.Point(273, 259);
            this.yearComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(129, 31);
            this.yearComboBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(15, 324);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Height (inches)";
            // 
            // heightComboBox
            // 
            this.heightComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.heightComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.heightComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.heightComboBox.FormattingEnabled = true;
            this.heightComboBox.Items.AddRange(new object[] {
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96"});
            this.heightComboBox.Location = new System.Drawing.Point(15, 360);
            this.heightComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.heightComboBox.Name = "heightComboBox";
            this.heightComboBox.Size = new System.Drawing.Size(192, 31);
            this.heightComboBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(273, 322);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Weight (pounds)";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(276, 356);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(205, 30);
            this.weightTextBox.TabIndex = 18;
            this.weightTextBox.Text = "200";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(455, 360);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "lb";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(15, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(359, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Please fill in the text boxes with your information ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(15, 57);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "so we can create your Health Profile.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(15, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(385, 69);
            this.button1.TabIndex = 22;
            this.button1.Text = "Calculate BMI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.calcBMI_Click);
            // 
            // bmiChartShow
            // 
            this.bmiChartShow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bmiChartShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bmiChartShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bmiChartShow.Location = new System.Drawing.Point(15, 562);
            this.bmiChartShow.Name = "bmiChartShow";
            this.bmiChartShow.Size = new System.Drawing.Size(385, 69);
            this.bmiChartShow.TabIndex = 23;
            this.bmiChartShow.Text = "Show me the BMI chart";
            this.bmiChartShow.UseVisualStyleBackColor = false;
            this.bmiChartShow.Click += new System.EventHandler(this.bmiChartShow_Click);
            // 
            // healthProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(622, 707);
            this.Controls.Add(this.bmiChartShow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.heightComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.dayComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.genderText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "healthProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Health Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        ///This function allows comboboxes to show text as soon as the application starts.
        ///There does not seem to be a way to do this with Windows Form Designer Generated code.
        ///So, I specify that text should be shown within these combo boxes as soon as the application starts
        ///outside of the InitializeComponent method.
        ///I put this here because I want the comboboxes to show text as soon as the 
        ///application starts. This is for user-interface purposes. 
        ///I want to make it very clear what goes in each text box.
        ///I cannot put this code in the Windows Form Designer generated code
        ///area because the Windows Form Designer keeps auto-deleteing them.
        ///So, I place them here.
        private void AdditionalComponentBehavior()
        {
            genderText.SelectedItem = "Male"; 
            dayComboBox.SelectedItem = "18";  //Paul McCartney's birthday was June 18 1942. So That will be the initial text.
            monthComboBox.SelectedItem = "June";
            yearComboBox.SelectedItem = "1942";
            heightComboBox.SelectedItem = "71"; //Paul McCartney is 5'11" = 71 inches.

        }
        
        

        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox genderText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dayComboBox;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox heightComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Button button1;
        private Button bmiChartShow;
    }
}

