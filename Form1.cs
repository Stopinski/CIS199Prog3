//Program 3
//Nathan Stopinski
//CIS 199 01
//Due 04/07/2015
//This program calculates the earliest registration time for a UofL student
//Dependant on variables last name and class standing. Please reference
//Spr 2015 Priority Registeration Schedule

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3
{
    public partial class prog3 : Form
    {
        public prog3()
        {
            InitializeComponent();
        }

        private void regTimeBtn_Click(object sender, EventArgs e)
        {
            
            const string DAY1 = "April 1"; //days of registration
            const string DAY2 = "April 2"; 
            const string DAY3 = "April 3"; 
            const string DAY4 = "April 6"; 
            const string DAY5 = "April 7"; 
            const string DAY6 = "April 8"; 

            const string TIME1 = "8:30 AM";  // registration time blocks
            const string TIME2 = "10:00 AM"; 
            const string TIME3 = "11:30 AM"; 
            const string TIME4 = "2:00 PM";  
            const string TIME5 = "4:00 PM";  

            string lastNameStr;       // Entered last name
            char lastNameLetterCh;    // First letter of last name, as char
            string dateStr = "Error"; // Holds date of registration
            string timeStr = "Error"; // Holds time of registration

            char[] namesSrJr = {'A', 'E', 'J', 'P', 'T'};                                                     //Array holding lower limits for name letter ranges for Juniors and Seniors
            char[] namesSoFr = { 'A', 'C', 'E', 'G', 'J', 'M', 'P', 'R', 'T', 'W'};                           //Array holding lower limits for name letter ranges for Soph and Freshman first registration days
            string[] srJrTimes = {TIME2, TIME3, TIME4, TIME5, TIME1 };                                        //Array holding time constants for seniors and juniors
            string[] sophFrTimes = { TIME3, TIME4, TIME5, TIME1, TIME2, TIME3, TIME4, TIME5, TIME1, TIME2 };  //Time constants for Sophomores and Freshman
            int sub1 = srJrTimes.Length - 1;                                                                  //Declare variable to keep range search within lower limits for Sr and Jr
            int sub2 = sophFrTimes.Length - 1;                                                                //Variable to keep range search within array limit for soph and Freshman
            
            lastNameStr = lastNameInput.Text;

            //Precondition: Must be accepted or reenrolling student at the University of Louisville

            if (lastNameStr == "") // Empty text box
                MessageBox.Show("Please enter last name!");
            else
            {
                lastNameLetterCh = lastNameStr[0]; //Focuses on first character of last name inputed.

                if (!char.IsLetter(lastNameLetterCh)) // Is it a letter or not?
                    MessageBox.Show("Please enter a valid (letters only) last name!");
                else
                {
                    lastNameLetterCh = char.ToUpper(lastNameLetterCh); // Ensure upper case

                    // Juniors and Seniors share same schedule but different days
                    if (jrBtn.Checked || seniorBtn.Checked)
                    {
                        if (seniorBtn.Checked)
                            dateStr = DAY1;
                        else // Must be juniors
                            dateStr = DAY2;

                        if (seniorBtn.Checked || jrBtn.Checked)
                        {
                            while (sub1 >= 0 && lastNameLetterCh < namesSrJr[sub1])
                                --sub1;
                            timeStr = srJrTimes[sub1];
                        }
                    }
                    // Sophomores and Freshmen
                    else
                    {
                        if (sophBtn.Checked)
                        {
                            // G-S on one day
                            if ((lastNameLetterCh >= 'G') &&
                                (lastNameLetterCh <= 'S'))
                                dateStr = DAY4;
                            else // All other letters on previous day
                                dateStr = DAY3;
                        }
                        else // must be freshman
                        {
                            // G-S on one day
                            if ((lastNameLetterCh >= 'G') && // >= G and
                                (lastNameLetterCh <= 'S'))   // <= S
                                dateStr = DAY6;
                            else // All other letters on previous day
                                dateStr = DAY5;
                        }

                        if (sophBtn.Checked || freshBtn.Checked)
                        {
                            while (sub2 >= 0 && lastNameLetterCh < namesSoFr[sub2])
                            --sub2;
                            timeStr = sophFrTimes[sub2];
                        }
                    }
                    MessageBox.Show(dateStr + " at " + timeStr);                       
                }
                
            }

            //Postcondition: Student must ensure advising appointment is made and that registration happens on or after scheduled time
            //in order for registration to go through and student to be enrolled.

        }
    }
}
