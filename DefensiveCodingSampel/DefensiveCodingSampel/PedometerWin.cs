﻿using DCS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefensiveCodingSampel
{
    public partial class PedometerWin : Form
    {
        public PedometerWin()
        {
            InitializeComponent();
        }

        private void Calculate_Button_Click(object sender, EventArgs e)
        {
            var customer = new Customer();

            try
            {
                var result = customer.CalculatePercentOfGoalSteps(this.GoalTextBox.Text,
                                                        this.StepsTextBox.Text);

                ResultLabel.Text = "You reached " + result + "% of your goal!";

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Your entry was not valid: " + ex.Message);
                ResultLabel.Text = string.Empty;
            }
        }

       
    }
}
