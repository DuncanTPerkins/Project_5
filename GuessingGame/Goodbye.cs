//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:	    Project 5
//	File Name:		Goodbye.cs
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

namespace GuessingGame
{
    /// <summary>
    /// Form for thanking the user for using the application
    /// </summary>
    public partial class Goodbye : Form
    {
        /// <summary>
        /// parameterized constructor for Goodbye screen
        /// </summary>
        /// <param name="percent"></param>
        /// <param name="attempts"></param>
        public Goodbye(string percent, string attempts)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToParent();
            if (percent == "0")
            {
                percent = "0%";
            }
            lblScore.Text = "Your score was " + percent + " on " + attempts + " attempts.";
        }

        /// <summary>
        /// Click event for OK button on goodbye GUI 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
