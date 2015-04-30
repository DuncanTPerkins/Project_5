//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:	    Project 5
//	File Name:		Capitol Guesser.cs
//	Description:    A quiz game for guessing state capitol matching
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Duncan Perkins, perkinsdt@goldmail.etsu.edu, Department of Computing, East Tennessee State University
//	Created:	    Monday, April 27th 2015
//	Copyright:		Duncan Perkins, 2015
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace GuessingGame
{
    /// <summary>
    /// Main class for Capitol Guessing Game 
    /// </summary>
    public partial class CapitolGuesser : Form
    {
        //dictionary for storing City-State combinations
        SortedDictionary<string, string> CapitalCities = new SortedDictionary<string, string>();

        //List containing just the names of the states 
        List<string> StateNames = new List<string>();

        //List containing just the names of the cities
        List<string> CityNames = new List<string>();

        //String reader for use with the text document
        StringReader reader = new StringReader(Properties.Resources.states);

        //Random object for picking the State capitol to guess
        Random r = new Random();

        //Checks to see if the timer has reached 0 
        bool isZero = false;

        //checks to see if the user has made a guess
        bool hasGuessed = false;

        //Time remaining in countdown
        int TimeLeft = 0;

        //Parsing the input oone line at a time 
        String StrLine;

        //default constructor for main guessing game class
        public CapitolGuesser()
        {
            InitializeComponent();
            //Read cities and states from file 
            try
            {
                while (reader.Peek() != -1)
                {
                    StrLine = reader.ReadLine();
                    String[] fields = StrLine.Split(',');
                    string city = fields[0].Trim(); ;
                    string state = fields[1].Trim(); ;
                    CapitalCities.Add(state, city);
                    StateNames.Add(state);
                }
            }
            //print out what went wrong
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            //Bind GUI listbox to values from SortedDictionary class
            CityNames = CapitalCities.Values.ToList<string>();
            CityNames.Sort();
            CityList.DataSource = new BindingSource(CityNames, null);

            //initialize first quiz question
            lblQuestion.Text = "What is the capital of " + StateNames[r.Next(0, StateNames.Count - 1)] + "?";
        }

        /// <summary>
        /// Event handler for "Next" button in GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!hasGuessed)
            {
                int num = Int32.Parse(txtAttempts.Text);
                num++;
                txtAttempts.Text = num.ToString();
            }
            hasGuessed = false;
            int n = 15;
            isZero = false;
            lblTimeRemaining.Text = n.ToString();
            TimeLeft = 15;
            Countdown.Start();
            lblQuestion.Text = "What is the capital of " + StateNames[r.Next(0, StateNames.Count - 1)] + "?";
            btnChoose.Enabled = true;
            lblright.Visible = false;
            lblwrong.Visible = false;
        }

        /// <summary>
        /// Event handler for tick event in GUI timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Countdown_Tick(object sender, EventArgs e)
        {
            TimeLeft = Int32.Parse(lblTimeRemaining.Text);
            if (TimeLeft == 0 && isZero == false)
            {
                isZero = true;
                hasGuessed = true;
                int m = Int32.Parse(txtAttempts.Text);
                m++;
                txtAttempts.Text = m.ToString();
                btnChoose.Enabled = false;
            }
            else if (TimeLeft > 0)
            {
                TimeLeft--;
            }
            lblTimeRemaining.Text = TimeLeft.ToString();

        }


        /// <summary>
        /// Event handler for "select" button in GUI, means the User has selected an option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChoose_Click(object sender, EventArgs e)
        {
            hasGuessed = true;
            btnChoose.Enabled = false;
            string value = CityList.GetItemText(CityList.SelectedItem);
            value = value.Trim();
            string key = lblQuestion.Text.Substring(23, lblQuestion.Text.Substring(23).Length - 1);

            //if the guess was correct
            if (CapitalCities[key] == value)
            {
                Countdown.Stop();
                lblright.Visible = true;
                int n = Int32.Parse(txtCorrect.Text);
                int m = Int32.Parse(txtAttempts.Text);
                n++;
                m++;
                txtCorrect.Text = n.ToString();
                txtAttempts.Text = m.ToString();
            }

            //if it wasn't
            else
            {
                Countdown.Stop();
                lblwrong.Visible = true;
                int m = Int32.Parse(txtAttempts.Text);
                m++;
                txtAttempts.Text = m.ToString();
            }
        }

        /// <summary>
        /// Event handler for changed values in the attempts field in the GUI 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAttempts_TextChanged(object sender, EventArgs e)
        {
            double percent = Double.Parse(txtCorrect.Text) / Double.Parse(txtAttempts.Text);
            if (percent == 0)
            {
                txtPercent.Text = "0";
            }
            else
            {
                txtPercent.Text = (Math.Round(percent, 4) * 100).ToString() + "%";
            }
        }

        /// <summary>
        /// Event handler for changed values in the correct field in the GUI 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCorrect_TextChanged(object sender, EventArgs e)
        {
            double percent = Double.Parse(txtCorrect.Text) / Double.Parse(txtAttempts.Text);
            if (percent == 0)
            {
                txtPercent.Text = "0";
            }
            else
            {
                txtPercent.Text = (Math.Round(percent, 4) * 100).ToString() + "%";
            }
        }

        /// <summary>
        /// Event handler for GUI exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnd_Click(object sender, EventArgs e)
        {
            Form form = new Goodbye(txtPercent.Text, txtAttempts.Text);
            form.Show();
        }

        /// <summary>
        /// Overridden OnClosing event to provide a goodbye dialog
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            Form form = new Goodbye(txtPercent.Text, txtAttempts.Text);
            form.Show();
        }
    }
}
