//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:	    Project 5
//	File Name:		Splash.cs
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
    /// Class for displaying the splash screen before entering program
    /// </summary>
    public partial class Splash : Form
    {
        /// <summary>
        /// Default constructor for splash screen
        /// </summary>
        public Splash()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.us;
        }

        /// <summary>
        /// Event for timer tick for Splashscreen class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Countdown_Tick(object sender, EventArgs e)
        {
            Form Main = new CapitolGuesser();
            this.Hide();
            Main.Show();
            Countdown.Stop();
        }


    }
}
